namespace Labs.Labs.Lab1.Bai1
{
    public partial class Bai1Form : Form
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
            Lbl_Number1 = new Label();
            Tb_Number1 = new TextBox();
            Btn_Calculate = new Button();
            Lbl_Number2 = new Label();
            Tb_Number2 = new TextBox();
            Lbl_Sum = new Label();
            Tb_Sum = new TextBox();
            Btn_Exit = new Button();
            SuspendLayout();
            // 
            // Lbl_Number1
            // 
            Lbl_Number1.AutoSize = true;
            Lbl_Number1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Number1.Location = new Point(81, 76);
            Lbl_Number1.Name = "Lbl_Number1";
            Lbl_Number1.Size = new Size(132, 31);
            Lbl_Number1.TabIndex = 0;
            Lbl_Number1.Text = "Số thứ nhất";
            // 
            // Tb_Number1
            // 
            Tb_Number1.Location = new Point(295, 76);
            Tb_Number1.Name = "Tb_Number1";
            Tb_Number1.Size = new Size(125, 27);
            Tb_Number1.TabIndex = 1;
            // 
            // Btn_Calculate
            // 
            Btn_Calculate.Location = new Point(536, 120);
            Btn_Calculate.Name = "Btn_Calculate";
            Btn_Calculate.Size = new Size(94, 29);
            Btn_Calculate.TabIndex = 2;
            Btn_Calculate.Text = "Tính";
            Btn_Calculate.UseVisualStyleBackColor = true;
            Btn_Calculate.Click += button1_Click;
            // 
            // Lbl_Number2
            // 
            Lbl_Number2.AutoSize = true;
            Lbl_Number2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Number2.Location = new Point(81, 151);
            Lbl_Number2.Name = "Lbl_Number2";
            Lbl_Number2.Size = new Size(117, 31);
            Lbl_Number2.TabIndex = 3;
            Lbl_Number2.Text = "Số thứ hai";
            // 
            // Tb_Number2
            // 
            Tb_Number2.Location = new Point(295, 151);
            Tb_Number2.Name = "Tb_Number2";
            Tb_Number2.Size = new Size(125, 27);
            Tb_Number2.TabIndex = 4;
            // 
            // Lbl_Sum
            // 
            Lbl_Sum.AutoSize = true;
            Lbl_Sum.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Sum.Location = new Point(100, 234);
            Lbl_Sum.Name = "Lbl_Sum";
            Lbl_Sum.Size = new Size(66, 31);
            Lbl_Sum.TabIndex = 5;
            Lbl_Sum.Text = "Tổng";
            // 
            // Tb_Sum
            // 
            Tb_Sum.Location = new Point(295, 240);
            Tb_Sum.Name = "Tb_Sum";
            Tb_Sum.ReadOnly = true;
            Tb_Sum.Size = new Size(125, 27);
            Tb_Sum.TabIndex = 6;
            // 
            // Btn_Exit
            // 
            Btn_Exit.Location = new Point(536, 177);
            Btn_Exit.Name = "Btn_Exit";
            Btn_Exit.Size = new Size(94, 29);
            Btn_Exit.TabIndex = 20;
            Btn_Exit.Text = "Thoát";
            Btn_Exit.UseVisualStyleBackColor = true;
            Btn_Exit.Click += Btn_Exit_Click;
            // 
            // Bai1Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(785, 361);
            Controls.Add(Btn_Exit);
            Controls.Add(Tb_Sum);
            Controls.Add(Lbl_Sum);
            Controls.Add(Tb_Number2);
            Controls.Add(Lbl_Number2);
            Controls.Add(Btn_Calculate);
            Controls.Add(Tb_Number1);
            Controls.Add(Lbl_Number1);
            Name = "Bai1Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Number1;
        private TextBox Tb_Number1;
        private Button Btn_Calculate;
        private Label Lbl_Number2;
        private TextBox Tb_Number2;
        private Label Lbl_Sum;
        private TextBox Tb_Sum;
        private Button Btn_Exit;
    }
}