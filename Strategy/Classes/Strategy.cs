using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Classes
{
    public interface payment
    {
        void pay();
    }

    class PayCard : payment
    {
        PayCardForm form;
        public PayCard(Order order) 
        {
            form = new PayCardForm(order);
        }
        public void pay()
        {
            form.ShowDialog();
        }
    }

    public class PaySPB : payment
    {
        QRCode code;
        public PaySPB()
        {
            code = new QRCode();
        }
        public void pay()
        {
            code.ShowDialog();
        }
    }

    public class PayTranslation : payment
    {
        Translation form;
        public PayTranslation(Order order)
        {
            form = new Translation(order);
        }
        public void pay()
        {
            form.ShowDialog();
        }
    }
}
