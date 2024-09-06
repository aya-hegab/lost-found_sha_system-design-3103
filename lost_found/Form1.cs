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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {//بيفتح الاسكرين بتاعت ادخال معايير البحث
            Form2 s = new Form2();
            s.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {//بيفتح جدول رسوم استلام المفقودات
            Form4 s = new Form4();
            s.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {//بيفتح جدول اماكن استلام المفقودات
            Form5 s = new Form5();
            s.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form6 s = new Form6();
            s.Show();
            this.Hide();
        }
    }
}
