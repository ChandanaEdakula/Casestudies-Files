using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WCFConsoleClient.ServiceReference1; //for WCF Proxy class
namespace WCFConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpServiceClient proxy = new EmpServiceClient();
            string result = proxy.GetData(100);

            Console.WriteLine(result);
        }
    }
}
