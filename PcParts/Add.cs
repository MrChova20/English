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
    public partial class Add : Form
    {


        private Main form; 
        public Add(Main form1)
        {
            InitializeComponent();
            form = form1;
        }

        private int converterInt(string number)
        {
            int i = 0;
            if (!Int32.TryParse(number, out i))
            {
                i = -1;
            }
            return i;
        }


        private double converterDouble(string number)
        {
            double i = 0;
            if (!Double.TryParse(number, out i))
            {
                i = -1;
            }
            return i;
        }

        private void addToListBox(product prod)
        {
            String prod1 = prod.Name + " - ID:" + prod.Id.ToString() + " - " + prod.Description + " - Stock:" + prod.Quantity.ToString() + " -Price:" + prod.Price.ToString() + "€";
            form.MyListBox.Items.Add(prod1);
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
