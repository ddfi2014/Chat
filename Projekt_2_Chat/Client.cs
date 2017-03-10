using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_2_Chat
{
    class Client
    {
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
        }

        public void AddMessage()
        {
            //fügt die Nachricht in die entsprechende liste 
        }

        public void Login()
        {
            //prüfung der Daten
        }

        public void Logoff()
        {
            //Server, anwendung beenden entfernt sich selber aus der liste
        }

    }
}
