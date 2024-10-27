using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Strategy.Classes;

namespace Strategy
{
    public partial class Form1 : MaterialForm
    {
        InputCode InputCode;
        QRCode QRCode;
        Order order;
        Client client;
        public Form1(Order order)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple500, Primary.DeepPurple600, Primary.DeepPurple600, Accent.LightBlue200, TextShade.WHITE);
            this.order = order;
            client = new Client();
            InputCode = new InputCode(order);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            InputCode.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            client.payment = new PaySPB();
            this.Hide();
            client.Pay();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            client.payment = new PayTranslation(order);
            this.Hide();
            client.Pay();
        }
    }
}
