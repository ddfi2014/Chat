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

        public void openPrivateChat(Client client)
        {
            //new Private_chat();  User muss mitgegeben werden
        }
        public void muteUser()
        {
             // fügt keine nachrichten von diesem User in deine Liste
        }

        public void addUserToList()
        {
            //Fügt neue User in die Aktuell Online liste
        }

        public void addMessage()
        {
            //fügt die Nachricht in die entsprechende liste 
        }

        public void login()
        {
            //prüfung der Daten
        }

        public void logoff()
        {
            //Server, anwendung beenden entfernt sich selber aus der liste
        }

    }
}
