using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battery_Testing
{
    public interface ICommandChain
    {
        void Connect(string selectedPort);
        Task Execute(string command);
        Task Execute(string command, Action resultHandler);
        Task Execute(string command, Action<string> resultHandler);
        void Close();
    }
}
