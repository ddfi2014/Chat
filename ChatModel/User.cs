using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatModell
{
    class User
    {
        private string name;

        private int age;

        private EUser userType;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public EUser UserType { get => userType; set => userType = value; }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
