using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lost_found
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                //textBox1.Text = "";
                //textBox2.Text = "";
                //textBox3.Text = "";
                MessageBox.Show("Enter all Required Data", "Requested", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                if (textBox1.Text == "ahmed" && textBox2.Text == "123" && textBox3.Text == "456")
                {
                        Form7 s = new Form7();
                        s.Show();
                        this.Hide();
                }

                else
                {
                    //textBox1.Text = "";
                    //textBox2.Text = "";
                    //textBox3.Text = "";
                    MessageBox.Show("Make sure of your data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 s = new Form1();
            s.Show();
            this.Hide();
        }
    }
}
