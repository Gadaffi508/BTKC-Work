// See https://aka.ms/new-console-template for more information
namespace NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomManager customManager = new CustomManager(StubLogger.GetLogger());
            customManager.Save();
            Console.ReadLine();
        }
        class CustomManager
        {
            private ILogger _logger;
            public CustomManager(ILogger logger)
            {
                _logger = logger;
            }

            public void Save()
            {
                Console.WriteLine("Saved");
                _logger.log();
            }
        }
        interface ILogger
        {
            void log();
        }
        class Log4NetLogger : ILogger
        {
            public void log()
            {
                Console.WriteLine("Logged with log4netLogger");
            }
        }
        class NLogLogger : ILogger
        {
            public void log()
            {
                Console.WriteLine("Logged with nloglogger");
            }
        }
        class StubLogger : ILogger
        {
            private static StubLogger _stubLogger;
            private static object _lock=new object();
            private StubLogger() { }
            public static StubLogger GetLogger()
            {
                lock(_lock)
                {
                    if(_stubLogger == null)
                    {
                        _stubLogger = new StubLogger();
                    }
                }
                return _stubLogger;
            }
            public void log()
            {
                
            }
        }
        class CustomerManagerTest
        {
            public void SaveTest()
            {
                CustomManager customManager = new CustomManager(StubLogger.GetLogger());
                customManager.Save();
            }
        }
    }
}
