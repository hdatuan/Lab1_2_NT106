namespace Labs.Labs.Lab1.Bai2
{
    partial class Bai2Form : Form
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
            TB_MaxNum = new TextBox();
            Lbl_MaxNum = new Label();
            TB_Number2 = new TextBox();
            Lbl_Number2 = new Label();
            Btn_Result = new Button();
            TB_Number1 = new TextBox();
            Lbl_Number1 = new Label();
            TB_Number3 = new TextBox();
            Lbl_Number3 = new Label();
            TB_MinNum = new TextBox();
            Lbl_MinNum = new Label();
            Btn_Clear = new Button();
            Btn_Exit = new Button();
            SuspendLayout();
            // 
            // TB_MaxNum
            // 
            TB_MaxNum.Location = new Point(257, 359);
            TB_MaxNum.Name = "TB_MaxNum";
            TB_MaxNum.ReadOnly = true;
            TB_MaxNum.Size = new Size(125, 27);
            TB_MaxNum.TabIndex = 13;
            // 
            // Lbl_MaxNum
            // 
            Lbl_MaxNum.AutoSize = true;
            Lbl_MaxNum.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_MaxNum.Location = new Point(257, 308);
            Lbl_MaxNum.Name = "Lbl_MaxNum";
            Lbl_MaxNum.Size = new Size(130, 31);
            Lbl_MaxNum.TabIndex = 12;
            Lbl_MaxNum.Text = "Số lớn nhất";
            // 
            // TB_Number2
            // 
            TB_Number2.Location = new Point(266, 149);
            TB_Number2.Name = "TB_Number2";
            TB_Number2.Size = new Size(125, 27);
            TB_Number2.TabIndex = 11;
            // 
            // Lbl_Number2
            // 
            Lbl_Number2.AutoSize = true;
            Lbl_Number2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Number2.Location = new Point(83, 149);
            Lbl_Number2.Name = "Lbl_Number2";
            Lbl_Number2.Size = new Size(117, 31);
            Lbl_Number2.TabIndex = 10;
            Lbl_Number2.Text = "Số thứ hai";
            // 
            // Btn_Result
            // 
            Btn_Result.Location = new Point(535, 63);
            Btn_Result.Name = "Btn_Result";
            Btn_Result.Size = new Size(94, 29);
            Btn_Result.TabIndex = 9;
            Btn_Result.Text = "Kết quả";
            Btn_Result.UseVisualStyleBackColor = true;
            Btn_Result.Click += Btn_Result_Click;
            // 
            // TB_Number1
            // 
            TB_Number1.Location = new Point(266, 65);
            TB_Number1.Name = "TB_Number1";
            TB_Number1.Size = new Size(125, 27);
            TB_Number1.TabIndex = 8;
            // 
            // Lbl_Number1
            // 
            Lbl_Number1.AutoSize = true;
            Lbl_Number1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Number1.Location = new Point(83, 63);
            Lbl_Number1.Name = "Lbl_Number1";
            Lbl_Number1.Size = new Size(132, 31);
            Lbl_Number1.TabIndex = 7;
            Lbl_Number1.Text = "Số thứ nhất";
            // 
            // TB_Number3
            // 
            TB_Number3.Location = new Point(266, 228);
            TB_Number3.Name = "TB_Number3";
            TB_Number3.Size = new Size(125, 27);
            TB_Number3.TabIndex = 15;
            // 
            // Lbl_Number3
            // 
            Lbl_Number3.AutoSize = true;
            Lbl_Number3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Number3.Location = new Point(83, 228);
            Lbl_Number3.Name = "Lbl_Number3";
            Lbl_Number3.Size = new Size(112, 31);
            Lbl_Number3.TabIndex = 14;
            Lbl_Number3.Text = "Số thứ ba";
            // 
            // TB_MinNum
            // 
            TB_MinNum.Location = new Point(467, 359);
            TB_MinNum.Name = "TB_MinNum";
            TB_MinNum.ReadOnly = true;
            TB_MinNum.Size = new Size(125, 27);
            TB_MinNum.TabIndex = 17;
            // 
            // Lbl_MinNum
            // 
            Lbl_MinNum.AutoSize = true;
            Lbl_MinNum.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_MinNum.Location = new Point(467, 308);
            Lbl_MinNum.Name = "Lbl_MinNum";
            Lbl_MinNum.Size = new Size(136, 31);
            Lbl_MinNum.TabIndex = 16;
            Lbl_MinNum.Text = "Số nhỏ nhất";
            // 
            // Btn_Clear
            // 
            Btn_Clear.Location = new Point(535, 142);
            Btn_Clear.Name = "Btn_Clear";
            Btn_Clear.Size = new Size(94, 29);
            Btn_Clear.TabIndex = 18;
            Btn_Clear.Text = "Xóa";
            Btn_Clear.UseVisualStyleBackColor = true;
            Btn_Clear.Click += Btn_Clear_Click;
            // 
            // Btn_Exit
            // 
            Btn_Exit.Location = new Point(535, 221);
            Btn_Exit.Name = "Btn_Exit";
            Btn_Exit.Size = new Size(94, 29);
            Btn_Exit.TabIndex = 19;
            Btn_Exit.Text = "Thoát";
            Btn_Exit.UseVisualStyleBackColor = true;
            Btn_Exit.Click += Btn_Exit_Click;
            // 
            // Bai2Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(837, 477);
            Controls.Add(Btn_Exit);
            Controls.Add(Btn_Clear);
            Controls.Add(TB_MinNum);
            Controls.Add(Lbl_MinNum);
            Controls.Add(TB_Number3);
            Controls.Add(Lbl_Number3);
            Controls.Add(TB_MaxNum);
            Controls.Add(Lbl_MaxNum);
            Controls.Add(TB_Number2);
            Controls.Add(Lbl_Number2);
            Controls.Add(Btn_Result);
            Controls.Add(TB_Number1);
            Controls.Add(Lbl_Number1);
            Name = "Bai2Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_MaxNum;
        private Label Lbl_MaxNum;
        private TextBox TB_Number2;
        private Label Lbl_Number2;
        private Button Btn_Result;
        private TextBox TB_Number1;
        private Label Lbl_Number1;
        private TextBox TB_Number3;
        private Label Lbl_Number3;
        private TextBox TB_MinNum;
        private Label Lbl_MinNum;
        private Button Btn_Clear;
        private Button Btn_Exit;
    }
}