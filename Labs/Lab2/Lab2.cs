using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs.Labs.Lab2
{
    public partial class Lab2 : Form
    {
        public Lab2()
        {
            InitializeComponent();
        }

        private void Btn_Bai1_Click(object sender, EventArgs e)
        {
            Bai1Lab2 bai1 = new Bai1Lab2();
            this.Hide();
            bai1.FormClosed += (s, args) => this.Show();
            bai1.Show();
        }

        private void Btn_Bai2_Click(object sender, EventArgs e)
        {
            Bai2Lab2 bai2 = new Bai2Lab2();
            this.Hide();
            bai2.FormClosed += (s, args) => this.Show();
            bai2.Show();
        }

        private void Btn_Bai3_Click(object sender, EventArgs e)
        {
            Bai3Lab2 bai3 = new Bai3Lab2();
            this.Hide();
            bai3.FormClosed += (s, args) => this.Show();
            bai3.Show();
        }

        private void Btn_Bai4_Click(object sender, EventArgs e)
        {
            Bai4Lab2 bai4 = new Bai4Lab2();
            this.Hide();
            bai4.FormClosed += (s, args) => this.Show();
            bai4.Show();
        }

        private void Btn_Bai5_Click(object sender, EventArgs e)
        {
            Bai5Lab2 bai5 = new Bai5Lab2();
            this.Hide();
            bai5.FormClosed += (s, args) => this.Show();
            bai5.Show();
        }

        private void Btn_Bai6_Click(object sender, EventArgs e)
        {
            Bai6Lab2 bai6 = new Bai6Lab2();
            this.Hide();
            bai6.FormClosed += (s, args) => this.Show();
            bai6.Show();
        }

        private void Btn_Bai7_Click(object sender, EventArgs e)
        {
            Bai7Lab2 bai7 = new Bai7Lab2();
            this.Hide();
            bai7.FormClosed += (s, args) => this.Show();
            bai7.Show();
        }
    }
}
