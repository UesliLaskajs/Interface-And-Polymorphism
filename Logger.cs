using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Interface
{

    public interface ILogger
    {
        void Log(string message);
    }


    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Baic Logger:{message}");
        }
    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            string directoryPath = @"C:\Logs";
            string FilePath = Path.Combine(directoryPath, "log.txt");

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.AppendAllText(message, FilePath);
        }
    }

    //Decoupling refers to the separation of components in a software system to reduce dependencies between them.
    //This practice allows changes to be made in one part of the system without affecting others, enhancing maintainability and flexibility.


    public class Application
    {
        private readonly ILogger _logger;

        public Application(ILogger process)
        {
            _logger = process;
        }

        public void DisplayLog() {
            _logger.Log("Work Started");
            Thread.Sleep(600);
            _logger.Log("Work Done");
        }

    }
}