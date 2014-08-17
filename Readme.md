#  log4net sample

## build

    $ dmcs -reference:log4net.dll,Log4Net.Async.dll sample.cs 

## run

    $ mono sample.exe
    INFO 2014-08-17 14:08:00,902 [1] - log4net : Sample start
    INFO 2014-08-17 14:08:00,914 [1] - log4net : Sample end
    INFO 2014-08-17 14:08:00,914 [1] - log4net Async : Sample start
    INFO 2014-08-17 14:08:00,915 [1] - log4net Async : Sample end
    INFO 2014-08-17 14:08:00,915 [1] - log4net unknown : Sample start
    INFO 2014-08-17 14:08:00,915 [1] - log4net unknown : Sample end

    $ cat logs/sample.log
    INFO 2014-08-17 14:08:00,902 [1] - log4net : Sample start
    INFO 2014-08-17 14:08:00,914 [1] - log4net : Sample end
    INFO 2014-08-17 14:08:00,914 [1] - log4net Async : Sample start
    INFO 2014-08-17 14:08:00,915 [1] - log4net Async : Sample end
