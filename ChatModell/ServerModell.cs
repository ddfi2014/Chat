using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatModell
{
    class ServerModell
    {
        ServerModell srv = null;

        public ServerModell GetInstance()
        {
            if (this.srv.Equals(null))
            {
                this.srv = new ServerModell();
            }
            return this.srv;
        }
    }
}