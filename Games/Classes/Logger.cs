using Games.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Classes
{
    class ConsoleLog : ILog<string>
    {
        public void LogError(string value)
        {
            Console.WriteLine("Error :" + value);
        }

        public void LogInformation(string value)
        {
            Console.WriteLine("Information :" + value);
        }
    }

    class FileLog : ILog<string>
    {
        public void LogError(string value)
        {
            throw new NotImplementedException();
        }

        public void LogInformation(string value)
        {
            throw new NotImplementedException();
        }
    }


    class DataBaseLog : ILog<string>
    {
        public void LogError(string value)
        {
            throw new NotImplementedException();
        }

        public void LogInformation(string value)
        { 
            throw new NotImplementedException();
        }
    }
}
