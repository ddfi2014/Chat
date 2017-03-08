using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost sh = new ServiceHost(typeof(Chat_Service)))
            {
                sh.Open();
                Console.WriteLine("Service bereit....");
                Console.ReadLine();
            }
        }
    }
}
