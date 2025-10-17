using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs.Labs.Lab1.Bai3Them
{
    public partial class Bai3Them : Form
    {
        public Bai3Them()
        {
            InitializeComponent();
        }

        private void Btn_Result_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(TB_InputNum.Text, out long num))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TB_InputNum.Text.Trim().Trim('0').Length > 12)
            {
                MessageBox.Show("Vui lòng nhập số nguyên tối đa 12 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] units = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] thousands = { "", "nghìn", "triệu", "tỷ" };
            string result = "";
            long temp = num;
            if (num < 0)
            {
                num = Math.Abs(num);
            }

            if (num == 0)
            {
                result = "không";
            }
            else
            {
                long thousandCounter = 0;
                while (num > 0)
                {
                    long chunk = num % 1000;
                    if (chunk != 0)
                    {
                        string chunkText = "";
                        long hundred = chunk / 100;
                        long tenUnit = chunk % 100;
                        long ten = tenUnit / 10;
                        long unit = tenUnit % 10;

                        if (hundred != 0)
                        {
                            chunkText += units[hundred] + " trăm ";
                        }
                        else if (num > 0)
                        {
                            chunkText += "";
                        }

                        if (ten == 0 && unit != 0 && hundred != 0)
                        {
                            chunkText += "linh ";
                        }

                        if (ten == 1)
                        {
                            chunkText += "mười ";
                        }
                        else if (ten > 1)
                        {
                            chunkText += units[ten] + " mươi ";
                        }

                        if (unit != 0)
                        {
                            if (ten > 1)
                            {
                                if (unit == 1)
                                    chunkText += "mốt ";
                                else if (unit == 5)
                                    chunkText += "lăm ";
                                else
                                    chunkText += units[unit] + " ";
                            }
                            else if (ten == 1)
                            {
                                if (unit == 5)
                                    chunkText += "lăm ";
                                else
                                    chunkText += units[unit] + " ";
                            }
                            else
                            {
                                chunkText += units[unit] + " ";
                            }
                        }

                        result = chunkText + thousands[thousandCounter] + " " + result;
                    }
                    num /= 1000;
                    thousandCounter++;
                }
            }
            if ( temp < 0 )
            {
                result = "âm " + result;
            }
            TB_OutputNum.Text = result.Trim();
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
