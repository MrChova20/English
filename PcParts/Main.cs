using PcParts;
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
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Us childWindow = new About_Us();
            childWindow.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var add = new Add(this);
            add.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really wish to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int posListBox = inventoryList.SelectedIndex;
                inventoryList.Items.Remove(inventoryList.SelectedItem);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (inventoryList.SelectedIndex != -1)
            {
                var modify = new Modify(this);
                modify.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*double discount = converterDouble(discountText.Text);
            inventory1.applyDiscount(discount);
            listBox1.Items.Clear();
            for (int i = 0; i < inventory1.product_of_list.Count; i++)
            {
                addToListBox(inventory1.product_of_list[i]);
            }
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data_Viewer childWindow = new Data_Viewer();
            childWindow.ShowDialog(this);

        }

        public ListBox MyListBox { get { return inventoryList; } }
    }
}
