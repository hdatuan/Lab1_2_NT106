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
    
    public partial class Bai2Lab2 : Form
    {
        public Bai2Lab2()
        {
            InitializeComponent();
            Tb_FileName.Focus();
        }

        private void Btn_ReadFile_Click(object sender, EventArgs e)
        {
            string filePath = "../../../Labs/Lab2/" + Tb_FileName.Text.Trim();

            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Vui lòng nhập tên file.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Tb_FileName.Focus();
                return;
            }

            if ( !File.Exists(filePath) )
            {
                MessageBox.Show("File không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                FileInfo fileInfo = new FileInfo(filePath);
                string url = fileInfo.FullName;
                long size = fileInfo.Length;
                string content = File.ReadAllText(filePath);

                int lineCount = content.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
                int wordCount = content.Split(new[] { ' ', '\n', 'r' }, StringSplitOptions.RemoveEmptyEntries).Length;
                int charCount = content.Length;

                Tb_URL.Text = url;
                Tb_Size.Text = size.ToString() + " bytes";
                Tb_LineCount.Text = lineCount.ToString();
                Tb_WordCount.Text = wordCount.ToString();
                Tb_CharCount.Text = charCount.ToString();
                Rtb_Body.Text = content;

            } catch ( Exception ex)
            {
                MessageBox.Show("Error : " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
