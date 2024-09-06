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
    public partial class Form3 : Form
    {
        private bool addressRequired = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //if (addressRequired)
            //{
            //    if (textBox1.Text == "")
            //    {
            //        //textBox1.Text = "";
            //        //MessageBox.Show("ادخل العنوان من فضلك", "وجوب", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //        MessageBox.Show("Enter Your Address", "Requested", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //    }
            //    else
            //    {
                    //this.Dispose();
            //        Form1 s = new Form1();
            //        s.Show();
            //        this.Hide();
            //    }
            //}
            //else
            //{
                //this.Dispose();
                Form1 s = new Form1();
                s.Show();
                this.Hide();
            //}

            
            
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //if (addressRequired)
            //{
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Enter Your Address", "Requested", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("It will be 35 E.L.", "Total Fees", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            //}
            //else
            //{
            //    MessageBox.Show("It will be 10 E.L.", "Total Fees", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //}

            
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DataGridViewRow R1 = new DataGridViewRow();
            R1.CreateCells(dataGridView1);
            R1.Cells[0].Value = "Egyptian passport";
            R1.Cells[1].Value = "Adel Jamaluddin Syed";
            R1.Cells[2].Value = "Damanhur";
            R1.Cells[3].Value = "10";
            dataGridView1.Rows.Add(R1);

            DataGridViewRow R2 = new DataGridViewRow();
            R2.CreateCells(dataGridView1);
            R2.Cells[0].Value = "Egyptian passport";
            R2.Cells[1].Value = "Adel Jamal Fawzy";
            R2.Cells[2].Value = "Damanhur";
            R2.Cells[3].Value = "10";
            dataGridView1.Rows.Add(R2);

            DataGridViewRow R3 = new DataGridViewRow();
            R3.CreateCells(dataGridView1);
            R3.Cells[0].Value = "Egyptian passport";
            R3.Cells[1].Value = "Adel Gamal Shehata";
            R3.Cells[2].Value = "Damanhur";
            R3.Cells[3].Value = "10";
            dataGridView1.Rows.Add(R3);
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
            this.Hide();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label2.Visible = true;
                textBox1.Visible = true;
                button1.Visible = true;
                label1.Visible = true;
                addressRequired = true;
            }
            else if (checkBox1.Checked == false)
            {
                label2.Visible = false;
                textBox1.Visible = false;
                button1.Visible = false;
                label1.Visible = false;
                addressRequired = false;
                textBox1.Text = string.Empty;
            }


        }
    }
}
