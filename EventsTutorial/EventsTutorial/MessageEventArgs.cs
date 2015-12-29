using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsTutorial
{
    public sealed class MessageEventArgs : EventArgs
    {
        public string Message { get; private set; }
        public MessageEventArgs(string message)
        {
            this.Message = message;
        }
    }
}
