using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatViewModel
{
    [Obsolete("IServerView is deprecated due to change from MVC to MVVM.")]
    public interface IServerView
    {
        void AddMessage(string message);

        void ChangeState(string command);
    }
}
