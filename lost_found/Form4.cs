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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {//العوده للشاشه الرئيسيه
            Form1 s = new Form1();
            s.Show();
            this.Visible = false;
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DataGridViewRow R1 = new DataGridViewRow();
            R1.CreateCells(dataGridView1);
            R1.Cells[0].Value = "National ID Card";
            R1.Cells[1].Value = "10";
            dataGridView1.Rows.Add(R1);

            DataGridViewRow R2 = new DataGridViewRow();
            R2.CreateCells(dataGridView1);
            R2.Cells[0].Value = "Personal identification card";
            R2.Cells[1].Value = "5";
            dataGridView1.Rows.Add(R2);

            DataGridViewRow R3 = new DataGridViewRow();
            R3.CreateCells(dataGridView1);
            R3.Cells[0].Value = "Karni (clubs / various  activities)";
            R3.Cells[1].Value = "5";
            dataGridView1.Rows.Add(R3);

            DataGridViewRow R4 = new DataGridViewRow();
            R4.CreateCells(dataGridView1);
            R4.Cells[0].Value = "Cards (Visa / Credit Card)";
            R4.Cells[1].Value = "10";
            dataGridView1.Rows.Add(R4);

            DataGridViewRow R5 = new DataGridViewRow();
            R5.CreateCells(dataGridView1);
            R5.Cells[0].Value = "License (Driving / Weapon / Others)";
            R5.Cells[1].Value = "10";
            dataGridView1.Rows.Add(R5);

            DataGridViewRow R6 = new DataGridViewRow();
            R6.CreateCells(dataGridView1);
            R6.Cells[0].Value = "Egyptian passport";
            R6.Cells[1].Value = "10";
            dataGridView1.Rows.Add(R6);

            DataGridViewRow R7 = new DataGridViewRow();
            R7.CreateCells(dataGridView1);
            R7.Cells[0].Value = "Foreign passport";
            R7.Cells[1].Value = "10";
            dataGridView1.Rows.Add(R7);

            DataGridViewRow R8 = new DataGridViewRow();
            R8.CreateCells(dataGridView1);
            R8.Cells[0].Value = "Personal investigation (military / police / national security)";
            R8.Cells[1].Value = "15";
            dataGridView1.Rows.Add(R8);
        }
    }
}
