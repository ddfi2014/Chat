using ChatModell;
using WPFView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Forms;

namespace ChatViewModel
{
    class ClientViewModel
    {
        List<ClientModel> UserListe;

        private ICommand buttonSignup;
        private ICommand buttonSignin;
        private ICommand buttonSend;
        private ICommand buttonSendprivate;
        private ICommand buttonAddnewChatroom;
        private ICommand buttonaddnewServer;
        private ICommand buttonCreatenewChatroom;
        private ICommand buttonCreatenewServer;

        public ICommand ButtonaddnewServer
        {
            get { return buttonaddnewServer; }
            set { buttonaddnewServer = value; }
        }
        public ICommand ButtonCreatenewServer
        {
            get { return buttonCreatenewServer; }
            set { buttonCreatenewServer = value; }
        }
        public ICommand ButtonCreatenewChatroom
        {
            get { return buttonCreatenewChatroom; }
            set { buttonCreatenewChatroom = value; }
        }
        public ICommand ButtonAddnewChatroom
        {
            get { return buttonAddnewChatroom; }
            set { buttonAddnewChatroom = value; }
        }
        public ICommand ButtonSend
        {
            get { return buttonSend; }
            set { buttonSend = value; }
        }
        public ICommand ButtonSendprivate
        {
            get { return buttonSendprivate; }
            set { buttonSendprivate = value; }
        }
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
            buttonSend = new UserCommand(new Action<object>(AddMessagepublic));
            buttonSendprivate = new UserCommand(new Action<object>(AddMessageprivate));
            buttonAddnewChatroom = new UserCommand(new Action<object>(addRoom));
            buttonCreatenewChatroom = new UserCommand(new Action<object>(CreateRoom));
            buttonaddnewServer = new UserCommand(new Action<object>(addServer));
            buttonCreatenewServer = new UserCommand(new Action<object>(CreateNewServer));
        }

        private void addServer(object obj)
        {
            new WPFView.AddServer();
        }

        private void CreateNewServer(object obj)
        {
            //new Server(Eigenschaften)
        }

        private void addRoom(object obj)
        {
            new WPFView.AddChatRoom();

        }
        private void CreateRoom(object obj)
        {
            Room raum = new Room("");  //(name,passwort); Werte aus den Textboxen
            //combobox.add(raum)
        }


        private void Registrieren(object obj)
        {
            //Verweis auf die neue Form Registrieren
                        //if passwort = confirm passwort
            //then 
            new ClientModel("name","passwort");//Mitgabe der Textfelder (Name / Passwort)
            //else
            MessageBox.Show("Passwort stimmen nicht Überein");
        }

        //der Server muss immer die daten an alle Client schicken sobald eine änderung geschieht (Broadcast)

        public void OpenPrivateChat(ClientModel client)
        {
            //new Private_chat();  User muss mitgegeben werden
        }
        public void MuteUser()
        {
            // fügt keine nachrichten von diesem User in deine Liste
            // getSelectedUser() <- selektierten User nicht mehr schreiben lassen 
        }

        public void AddUserToList(ClientModel client)
        {
            //Fügt neue User in die Aktuell Online liste

            UserListe.Add(client);
        }

        public void AddMessageprivate(Object obj)
        {
            //fügt die Nachricht in die entsprechende liste
            //richTextBoxChatWindow.Add(message);
        }
        public void AddMessagepublic(Object obj)
        {
            //fügt die Nachricht in die entsprechende liste
            //richTextBoxChatWindow.Add(message);
        }

        public void Login(Object obj)
        {
            //prüfung der Daten
            //richtig

            //falsch
            MessageBox.Show("Passwort stimmt nicht Überein");
        }

        public void Logoff(ClientModel client)
        {
            //Server, anwendung beenden entfernt sich selber aus der liste
            UserListe.Remove(client);
            ServerViewModel.TellClients();
            Application.Exit();
        }
        public void CreateRoom()
        {
            //Chatraum erstellen
        }
    }
}