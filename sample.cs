using System;
using log4net;
using log4net.Config;

class Sample
{
    static void Main(string[] args) 
    {
        XmlConfigurator.Configure(new System.IO.FileInfo("./log4net.config"));

        ILog logger = LogManager.GetLogger("mylogger");

        logger.Info("log4net : Sample start");
        logger.Info("log4net : Sample end");


        logger = LogManager.GetLogger("async_mylogger");
        logger.Info("log4net Async : Sample start");
        logger.Info("log4net Async : Sample end");

        logger = LogManager.GetLogger("unknown");
        logger.Info("log4net unknown : Sample start");
        logger.Info("log4net unknown : Sample end");
    }
}
