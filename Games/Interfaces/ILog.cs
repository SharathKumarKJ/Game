using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Interfaces
{
   public interface ILog<T>
    {
        void LogError(T value);
        void LogInformation(T value);
    }
}
