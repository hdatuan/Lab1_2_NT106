namespace Labs.Labs.Lab1.Bai3
{
    partial class Bai3Form : Form
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
            Btn_Exit = new Button();
            Btn_Clear = new Button();
            TB_OutputNum = new TextBox();
            Lbl_OutputNum = new Label();
            Btn_Result = new Button();
            TB_InputNum = new TextBox();
            Lbl_InputNum = new Label();
            SuspendLayout();
            // 
            // Btn_Exit
            // 
            Btn_Exit.Location = new Point(596, 246);
            Btn_Exit.Name = "Btn_Exit";
            Btn_Exit.Size = new Size(94, 29);
            Btn_Exit.TabIndex = 32;
            Btn_Exit.Text = "Thoát";
            Btn_Exit.UseVisualStyleBackColor = true;
            Btn_Exit.Click += Btn_Exit_Click;
            // 
            // Btn_Clear
            // 
            Btn_Clear.Location = new Point(596, 167);
            Btn_Clear.Name = "Btn_Clear";
            Btn_Clear.Size = new Size(94, 29);
            Btn_Clear.TabIndex = 31;
            Btn_Clear.Text = "Xóa";
            Btn_Clear.UseVisualStyleBackColor = true;
            Btn_Clear.Click += Btn_Clear_Click;
            // 
            // TB_OutputNum
            // 
            TB_OutputNum.Location = new Point(407, 248);
            TB_OutputNum.Name = "TB_OutputNum";
            TB_OutputNum.ReadOnly = true;
            TB_OutputNum.Size = new Size(125, 27);
            TB_OutputNum.TabIndex = 26;
            // 
            // Lbl_OutputNum
            // 
            Lbl_OutputNum.AutoSize = true;
            Lbl_OutputNum.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_OutputNum.Location = new Point(261, 248);
            Lbl_OutputNum.Name = "Lbl_OutputNum";
            Lbl_OutputNum.Size = new Size(92, 31);
            Lbl_OutputNum.TabIndex = 25;
            Lbl_OutputNum.Text = "Kết quả";
            // 
            // Btn_Result
            // 
            Btn_Result.Location = new Point(596, 87);
            Btn_Result.Name = "Btn_Result";
            Btn_Result.Size = new Size(94, 29);
            Btn_Result.TabIndex = 22;
            Btn_Result.Text = "Kết quả";
            Btn_Result.UseVisualStyleBackColor = true;
            Btn_Result.Click += Btn_Result_Click;
            // 
            // TB_InputNum
            // 
            TB_InputNum.Location = new Point(407, 87);
            TB_InputNum.Name = "TB_InputNum";
            TB_InputNum.Size = new Size(125, 27);
            TB_InputNum.TabIndex = 21;
            // 
            // Lbl_InputNum
            // 
            Lbl_InputNum.AutoSize = true;
            Lbl_InputNum.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_InputNum.Location = new Point(21, 81);
            Lbl_InputNum.Name = "Lbl_InputNum";
            Lbl_InputNum.Size = new Size(332, 31);
            Lbl_InputNum.TabIndex = 20;
            Lbl_InputNum.Text = "Nhập vào số nguyên từ 0 đến 9";
            // 
            // Bai3Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(811, 394);
            Controls.Add(Btn_Exit);
            Controls.Add(Btn_Clear);
            Controls.Add(TB_OutputNum);
            Controls.Add(Lbl_OutputNum);
            Controls.Add(Btn_Result);
            Controls.Add(TB_InputNum);
            Controls.Add(Lbl_InputNum);
            Name = "Bai3Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Exit;
        private Button Btn_Clear;
        private TextBox TB_OutputNum;
        private Label Lbl_OutputNum;
        private Button Btn_Result;
        private TextBox TB_InputNum;
        private Label Lbl_InputNum;
    }
}