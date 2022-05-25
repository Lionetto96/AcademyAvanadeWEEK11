using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary1;

namespace ConsoleApp_Wcf
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(
                typeof(EmployeeService)))
            {
                //host aperto per poter ...
                host.Open();
                Console.WriteLine("selfHosting started");
                Console.WriteLine("press any key");
                Console.ReadKey();
            }
        }
    }
}
