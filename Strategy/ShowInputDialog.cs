using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class ShowInputDialog : MaterialForm
    {
        ChoiceProduct ChoiceProduct;
        public ShowInputDialog(ChoiceProduct choiceProduct)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple500, Primary.DeepPurple600, Primary.DeepPurple600, Accent.LightBlue200, TextShade.WHITE);
            ChoiceProduct = choiceProduct;
        }

        private void materialTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            string Symbol = e.KeyChar.ToString();
            MaterialListView materialListView = ChoiceProduct.GetListView();
            if (!Regex.Match(Symbol, @"[0-9]").Success)
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (materialTextBox1.Text == "")
                {
                    MessageBox.Show("Введите значение!");
                }
                else
                {
                    if (materialListView.Items[0].Selected)
                    {
                        materialListView.Items[0].SubItems[2].Text = materialTextBox1.Text;
                        materialTextBox1.Text = "";
                        this.Close();
                    }
                    if(materialListView.Items[1].Selected)
                    {
                        materialListView.Items[1].SubItems[2].Text = materialTextBox1.Text;
                        materialTextBox1.Text = "";
                        this.Close();
                    }
                }
            }
        }
    }
}
