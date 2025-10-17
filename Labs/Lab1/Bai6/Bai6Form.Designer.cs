namespace Labs.Labs.Lab1.Bai6
{
    partial class Bai6Form
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
            Tb_Day = new TextBox();
            Tb_Month = new TextBox();
            TB_Year = new TextBox();
            Lb_Day = new Label();
            Lb_Month = new Label();
            Lb_Year = new Label();
            Lb_CHD = new Label();
            Tb_CHD = new TextBox();
            Btn_Result = new Button();
            Btn_Clear = new Button();
            Btn_Exit = new Button();
            SuspendLayout();
            // 
            // Tb_Day
            // 
            Tb_Day.Location = new Point(245, 67);
            Tb_Day.Name = "Tb_Day";
            Tb_Day.Size = new Size(125, 27);
            Tb_Day.TabIndex = 0;
            // 
            // Tb_Month
            // 
            Tb_Month.Location = new Point(245, 134);
            Tb_Month.Name = "Tb_Month";
            Tb_Month.Size = new Size(125, 27);
            Tb_Month.TabIndex = 1;
            // 
            // TB_Year
            // 
            TB_Year.Location = new Point(245, 202);
            TB_Year.Name = "TB_Year";
            TB_Year.Size = new Size(125, 27);
            TB_Year.TabIndex = 2;
            // 
            // Lb_Day
            // 
            Lb_Day.AutoSize = true;
            Lb_Day.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Day.Location = new Point(91, 66);
            Lb_Day.Name = "Lb_Day";
            Lb_Day.Size = new Size(105, 25);
            Lb_Day.TabIndex = 3;
            Lb_Day.Text = "Nhập ngày";
            // 
            // Lb_Month
            // 
            Lb_Month.AutoSize = true;
            Lb_Month.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Month.Location = new Point(91, 132);
            Lb_Month.Name = "Lb_Month";
            Lb_Month.Size = new Size(113, 25);
            Lb_Month.TabIndex = 4;
            Lb_Month.Text = "Nhập tháng";
            // 
            // Lb_Year
            // 
            Lb_Year.AutoSize = true;
            Lb_Year.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Year.Location = new Point(91, 203);
            Lb_Year.Name = "Lb_Year";
            Lb_Year.Size = new Size(100, 25);
            Lb_Year.TabIndex = 5;
            Lb_Year.Text = "Nhập năm";
            // 
            // Lb_CHD
            // 
            Lb_CHD.AutoSize = true;
            Lb_CHD.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_CHD.Location = new Point(213, 319);
            Lb_CHD.Name = "Lb_CHD";
            Lb_CHD.Size = new Size(157, 25);
            Lb_CHD.TabIndex = 6;
            Lb_CHD.Text = "Cung hoàng đạo ";
            // 
            // Tb_CHD
            // 
            Tb_CHD.AllowDrop = true;
            Tb_CHD.Location = new Point(399, 319);
            Tb_CHD.Name = "Tb_CHD";
            Tb_CHD.ReadOnly = true;
            Tb_CHD.Size = new Size(125, 27);
            Tb_CHD.TabIndex = 7;
            // 
            // Btn_Result
            // 
            Btn_Result.Location = new Point(528, 67);
            Btn_Result.Name = "Btn_Result";
            Btn_Result.Size = new Size(94, 29);
            Btn_Result.TabIndex = 8;
            Btn_Result.Text = "Kết quả";
            Btn_Result.UseVisualStyleBackColor = true;
            Btn_Result.Click += Btn_Result_Click;
            // 
            // Btn_Clear
            // 
            Btn_Clear.Location = new Point(528, 132);
            Btn_Clear.Name = "Btn_Clear";
            Btn_Clear.Size = new Size(94, 29);
            Btn_Clear.TabIndex = 9;
            Btn_Clear.Text = "Xóa";
            Btn_Clear.UseVisualStyleBackColor = true;
            Btn_Clear.Click += Btn_Clear_Click;
            // 
            // Btn_Exit
            // 
            Btn_Exit.Location = new Point(528, 199);
            Btn_Exit.Name = "Btn_Exit";
            Btn_Exit.Size = new Size(94, 29);
            Btn_Exit.TabIndex = 10;
            Btn_Exit.Text = "Thoát";
            Btn_Exit.UseVisualStyleBackColor = true;
            Btn_Exit.Click += Btn_Exit_Click;
            // 
            // Bai6Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(730, 411);
            Controls.Add(Btn_Exit);
            Controls.Add(Btn_Clear);
            Controls.Add(Btn_Result);
            Controls.Add(Tb_CHD);
            Controls.Add(Lb_CHD);
            Controls.Add(Lb_Year);
            Controls.Add(Lb_Month);
            Controls.Add(Lb_Day);
            Controls.Add(TB_Year);
            Controls.Add(Tb_Month);
            Controls.Add(Tb_Day);
            Name = "Bai6Form";
            Text = "Bài 6";
            Load += Bai6Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Tb_Day;
        private TextBox Tb_Month;
        private TextBox TB_Year;
        private Label Lb_Day;
        private Label Lb_Month;
        private Label Lb_Year;
        private Label Lb_CHD;
        private TextBox Tb_CHD;
        private Button Btn_Result;
        private Button Btn_Clear;
        private Button Btn_Exit;
    }
}