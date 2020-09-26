using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFEmpServiceLib; //for WCF interface and classes

using System.ServiceModel; // for ServiceHost class
namespace WCFConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost svcHost = new ServiceHost(typeof(WCFEmpServiceLib.EmpService));
            svcHost.Open();
            Console.WriteLine("Service started....");

            Console.ReadLine();
            Console.WriteLine("Service stopped");
        }
    }
}
