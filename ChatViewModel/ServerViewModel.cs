using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatModell;
using System.ComponentModel;
using System.Windows.Input;

namespace ChatViewModel
{
    public class ServerViewModel : INotifyPropertyChanged
    {
        public static List<IServerView> views = new List<IServerView>();

        private static ServerViewModel instance = null;

        private ServerModel modell;

        public ICommand StartCommand { get; set; }
        public ICommand StopCommand { get; set; }
        public ICommand TimeOutCommand { get; set; }
        public ICommand BanCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

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
