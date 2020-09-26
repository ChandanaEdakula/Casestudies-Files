using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuiceShopEntities
{
    public class Juice
    {
        public int Juice_id { get; set; }
        public string Juice_flavour { get; set; }
        public int Price { get; set; }
    }
    public class JuiceParchased
    {
        public int Purchase_no { get; set; }
        public int Juice_id { get; set; }
        public int Quantity { get; set; }
        public int Amount { get; set; }
    }
}
