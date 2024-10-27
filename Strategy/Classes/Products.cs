using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Classes
{
    public abstract class Products
    {
        public string name;
        public int value;
        public int price;
        public Products(string name,int value,int price)
        {
            this.name = name;
            this.value = value;
            this.price = price;
        }
    }

    public class Orange:Products
    {
        public Orange(string name = "Апельсин", int value = 0,int price = 15):base(name, value,price)
        {

        }
    }

    public class Apple : Products
    {
        public Apple(string name = "Яблоко", int value = 0,int price = 10) : base(name, value, price)
        {

        }
    }
}
