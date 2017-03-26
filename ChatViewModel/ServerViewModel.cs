using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatModell;

namespace ChatViewModel
{
    public class ServerViewModel
    {
        public static List<IServerView> views = new List<IServerView>();

        private static ServerViewModel instance = null;

        private ServerModel modell;

        private ServerViewModel()
        {
            modell = ServerModel.GetInstance();
        }

        public static ServerViewModel GetController()
        {
            if (instance == null)
            {
                instance = new ServerViewModel();
            }
            return instance;
        }

        public void AddView(IServerView view)
        {
            views.Add(view);
        }

        public static void TellClients()
        {
            //Clients verständigen
        }
    }
}
