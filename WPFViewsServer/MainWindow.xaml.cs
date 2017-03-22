using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ChatViewModel;
using Projekt_2_Chat;

namespace WPFViewsServer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IServerView
    {
        private ServerViewModel controller;

        public MainWindow()
        {
            InitializeComponent();
            InitializeView();
        }

        public void InitializeView()
        {
            controller = ServerViewModel.GetController();
            controller.AddView(this);
        }

        public void AddMessage(string message)
        {
            throw new NotImplementedException();
        }

        public void ChangeState(string command)
        {
            throw new NotImplementedException();
        }
    }
}
