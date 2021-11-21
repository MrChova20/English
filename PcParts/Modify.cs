using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainApp
{
    public partial class Modify : Form
    {

        private Main form;
        public Modify(Main form1)
        {
            InitializeComponent();
            form = form1;
            int pos = form.inventoryList.SelectedIndex;
            /*textBoxName.Text = form.inventory1.Product_list[pos].Name;
            textBoxID.Text = form.inventory1.Product_list[pos].Id.ToString();
            textBoxDescription.Text = form.inventory1.Product_list[pos].Description;
            textBoxQuantity.Text = form.inventory1.Product_list[pos].Quantity.ToString();
            textBoxPrice.Text = form.inventory1.Product_list[pos].Price.ToString();
            */
        }

        private void Modify_Load(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
