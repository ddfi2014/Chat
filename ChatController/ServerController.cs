using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatController
{
    class ServerController
    {
        /*static void Main(string[] args)
        {
        }*/

        public void CreateRoom()
        {
            //Chatraum erstellen
        }
        public void TellClients()
        {
            //Clients verständigen
        }
        public void checkDos(String ip, long ms)
        {
            //Vergleicht Zeiten der Anmeldeversuche einer gleichen IP-Adresse, bei zu vielen Versuchen in einem bestimmten Zeitintervall wird die IP-Adresse gebannt.
            DateTime start;
            TimeSpan time;

            start = DateTime.Now;

            // -- bei TimeSpan weiß ich noch nicht ob das wirklich dafür taugt 

            time = DateTime.Now - start;
        }

        public void checkSpam()
        {
            //Wenn ein User viele Nachrichten in einer kurzen Zeit abschickt wird seine Nachrichtenfunktion für 30 Sekunden blockiert und er bekommt eine Mitteilung darüber.
            //Oder der User muss ein Captcha lösen um zu beweisen das er kein Spammbot ist 
            DateTime start;
            TimeSpan time;

            start = DateTime.Now;

            // --

            time = DateTime.Now - start;
        }
        public Boolean checkForBan()
        {
            //bei jeder Anmeldung wird geprüft ob der User gebannt ist (banList)
            return false;
        }

        public string getTimestamp()
        {
            //zeitstempel für nachrichten
            String timeStamp = DateTime.Now.ToString("HH:mm:ss tt");
            return timeStamp;
        }
    }
}