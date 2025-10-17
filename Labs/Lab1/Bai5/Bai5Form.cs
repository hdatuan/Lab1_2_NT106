using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs.Labs.Lab1.Bai5
{
    public partial class Bai5Form : Form
    {
        public Bai5Form()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            TB_NumberA.Text = "";
            TB_NumberB.Text = "";
            Lbl_Result.Text = "";
            CB_Option.SelectedIndex = -1;
            CB_Option.Text = "";
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?",
                                          "Xác nhận thoát",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Btn_Cal_Click(object sender, EventArgs e)
        {
            int option = CB_Option.SelectedIndex;
            if (option == -1)
            {
                MessageBox.Show("Vui lòng chọn phép tính");
                return;
            }
            if ( int.TryParse(TB_NumberA.Text, out int a) == false)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho số A");
                return;
            }
            if (int.TryParse(TB_NumberB.Text, out int b) == false)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho số B");
                return;
            }
            string result = "";
            if ( option == 0 )
            {
                int num = b - a;
                for(int i = 1; i <= 10; i++)
                {
                    result += $"{num} x {i} = {num * i}\n";
                }
            }
            else
            {
                long res1 = 1;
                int start = 1;
                int num = a - b;
                while( start <= num)
                {
                    res1 *= start;
                    start++;
                }
                result = $"Giai thừa của {num} là: {res1}";
                if (a < b) result = "A phải lớn hơn b";
                long res2 = a;
                num = a;
                for(int i = 2; i <= b; i++)
                {
                    num *= a;
                    res2 += num;
                }
                result += $"\nTổng S = a + a^2 + a^3 + ... + a^b là: {res2}";
            }
            Lbl_Result.Text = result;
            result = "";

        }
    }
}
