using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatModell
{
    public class ClientModel
    {
        private string name = "";

        public string Name { get { return name; } set { name = value; } }

        private string passwort = "";

        public string Passwort { get { return passwort; } }

        private bool isModerator = false;

        public bool IsModerator { get { return isModerator; } }


        public ClientModel(string name, string passwort)
        {
            this.name = name;
            this.passwort = passwort;
        }
    }
}
