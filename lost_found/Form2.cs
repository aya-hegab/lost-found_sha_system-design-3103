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
    public partial class Form2 : Form
    {
        private bool cardRequired;
        public Form2()
        {
            cardRequired = false;
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 s = new Form1();
            s.Show();
            this.Hide();

        }


       

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "Damanhur")
            {
                label6.Visible = true;
            }
            else if (textBox1.Text == "Kafr El Sheikh")
            {
                label7.Visible = true;
                label9.Visible = true;
                label6.Visible = false;
            }
            else
            {
                label7.Visible = false;
                label9.Visible = false;
                label6.Visible = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (cardRequired == true)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" || textBox4.Text == "")
                {
                    //textBox1.Text = "";
                    //textBox2.Text = "";
                    //textBox3.Text = "";
                    //comboBox1.Text = "";
                    //label6.Visible = false;
                    MessageBox.Show("Enter all Required Data", "Requested", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }

                else
                {
                    if (textBox2.Text == "Yasser Jalal" && textBox1.Text == "Kafr El Sheikh")
                    {
                        DialogResult resualt2 = MessageBox.Show("This Lost Item was handed over to the Ministry of Defense on August 25, 2019, with the number 55698", "Unfound", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        if (resualt2 == DialogResult.OK)
                        {
                            radioButton1.Checked = true;
                            radioButton2.Checked = false;
                            label8.Visible = false;
                            textBox4.Visible = false;
                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";
                            comboBox1.Text = "";
                            label6.Visible = false;
                        }
                    }
                    else if (textBox1.Text == "Damanhur" && textBox2.Text == "Adel Jamal" && comboBox1.Text == "Egyptian passport")
                    {
                        DialogResult resualt = MessageBox.Show("we found 3 related items", "Resault", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (resualt == DialogResult.OK)
                        {
                            Form3 s = new Form3();
                            s.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        radioButton1.Checked = true;
                        radioButton2.Checked = false;
                        textBox4.Text = "";
                        label8.Visible = false;
                        textBox4.Visible = false;
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        comboBox1.Text = "";
                        label6.Visible = false;
                        MessageBox.Show("we didn't find any", "Resault", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }


            else if (cardRequired == false)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "")
                {
                    //textBox1.Text = "";
                    //textBox2.Text = "";
                    //textBox3.Text = "";
                    //comboBox1.Text = "";
                    //label6.Visible = false;
                    MessageBox.Show("Enter all Required Data", "Requested", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }

                else
                {
                    if (textBox2.Text == "Yasser Jalal" && textBox1.Text == "Kafr El Sheikh")
                    {
                        DialogResult resualt2 = MessageBox.Show("This Lost Item was handed over to the Ministry of Defense on August 25, 2019, with the number 55698", "Unfound", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        if (resualt2 == DialogResult.OK)
                        {
                            radioButton1.Checked = true;
                            radioButton2.Checked = false;
                            label8.Visible = false;
                            textBox4.Visible = false;
                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";
                            comboBox1.Text = "";
                            label6.Visible = false;
                        }
                    }
                    else if (textBox1.Text == "Damanhur" && textBox2.Text == "Adel Jamal" && comboBox1.Text == "Egyptian passport")
                    {
                        DialogResult resualt = MessageBox.Show("we found 3 related items", "Resault", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (resualt == DialogResult.OK)
                        {
                            Form3 s = new Form3();
                            s.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        radioButton1.Checked = true;
                        radioButton2.Checked = false;
                        label8.Visible = false;
                        textBox4.Visible = false;
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        comboBox1.Text = "";
                        label6.Visible = false;
                        MessageBox.Show("we didn't find any", "Resault", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            label8.Visible = true;
            textBox4.Visible = true;
            cardRequired = true;
                
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Visible = false;
            textBox4.Visible = false;
            cardRequired = false;
            textBox4.Text = "";
        }
    }
}
