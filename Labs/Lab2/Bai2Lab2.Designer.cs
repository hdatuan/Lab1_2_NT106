namespace Labs.Labs.Lab2
{
    partial class Bai2Lab2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Rtb_Body = new RichTextBox();
            Tb_FileName = new TextBox();
            Btn_ReadFile = new Button();
            Lb_FileName = new Label();
            Lb_URL = new Label();
            Tb_URL = new TextBox();
            Lb_Size = new Label();
            Tb_Size = new TextBox();
            Lb_LineCount = new Label();
            Tb_LineCount = new TextBox();
            Lb_WordCount = new Label();
            Tb_WordCount = new TextBox();
            Lb_CharCount = new Label();
            Tb_CharCount = new TextBox();
            Btn_Exit = new Button();
            SuspendLayout();
            // 
            // Rtb_Body
            // 
            Rtb_Body.ForeColor = Color.DimGray;
            Rtb_Body.Location = new Point(483, 26);
            Rtb_Body.Name = "Rtb_Body";
            Rtb_Body.ReadOnly = true;
            Rtb_Body.Size = new Size(490, 504);
            Rtb_Body.TabIndex = 0;
            Rtb_Body.Text = "";
            // 
            // Tb_FileName
            // 
            Tb_FileName.Location = new Point(162, 92);
            Tb_FileName.Name = "Tb_FileName";
            Tb_FileName.Size = new Size(276, 27);
            Tb_FileName.TabIndex = 1;
            // 
            // Btn_ReadFile
            // 
            Btn_ReadFile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_ReadFile.ForeColor = Color.DimGray;
            Btn_ReadFile.Location = new Point(48, 26);
            Btn_ReadFile.Name = "Btn_ReadFile";
            Btn_ReadFile.Size = new Size(390, 37);
            Btn_ReadFile.TabIndex = 2;
            Btn_ReadFile.Text = "Đọc File";
            Btn_ReadFile.UseVisualStyleBackColor = true;
            Btn_ReadFile.Click += Btn_ReadFile_Click;
            // 
            // Lb_FileName
            // 
            Lb_FileName.AutoSize = true;
            Lb_FileName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_FileName.ForeColor = Color.DimGray;
            Lb_FileName.Location = new Point(48, 91);
            Lb_FileName.Name = "Lb_FileName";
            Lb_FileName.Size = new Size(74, 25);
            Lb_FileName.TabIndex = 3;
            Lb_FileName.Text = "Tên file";
            // 
            // Lb_URL
            // 
            Lb_URL.AutoSize = true;
            Lb_URL.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_URL.ForeColor = Color.DimGray;
            Lb_URL.Location = new Point(48, 154);
            Lb_URL.Name = "Lb_URL";
            Lb_URL.Size = new Size(46, 25);
            Lb_URL.TabIndex = 5;
            Lb_URL.Text = "URL";
            // 
            // Tb_URL
            // 
            Tb_URL.Location = new Point(162, 155);
            Tb_URL.Name = "Tb_URL";
            Tb_URL.ReadOnly = true;
            Tb_URL.Size = new Size(276, 27);
            Tb_URL.TabIndex = 4;
            // 
            // Lb_Size
            // 
            Lb_Size.AutoSize = true;
            Lb_Size.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Size.ForeColor = Color.DimGray;
            Lb_Size.Location = new Point(48, 218);
            Lb_Size.Name = "Lb_Size";
            Lb_Size.Size = new Size(74, 25);
            Lb_Size.TabIndex = 7;
            Lb_Size.Text = "Kích cỡ";
            // 
            // Tb_Size
            // 
            Tb_Size.Location = new Point(162, 219);
            Tb_Size.Name = "Tb_Size";
            Tb_Size.ReadOnly = true;
            Tb_Size.Size = new Size(276, 27);
            Tb_Size.TabIndex = 6;
            // 
            // Lb_LineCount
            // 
            Lb_LineCount.AutoSize = true;
            Lb_LineCount.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_LineCount.ForeColor = Color.DimGray;
            Lb_LineCount.Location = new Point(48, 284);
            Lb_LineCount.Name = "Lb_LineCount";
            Lb_LineCount.Size = new Size(82, 25);
            Lb_LineCount.TabIndex = 9;
            Lb_LineCount.Text = "Số dòng";
            // 
            // Tb_LineCount
            // 
            Tb_LineCount.Location = new Point(162, 285);
            Tb_LineCount.Name = "Tb_LineCount";
            Tb_LineCount.ReadOnly = true;
            Tb_LineCount.Size = new Size(276, 27);
            Tb_LineCount.TabIndex = 8;
            // 
            // Lb_WordCount
            // 
            Lb_WordCount.AutoSize = true;
            Lb_WordCount.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_WordCount.ForeColor = Color.DimGray;
            Lb_WordCount.Location = new Point(48, 357);
            Lb_WordCount.Name = "Lb_WordCount";
            Lb_WordCount.Size = new Size(57, 25);
            Lb_WordCount.TabIndex = 11;
            Lb_WordCount.Text = "Số từ";
            // 
            // Tb_WordCount
            // 
            Tb_WordCount.Location = new Point(162, 358);
            Tb_WordCount.Name = "Tb_WordCount";
            Tb_WordCount.ReadOnly = true;
            Tb_WordCount.Size = new Size(276, 27);
            Tb_WordCount.TabIndex = 10;
            // 
            // Lb_CharCount
            // 
            Lb_CharCount.AutoSize = true;
            Lb_CharCount.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_CharCount.ForeColor = Color.DimGray;
            Lb_CharCount.Location = new Point(48, 425);
            Lb_CharCount.Name = "Lb_CharCount";
            Lb_CharCount.Size = new Size(82, 25);
            Lb_CharCount.TabIndex = 13;
            Lb_CharCount.Text = "Số ký tự";
            // 
            // Tb_CharCount
            // 
            Tb_CharCount.Location = new Point(162, 426);
            Tb_CharCount.Name = "Tb_CharCount";
            Tb_CharCount.ReadOnly = true;
            Tb_CharCount.Size = new Size(276, 27);
            Tb_CharCount.TabIndex = 12;
            // 
            // Btn_Exit
            // 
            Btn_Exit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Exit.ForeColor = Color.DimGray;
            Btn_Exit.Location = new Point(48, 493);
            Btn_Exit.Name = "Btn_Exit";
            Btn_Exit.Size = new Size(390, 37);
            Btn_Exit.TabIndex = 14;
            Btn_Exit.Text = "Thoát";
            Btn_Exit.UseVisualStyleBackColor = true;
            Btn_Exit.Click += Btn_Exit_Click;
            // 
            // Bai2Lab2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1012, 568);
            Controls.Add(Btn_Exit);
            Controls.Add(Lb_CharCount);
            Controls.Add(Tb_CharCount);
            Controls.Add(Lb_WordCount);
            Controls.Add(Tb_WordCount);
            Controls.Add(Lb_LineCount);
            Controls.Add(Tb_LineCount);
            Controls.Add(Lb_Size);
            Controls.Add(Tb_Size);
            Controls.Add(Lb_URL);
            Controls.Add(Tb_URL);
            Controls.Add(Lb_FileName);
            Controls.Add(Btn_ReadFile);
            Controls.Add(Tb_FileName);
            Controls.Add(Rtb_Body);
            Name = "Bai2Lab2";
            Text = "Bai2Lab2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox Rtb_Body;
        private TextBox Tb_FileName;
        private Button Btn_ReadFile;
        private Label Lb_FileName;
        private Label Lb_URL;
        private TextBox Tb_URL;
        private Label Lb_Size;
        private TextBox Tb_Size;
        private Label Lb_LineCount;
        private TextBox Tb_LineCount;
        private Label Lb_WordCount;
        private TextBox Tb_WordCount;
        private Label Lb_CharCount;
        private TextBox Tb_CharCount;
        private Button Btn_Exit;
    }
}