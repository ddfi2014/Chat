using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatModell
{
    public class User
    {
        String name;
        String passwort;
        int moderator;

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

        public int Moderator
        {
            get
            {
                return moderator;
            }

            set
            {
                this.moderator = value;
            }
        }
    }
}