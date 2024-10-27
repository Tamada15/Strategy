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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strategy
{
    public partial class PayCardForm : MaterialForm
    {
        Order Order;
        public PayCardForm(Order order)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple500, Primary.DeepPurple600, Primary.DeepPurple600, Accent.LightBlue200, TextShade.WHITE);
            this.Order = order;
            materialLabel2.Text = Order.value.ToString();
            for (int i = 0; i != Order.products.Count; i++)
            {
                materialListView1.Items[i].Text = Order.products[i].name.ToString();
                materialListView1.Items[i].SubItems.Add(Order.products[i].value.ToString());
            }
        }
        private void materialButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Оплата прошла успешно!");
            Application.Exit();
        }
    }
}
