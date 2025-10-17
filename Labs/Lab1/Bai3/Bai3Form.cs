using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs.Labs.Lab1.Bai3
{
    public partial class Bai3Form : Form
    {
        public Bai3Form()
        {
            InitializeComponent();
        }

        private void Btn_Result_Click(object sender, EventArgs e)
        {
            Boolean isInputValid = int.TryParse(TB_InputNum.Text, out int inputNum);
            if (!isInputValid)
            {
                MessageBox.Show("Số nguyên không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (inputNum < 0 || inputNum > 9)
            {
                MessageBox.Show("Vui lòng nhập số nguyên từ 0 đến 9", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TB_InputNum.Clear();
                return;
            }
            string[] numInWords = { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
            TB_OutputNum.Text = numInWords[inputNum];
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            TB_InputNum.Clear();
            TB_OutputNum.Clear();
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
