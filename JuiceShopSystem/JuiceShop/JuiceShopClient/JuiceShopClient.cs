using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuiceShopEntities;
using JuiceShopDAL;
using JuiceShopBusinessManager;
namespace JuiceShopClient
{
    class JuiceShopClient
    {
        static void Main(string[] args)
        {
            JuiceShopDal jsp1 = new JuiceShopDal();
            Console.WriteLine("Available Juice Flavors:");
            Console.WriteLine("***********************");
            Console.WriteLine("ID\tFlavor\tPrice");
            Console.WriteLine("***********************");

            List<Juice> listjuices = jsp1.GetAlljuice();
            foreach (Juice j in listjuices)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t", j.Juice_id, j.Juice_flavour, j.Price);
            }

            JuiceShopBusinessMangr jsp = new JuiceShopBusinessMangr();
            Console.Write("Enter the Juice Flavor Id: ");
            int jid = int.Parse(Console.ReadLine());
            Console.Write("enter the quantity:   ");
            int qty = int.Parse(Console.ReadLine());
            jsp.AddJuicePurchase(jid, qty);
            Console.WriteLine("want to continue more y/n");
            string x = (Console.ReadLine());
            String s;
            if (x == "y")
            {
                do
                {
                    JuiceShopDal jsp2 = new JuiceShopDal();
                    Console.Write("Available Juice Flavors:");
                    Console.WriteLine("\n************************");
                    Console.Write("ID\tFlavor\tPrice");
                    Console.WriteLine("\n*************************");


                    foreach (Juice j in listjuices)
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t", j.Juice_id, j.Juice_flavour, j.Price);
                    }
                    Console.Write("Enter the Juice Flavor Id:");
                    int jpid = int.Parse(Console.ReadLine());
                    Console.Write("enter the quantity");
                    int pqty = int.Parse(Console.ReadLine());
                    jsp.AddJuicePurchase(jpid, pqty);
                    Console.WriteLine("want to continue more y/n");
                    s = (Console.ReadLine());
                } while (s=="y");
            }
                List<JuiceParchased> j1 = jsp.GetAllJuicePurchased();
                int Sum = 0;
                Sum = int.Parse(Console.ReadLine());
                foreach (JuiceParchased j2 in j1)
                {

                    Sum = Sum + j2.Amount;
                }


            Console.WriteLine("Total Purchase:{0}", Sum);
            
           
        }
       
    }
}
