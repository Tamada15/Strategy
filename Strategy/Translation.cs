using MaterialSkin;
using MaterialSkin.Controls;
using Strategy.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strategy
{
    public partial class Translation : MaterialForm
    {
        Order Order;
        public Translation(Order order)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple500, Primary.DeepPurple600, Primary.DeepPurple600, Accent.LightBlue200, TextShade.WHITE);
            Order = order;
            materialLabel2.Text = Order.value.ToString();
            for (int i = 0; i != Order.products.Count; i++)
            {
                materialListView1.Items[i].Text = Order.products[i].name.ToString();
                materialListView1.Items[i].SubItems.Add(Order.products[i].value.ToString());
            }
            Time();
        }
        async public void Time()
        {
            int value = 10;
            while (value > 0)
            {
                materialLabel5.Text = value.ToString();
                value--;
                await Task.Delay(1000);
            }
            MessageBox.Show("Оплата прошла успешно!");
            Application.Exit();
        }

        private void Translation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
