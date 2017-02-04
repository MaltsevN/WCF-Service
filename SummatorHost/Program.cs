using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace CalculateHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(WCF_Service.CalculateService)))
            {
                host.Open();
                Console.WriteLine("Host is on");
                Console.ReadKey();
            }
        }
    }
}
