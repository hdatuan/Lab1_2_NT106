namespace Labs
{
    partial class LabMenu : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Btn_Lab1 = new Button();
            Btn_Lab2 = new Button();
            Lb_Name = new Label();
            Lb_Code = new Label();
            SuspendLayout();
            // 
            // Btn_Lab1
            // 
            Btn_Lab1.BackColor = Color.LightSkyBlue;
            Btn_Lab1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Lab1.ForeColor = Color.FloralWhite;
            Btn_Lab1.Location = new Point(245, 282);
            Btn_Lab1.Name = "Btn_Lab1";
            Btn_Lab1.Size = new Size(162, 51);
            Btn_Lab1.TabIndex = 0;
            Btn_Lab1.Text = "Lab 1";
            Btn_Lab1.UseVisualStyleBackColor = false;
            Btn_Lab1.Click += Btn_Lab1_Click;
            // 
            // Btn_Lab2
            // 
            Btn_Lab2.BackColor = Color.LightSkyBlue;
            Btn_Lab2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Lab2.ForeColor = Color.FloralWhite;
            Btn_Lab2.Location = new Point(245, 388);
            Btn_Lab2.Name = "Btn_Lab2";
            Btn_Lab2.Size = new Size(162, 51);
            Btn_Lab2.TabIndex = 1;
            Btn_Lab2.Text = "Lab 2";
            Btn_Lab2.UseVisualStyleBackColor = false;
            Btn_Lab2.Click += Btn_Lab2_Click;
            // 
            // Lb_Name
            // 
            Lb_Name.AutoSize = true;
            Lb_Name.BackColor = Color.DeepSkyBlue;
            Lb_Name.Font = new Font("Consolas", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Lb_Name.ForeColor = SystemColors.HighlightText;
            Lb_Name.Location = new Point(180, 117);
            Lb_Name.Name = "Lb_Name";
            Lb_Name.Size = new Size(303, 36);
            Lb_Name.TabIndex = 2;
            Lb_Name.Text = "Hoàng Đức Anh Tuấn";
            // 
            // Lb_Code
            // 
            Lb_Code.AutoSize = true;
            Lb_Code.BackColor = Color.DeepSkyBlue;
            Lb_Code.Font = new Font("Consolas", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Lb_Code.ForeColor = SystemColors.HighlightText;
            Lb_Code.Location = new Point(255, 179);
            Lb_Code.Name = "Lb_Code";
            Lb_Code.Size = new Size(143, 36);
            Lb_Code.TabIndex = 3;
            Lb_Code.Text = "24521922";
            // 
            // LabMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(659, 567);
            Controls.Add(Lb_Code);
            Controls.Add(Lb_Name);
            Controls.Add(Btn_Lab2);
            Controls.Add(Btn_Lab1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.DeepPink;
            Name = "LabMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab menu";
            Load += LabMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Lab1;
        private Button Btn_Lab2;
        private Label Lb_Name;
        private Label Lb_Code;
    }
}
