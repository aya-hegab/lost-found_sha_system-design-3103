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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {//رجوع للشاشه الرئيسيه
            Form1 s = new Form1();
            s.Show();
            this.Visible = false;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            DataGridViewRow R1 = new DataGridViewRow();
            R1.CreateCells(dataGridView1);
            R1.Cells[0].Value = "1";
            R1.Cells[1].Value = "xxxxx";
            R1.Cells[2].Value = "Damanhour - Al Mahatta Square";
            R1.Cells[3].Value = "xxxxx";
            dataGridView1.Rows.Add(R1);

            DataGridViewRow R2 = new DataGridViewRow();
            R2.CreateCells(dataGridView1);
            R2.Cells[0].Value = "2";
            R2.Cells[1].Value = "xxxxx";
            R2.Cells[2].Value = "Kafr El Sheikh - El Nabawy El Mohandes St. - next to Al Khayyat Mosque";
            R2.Cells[3].Value = "xxxxx";
            dataGridView1.Rows.Add(R2);

            DataGridViewRow R3 = new DataGridViewRow();
            R3.CreateCells(dataGridView1);
            R3.Cells[0].Value = "3";
            R3.Cells[1].Value = "xxxxx";
            R3.Cells[2].Value = "Beni Suef - Safia Zaghloul St. - Ismailia Railway Station";
            R3.Cells[3].Value = "xxxxx";
            dataGridView1.Rows.Add(R3);

            DataGridViewRow R4 = new DataGridViewRow();
            R4.CreateCells(dataGridView1);
            R4.Cells[0].Value = "4";
            R4.Cells[1].Value = "xxxxx";
            R4.Cells[2].Value = "Assiut - in front of Badr Qalyubia Hotel";
            R4.Cells[3].Value = "xxxxx";
            dataGridView1.Rows.Add(R4);

            DataGridViewRow R5 = new DataGridViewRow();
            R5.CreateCells(dataGridView1);
            R5.Cells[0].Value = "5";
            R5.Cells[1].Value = "xxxxx";
            R5.Cells[2].Value = "Alexandria - Mahmoud Salama St. - Misr Station";
            R5.Cells[3].Value = "xxxxx";
            dataGridView1.Rows.Add(R5);
        }
    }
}
