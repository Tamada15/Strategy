using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Classes
{
    public class Client
    {
        public payment payment { private get; set; }
        public void Pay()
        {
            payment.pay();
        }
    }
}
