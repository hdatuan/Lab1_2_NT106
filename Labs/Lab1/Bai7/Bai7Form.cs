using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs.Labs.Lab1.Bai7
{
    public partial class Bai7Form : Form
    {
        public Bai7Form()
        {
            InitializeComponent();
        }

        private void Tb_Input_TextChanged(object sender, EventArgs e)
        {


        }

        private void Btn_Result_Click(object sender, EventArgs e)
        {
            Lb_Result.Text = "";
            string input = Tb_Input.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Dữ liệu trống", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            string[] parts = input.Split(',');
            if (parts.Length < 10)
            {
                MessageBox.Show("Vui lòng nhập đủ 9 môn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if ( parts.Length > 10)
            {
                MessageBox.Show("Nhập thừa dữ liệu, vui lòng nhập 9 môn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


                string hoTen = parts[0].Trim();

            if (string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show("Họ tên không hợp lệ!");
                return;
            }

            if (!Regex.IsMatch(hoTen, @"^[\p{L}\s]+$"))
            {
                MessageBox.Show("Họ tên chỉ được chứa chữ cái và khoảng trắng (không có số hoặc ký tự đặc biệt)!", "Lỗi", MessageBoxButtons.OK);
                return;
            }

            string result = $"Họ tên: {hoTen}\n";
            double diemtb = 0;

            for (int i = 1; i < parts.Length; i++)
            {
                string diemStr = parts[i].Trim();

                if (!double.TryParse(diemStr, NumberStyles.Any, CultureInfo.InvariantCulture, out double diem))
                {
                    MessageBox.Show($"Điểm môn thứ {i} không hợp lệ : \"{diemStr}\"");
                    return;
                }

                if (diem < 0 || diem > 10)
                {
                    MessageBox.Show($"Điểm {diem} không nằm trong khoảng 0 - 10");
                    return;
                }

                result += $"Điểm môn {i}: {diem}";
                diemtb += diem;
                if (i % 3 == 0)
                {
                    result += "\n";
                }
                else
                {
                    result += "     ";
                }


            }
            diemtb /= (parts.Length - 1);
            result += $"\nĐiểm trung bình: {diemtb:F2}";
            Lb_Result.Text = result;
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Tb_Input.Clear();
            Lb_Result.Text = "";
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
