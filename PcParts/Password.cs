using MainApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcParts
{
    public partial class PasswordForm : Form
    {
        private int count = 3;
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {

            if (PasswordBox.Text != "") {

                string password = PasswordBox.Text;
                if (password == "1234")
                {
                    this.Hide();
                    Main childwindow = new Main();
                    childwindow.Show();

                } else
                {
                    
                    count = count - 1;
                    Attemps.Text.Remove(0);
                    Attemps.Text = count.ToString();
                    PasswordBox.Text.Remove(0);

                    if (count < 1) {
                        Application.Exit();
                    } 
                    
                }
            }
            else
            {
                MessageBox.Show("You have to enter a valid password", "Error");
            }
            
        }

        private void PasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
