using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs.Labs.Lab1.Bai1
{
    public partial class Bai1Form : Form
    {
        public Bai1Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long num1, num2;
            if (long.TryParse(Tb_Number1.Text.Trim(), out num1) == false)
            {
                if (long.TryParse(Tb_Number2.Text.Trim(), out num2) == false)
                {
                    MessageBox.Show("Hai số không phải số nguyên hợp lệ, vui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Số thứ nhất không phải số nguyên hợp lệ, vui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            if (long.TryParse(Tb_Number2.Text.Trim(), out num2) == false)
            {
                MessageBox.Show("Số thứ hai không phải số nguyên hợp lệ, vui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //num1 = long.Parse(TextBoxNumber1.Text.Trim());
            //num2 = long.Parse(TextBoxNumber2.Text.Trim());
            Tb_Sum.Text = (num1 + num2).ToString();
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
    }
}
