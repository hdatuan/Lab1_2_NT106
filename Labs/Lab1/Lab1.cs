using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Labs.Labs.Lab1.Bai1;
using Labs.Labs.Lab1.Bai2;
using Labs.Labs.Lab1.Bai3;
using Labs.Labs.Lab1.Bai3Them;
using Labs.Labs.Lab1.Bai4;
using Labs.Labs.Lab1.Bai5;
using Labs.Labs.Lab1.Bai6;
using Labs.Labs.Lab1.Bai7;
using Labs.Labs.Lab1.Bai8;

namespace Labs.Labs.Lab1
{
    public partial class Lab1 : Form
    {
        public Lab1()
        {
            InitializeComponent();
        }

        private void Btn_Bai1_Click(object sender, EventArgs e)
        {
            Bai1Form bai1 = new Bai1Form();
            this.Hide();
            bai1.FormClosed += (s, args) => this.Show();
            bai1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai2Form bai2 = new Bai2Form();
            this.Hide();
            bai2.FormClosed += (s, args) => this.Show();
            bai2.Show();
        }

        private void Btn_Bai3_Click(object sender, EventArgs e)
        {
            Bai3Form bai3 = new Bai3Form();
            this.Hide();
            bai3.FormClosed += (s, args) => this.Show();
            bai3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bai8Form bai8 = new Bai8Form();
            this.Hide();
            bai8.FormClosed += (s, args) => this.Show();
            bai8.Show();
        }

        private void Btn_Bai4_Click(object sender, EventArgs e)
        {
            Bai4Form bai4 = new Bai4Form();
            this.Hide();
            bai4.FormClosed += (s, args) => this.Show();
            bai4.Show();
        }

        private void Btn_Bai5_Click(object sender, EventArgs e)
        {
            Bai5Form bai5 = new Bai5Form();
            this.Hide();
            bai5.FormClosed += (s, args) => this.Show();
            bai5.Show();
        }

        private void Btn_Bai6_Click(object sender, EventArgs e)
        {
            Bai6Form bai6 = new Bai6Form();
            this.Hide();
            bai6.FormClosed += (s, args) => this.Show();
            bai6.Show();
        }

        private void Btn_Bai7_Click(object sender, EventArgs e)
        {
            Bai7Form bai7 = new Bai7Form();
            this.Hide();
            bai7.FormClosed += (s, args) => this.Show();
            bai7.Show();
        }

        private void Btn_Bai3_1_Click(object sender, EventArgs e)
        {
            Bai3Them.Bai3Them bai3_1 = new Bai3Them.Bai3Them();
            this.Hide();
            bai3_1.FormClosed += (s, args) => this.Show();
            bai3_1.Show();

        }
    }
}
