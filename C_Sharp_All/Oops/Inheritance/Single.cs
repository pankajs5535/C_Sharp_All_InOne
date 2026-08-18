using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shap_All.Oops.Inheritance
{
    public class BaseLogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log Entry: {message}");
        }
    }

    public class FileLogger : BaseLogger
    {
        public void LogToFile(string message)
        {
            Log(message); // Reuse base class method
            Console.WriteLine($"Logging to file: {message}");
        }
    }

    class Singel
    {
        static void Main1(string[] args)
        {
            FileLogger logger = new FileLogger();
            logger.LogToFile("Starting the application");
        }
    }

}
