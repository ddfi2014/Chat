using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatModell
{
    public class Room
    {
        private string name;

        private List<User> users;

        public string Name { get { return name; } set { name = value; } }

        public Room(string name)
        {
            Name = name;
        }
    }
}
