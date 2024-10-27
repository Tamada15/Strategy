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

namespace Strategy
{
    public partial class QRCode : MaterialForm
    {
        public QRCode()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple500, Primary.DeepPurple600, Primary.DeepPurple600, Accent.LightBlue200, TextShade.WHITE);
            Time();
        }

        async public void Time()
        {
            int value = 20;
            while (value > 0)
            {
                materialLabel3.Text = value.ToString();
                value--;
                await Task.Delay(1000);
            }
            MessageBox.Show("Оплата прошла успешно!");
            Application.Exit();
        }

        private void QRCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
