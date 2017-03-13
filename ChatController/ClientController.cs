using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatController
{
    class ClientController
    {
        List<User> UserListe;

        //der Server muss immer die daten an alle Client schicken sobald eine änderung geschieht (Broadcast)

        public void OpenPrivateChat(Client client)
        {
            //new Private_chat();  User muss mitgegeben werden
        }
        public void MuteUser()
        {
            // fügt keine nachrichten von diesem User in deine Liste
        }

        public void AddUserToList()
        {
            //Fügt neue User in die Aktuell Online liste

            //UserListe.Add();
        }

        public void AddMessage(String message)
        {
            //fügt die Nachricht in die entsprechende liste
            //richTextBoxChatWindow.Add(message);
        }

        public void Login()
        {
            //prüfung der Daten

            //textBoxUserName
            //passwordBox
        }

        public void Logoff()
        {
            //Server, anwendung beenden entfernt sich selber aus der liste


        }

    }
}
