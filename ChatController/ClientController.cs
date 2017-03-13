using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatModell;
using System.Windows.Input;

namespace ChatController
{
    class ClientController
    {
        List<ClientModell> UserListe;

        private ICommand buttonSignup;
        private ICommand buttonSignin;

        public ICommand ButtonSignup
        {
            get { return buttonSignup; }
            set { buttonSignup = value; }
        }

        public ICommand ButtonSignin
        {
            get { return buttonSignin; }
            set { buttonSignin = value; }
        }

        public void ButtonManagement() {
            buttonSignin = new UserCommand(new Action<object>(Login));
            buttonSignup = new UserCommand(new Action<object>(Registrieren));
        }

        private void Registrieren(object obj)
        {
           //Verweis auf die neue Form
        }

        //der Server muss immer die daten an alle Client schicken sobald eine änderung geschieht (Broadcast)

        public void OpenPrivateChat(ClientModell client)
        {
            //new Private_chat();  User muss mitgegeben werden
        }
        public void MuteUser()
        {
            // fügt keine nachrichten von diesem User in deine Liste
        }

        public void AddUserToList(ClientModell client)
        {
            //Fügt neue User in die Aktuell Online liste

            UserListe.Add(client);
        }

        public void AddMessage(String message)
        {
            //fügt die Nachricht in die entsprechende liste
            //richTextBoxChatWindow.Add(message);
        }

        public void Login(Object obj)
        {
            //prüfung der Daten
           
        }

        public void Logoff(ClientModell client)
        {
            //Server, anwendung beenden entfernt sich selber aus der liste

            UserListe.Remove(client);
            ServerController.TellClients();

        }

    }
}
