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
    public partial class Bai1Lab2 : Form
    {
        public Bai1Lab2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void Btn_ReadFile_Click(object sender, EventArgs e)
        {
            Rtb_File.Text = "";

            string filePath = @"../../../Labs/Lab2/" + Tb_InputName.Text.Trim();

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Rtb_File.AppendText(line + Environment.NewLine);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return;
            }

        }

        private void Btn_WriteFile_Click(object sender, EventArgs e)
        {
            string filePath = @"../../../Labs/Lab2/" + Tb_OutputName.Text.Trim();

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteAsync(Rtb_File.Text.Trim().ToUpper());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return;
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Rtb_File.Text = "";
            Tb_InputName.Text = "";
            Tb_OutputName.Text = "";
            Tb_InputName.Focus();
        }
    }
}
