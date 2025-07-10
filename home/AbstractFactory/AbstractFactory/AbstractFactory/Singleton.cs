using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Planet
    {
        public int ContinetNumber { get; set; }

        public string Name { get; set; }

        public Planet(string name, int continetNumber)
        {
            Name = name;
            ContinetNumber = continetNumber;
        }
    }

    public class Mars : Planet
    {

        public int Population { get; set; }

        public static Mars Instance { get; set; }

        public Mars() : base("mars", 5)
        {
        }

        public Mars GetInstance()
        {
            if (Instance == null)
                Instance = new Mars();

            return Instance;
        }
    }




    //---------- Sample 2 ------------------------------------------



    public class LoggerService
    {

        //backing field
        private static LoggerService _instance { get; set; }


        private static object _lockObject;


        public static LoggerService Instance
        {
            get
            {
                lock (_lockObject)
                {
                    if (_instance == null)
                        _instance = new LoggerService();
                }

                return _instance;
            }
        }

        public List<LoggerMessage> Messages { get; set; }

        private LoggerService()
        {

        }

        public void Log(LoggerMessage loggerMessage)
        {
            Messages.Add(loggerMessage);
        }
    }

    public enum LogType
    {
        Error,
        Info
    }

    public class LoggerMessage
    {
        public LogType LogType { get; set; }

        public string Message { get; set; }
    }


    public class LoggerProvider
    {
        public static void LogInfo(string message)
        {
            LoggerService.Instance.Log(new LoggerMessage
            {
                LogType = LogType.Info,
                Message = message
            });
        }

        public static void LogError(string message)
        {
            LoggerService.Instance.Log(new LoggerMessage
            {
                LogType = LogType.Info,
                Message = message
            });
        }
    }

}
