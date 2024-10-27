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
    public partial class InputCode : MaterialForm
    {
        Client client;
        Order order;
        public InputCode(Order order)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple500, Primary.DeepPurple600, Primary.DeepPurple600, Accent.LightBlue200, TextShade.WHITE);
            this.order = order;
            client = new Client();
            client.payment = new PayCard(this.order);
        }


        private void materialTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[0-9]").Success)
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (materialTextBox1.Text == "")
                {
                    MessageBox.Show("Пин-код не верный!");
                }

                else
                {
                    this.Hide();
                    client.Pay();
                }
            }
            e.KeyChar = '*';
        }
    }
}
