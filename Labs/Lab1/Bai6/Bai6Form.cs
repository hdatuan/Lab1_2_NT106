using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs.Labs.Lab1.Bai6
{
    public partial class Bai6Form : Form
    {
        public Bai6Form()
        {
            InitializeComponent();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            TB_Year.Clear();
            Tb_CHD.Clear();
            Tb_Day.Clear();
            Tb_Month.Clear();
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

        private void Btn_Result_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TB_Year.Text, out int year))
            {
                MessageBox.Show("Thông tin không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (year < 1900 || year > DateTime.Now.Year)
            {
                MessageBox.Show("Thông tin không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!int.TryParse(Tb_Month.Text, out int month))
            {
                MessageBox.Show("Thông tin không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(Tb_Day.Text, out int day))
            {
                MessageBox.Show("Thông tin không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int[] dayInMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                dayInMonths[1] = 29;
            }

            if (month < 1 || month > 12)
            {
                MessageBox.Show("Thông tin không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (day < 1 || day > dayInMonths[month - 1] || !int.TryParse(Tb_Day.Text, out day))
            {
                MessageBox.Show("Thông tin không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (month)
            {
                case 1:
                    {
                        Tb_CHD.Text = (day <= 20) ? "Ma Kết" : "Bảo Bình"; break;
                    }
                case 2:
                    {
                        Tb_CHD.Text = (day <= 19) ? "Bảo Bình" : "Song Ngư"; break;
                    }
                case 3:
                    {
                        Tb_CHD.Text = (day <= 20) ? "Song Ngư" : "Bạch Dương"; break;
                    }
                case 4:
                    {
                        Tb_CHD.Text = (day <= 20) ? "Bạch Dương" : "Kim Ngưu"; break;
                    }
                case 5:
                    {
                        Tb_CHD.Text = (day <= 21) ? "Kim Ngưu" : "Song Tử"; break;
                    }
                case 6:
                    {
                        Tb_CHD.Text = (day <= 21) ? "Song Tử" : "Cự Giải"; break;
                    }
                case 7:
                    {
                        Tb_CHD.Text = (day <= 22) ? "Cự Giải" : "Sư Tử"; break;
                    }
                case 8:
                    {
                        Tb_CHD.Text = (day <= 22) ? "Sư Tử" : "Xử Nữ"; break;
                    }
                case 9:
                    {
                        Tb_CHD.Text = (day <= 23) ? "Xử Nữ" : "Thiên Bình"; break;
                    }
                case 10:
                    {
                        Tb_CHD.Text = (day <= 23) ? "Thiên Bình" : "Bọ Cạp"; break;
                    }
                case 11:
                    {
                        Tb_CHD.Text = (day <= 22) ? "Bọ Cạp" : "Nhân Mã"; break;
                    }
                case 12:
                    {
                        Tb_CHD.Text = (day <= 21) ? "Nhân Mã" : "Ma Kết"; break;
                    }
                default:
                    {
                        MessageBox.Show("Tháng sinh không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }


        }

        private void Bai6Form_Load(object sender, EventArgs e)
        {

        }
    }
}
