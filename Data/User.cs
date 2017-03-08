using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
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
                name = value;
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
                passwort = value;
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
                moderator = value;
            }
        }
    }
}
