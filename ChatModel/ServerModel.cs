using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatModell
{
    public class ServerModel
    {
        private static ServerModel instance = null;

        public int Port { get; set; }

        public string Message { get; set; }

        private List<ClientProxy> clients;

        private List<Room> rooms;

        private ServerModel()
        {
            clients = new List<ClientProxy>();
            rooms = new List<Room>();
        }

        public static ServerModel GetInstance()
        {
            if (instance == null)
            {
                instance = new ServerModel();
            }
            return instance;
        }

        public void StartServer()
        {
            
        }

        public void StopServer()
        {
            
        }

        public void TimeOutUser(ClientProxy cpm)
        {

        }

        public void BanUser(ClientProxy cpm)
        {

        }
    }
}
