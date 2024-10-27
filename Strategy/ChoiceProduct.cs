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
    public partial class ChoiceProduct : MaterialForm
    {
        ShowInputDialog showInputDialog;
        Orange Orange;
        Apple Apple;
        Order Order;
        public ChoiceProduct()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple500, Primary.DeepPurple600, Primary.DeepPurple600, Accent.LightBlue200, TextShade.WHITE);
            Orange = new Orange();
            Apple = new Apple();
            Order = new Order();
            this.materialListView1.Items[0].SubItems.Add(Orange.price.ToString());
            this.materialListView1.Items[1].SubItems.Add(Apple.price.ToString());
            this.materialListView1.Items[0].SubItems.Add("");
            this.materialListView1.Items[1].SubItems.Add("");
            showInputDialog = new ShowInputDialog(this);
        }

        public MaterialListView GetListView()
        {
            return materialListView1;
        }
        private void materialListView1_DoubleClick(object sender, EventArgs e)
        {
            showInputDialog.ShowDialog();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (materialListView1.Items[0].SubItems[2].Text == "" && materialListView1.Items[1].SubItems[2].Text == "")
            {
                MessageBox.Show("Выберите товар!");
            }
            else
            {
                if(materialListView1.Items[0].SubItems[2].Text!="")
                {
                    Orange.value = int.Parse(materialListView1.Items[0].SubItems[2].Text);
                    Order.products.Add(Orange);
                }
                if (materialListView1.Items[1].SubItems[2].Text != "")
                {
                    Apple.value = int.Parse(materialListView1.Items[1].SubItems[2].Text);
                    Order.products.Add(Apple);
                }
                CalculateOrder();
                Form1 form = new Form1(Order);
                this.Hide();
                form.ShowDialog();
            }
        }

        private void ChoiceProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public void CalculateOrder()
        {
            for(int i = 0; i < Order.products.Count; i++)
            {
                Order.value += Order.products[i].value*Order.products[i].price;
            }
            
        }
    }
}
