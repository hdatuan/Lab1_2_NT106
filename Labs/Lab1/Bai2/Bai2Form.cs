using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs.Labs.Lab1.Bai2
{
    public partial class Bai2Form : Form
    {
        public Bai2Form()
        {
            InitializeComponent();
        }

        private void Btn_Result_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;

            // Assign values of try parse to bool variables
            bool isNum1Valid = double.TryParse(TB_Number1.Text.Trim(), out num1);
            bool isNum2Valid = double.TryParse(TB_Number2.Text.Trim(), out num2);
            bool isNum3Valid = double.TryParse(TB_Number3.Text.Trim(), out num3);


            // Check if all three numbers are invalid
            if (!isNum1Valid && !isNum2Valid && !isNum3Valid)
            {
                MessageBox.Show("Cả ba số không phải số hợp lệ, vui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create error mesage
            string ErrorMessage = "";
            if (!isNum1Valid) ErrorMessage += "Số thứ nhất";
            if (!isNum2Valid)
            {
                if (!isNum1Valid) ErrorMessage += ", số thứ hai";
                else ErrorMessage += "Số thứ hai";
            }
            if (!isNum3Valid)
            {
                if (!isNum1Valid || !isNum2Valid) ErrorMessage += ", số thứ ba";
                else ErrorMessage += "Số thứ ba";
            }

            // If error message is not blank -> throw error
            if (ErrorMessage != "")
            {
                MessageBox.Show(ErrorMessage + " không phải số hợp lệ, vui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate max and min number
            TB_MaxNum.Text = Math.Max(num1, Math.Max(num2, num3)).ToString();
            TB_MinNum.Text = Math.Min(num1, Math.Min(num2, num3)).ToString();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            TB_Number1.Clear();
            TB_Number2.Clear();
            TB_Number3.Clear();
            TB_MaxNum.Clear();
            TB_MinNum.Clear();
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
