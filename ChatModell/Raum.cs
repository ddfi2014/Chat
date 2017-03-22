using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatModell
{
    class Raum
    {
        private String name;
        private String passwort;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                this.name = value;
            }
        }

        public string Passwort
        {
            get
            {
                return passwort;
            }

            set
            {
                this.passwort = value;
            }
        }
    }
}
