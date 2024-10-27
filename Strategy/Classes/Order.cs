using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Classes
{
    public class Order
    {
        public List<Products> products;
        public int value;
        public Order()
        {
            products = new List<Products>() { };
        }
    }




}
