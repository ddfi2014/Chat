using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_2_Chat
{
    public class Server
    {
        Server srv = null;

        private Server()
        {
            
        }

        //Benötigt die methoden 

        public void TellClients()
        {
            //Clients verständigen
        }

        public Server GetInstance()
        {
            if (this.srv.Equals(null))
            {
                this.srv = new Server();
            }
            return this.srv;
        }
    }
}
