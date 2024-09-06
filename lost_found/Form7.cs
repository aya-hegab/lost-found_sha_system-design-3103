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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
                Form1 s = new Form1();
                s.Show();
                this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form6 s = new Form6();
            s.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "" || textBox6.Text == "" ||  comboBox1.Text == "")
            {
                //textBox1.Text = "";
                //textBox2.Text = "";
                //textBox3.Text = "";
                //textBox4.Text = "";
                //textBox5.Text = "";
                //textBox6.Text = "";
                //comboBox1.Text = "";
                MessageBox.Show("Enter all Required Data", "Requested", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                comboBox1.Text = "";
                MessageBox.Show("Added Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "" || textBox6.Text == "" || comboBox1.Text == "")
            {
                //textBox1.Text = "";
                //textBox2.Text = "";
                //textBox3.Text = "";
                //textBox4.Text = "";
                //textBox5.Text = "";
                //textBox6.Text = "";
                //comboBox1.Text = "";
                MessageBox.Show("Enter all Required Data", "Requested", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                comboBox1.Text = "";
                MessageBox.Show("Edited Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "" || textBox6.Text == "" || comboBox1.Text == "")
            {
                //textBox1.Text = "";
                //textBox2.Text = "";
                //textBox3.Text = "";
                //textBox4.Text = "";
                //textBox5.Text = "";
                //textBox6.Text = "";
                //comboBox1.Text = "";
                MessageBox.Show("Enter all Required Data", "Requested", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                //textBox1.Text = "";
                //textBox2.Text = "";
                //textBox3.Text = "";
                //textBox4.Text = "";
                //textBox5.Text = "";
                //textBox6.Text = "";
                //comboBox1.Text = "";
                MessageBox.Show("Deleted Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
