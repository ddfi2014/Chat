using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatViewModel
{
    public interface IServerView
    {
        void AddMessage(string message);

        void ChangeState(string command);
    }
}
