using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_2_Chat
{
    public class Server
    {
        Server srv = null;

        private Server()
        {
            
        }

        //Benötigt die methoden 

        public void TellClients()
        {
            //Clients verständigen
        }

        public Server GetInstance()
        {
            if (this.srv.Equals(null))
            {
                this.srv = new Server();
            }
            return this.srv;
        }

        public void CheckDos(String ip, long ms)
        {
            //Vergleicht Zeiten der Anmeldeversuche einer gleichen IP-Adresse, bei zu vielen Versuchen in einem bestimmten Zeitintervall wird die IP-Adresse gebannt.
            DateTime start;
            TimeSpan time;

            start = DateTime.Now;

            // -- bei TimeSpan weiß ich noch nicht ob das wirklich dafür taugt 

            time = DateTime.Now - start;
        }

        public void CheckSpam()
        {
            //Wenn ein User viele Nachrichten in einer kurzen Zeit abschickt wird seine Nachrichtenfunktion für 30 Sekunden blockiert und er bekommt eine Mitteilung darüber.
            //Oder der User muss ein Captcha lösen um zu beweisen das er kein Spammbot ist 
            DateTime start;
            TimeSpan time;

            start = DateTime.Now;

            // --

            time = DateTime.Now - start;
        }

        public Boolean CheckForBan()
        {
            //bei jeder Anmeldung wird geprüft ob der User gebannt ist (banList)
            return false;
        }

        public string GetTimestamp()
        {
            //zeitstempel für nachrichten
            String timeStamp = DateTime.Now.ToString("HH:mm:ss tt");
            return timeStamp;
        }
    }
}

