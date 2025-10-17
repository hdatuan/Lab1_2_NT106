namespace Labs.Labs.Lab1.Bai7
{
    partial class Bai7Form
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
            Lb_Input = new Label();
            Tb_Input = new TextBox();
            Lb_Result = new Label();
            Btn_Result = new Button();
            Btn_Clear = new Button();
            Btn_Exit = new Button();
            SuspendLayout();
            // 
            // Lb_Input
            // 
            Lb_Input.AutoSize = true;
            Lb_Input.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Input.Location = new Point(327, 48);
            Lb_Input.Name = "Lb_Input";
            Lb_Input.Size = new Size(299, 31);
            Lb_Input.TabIndex = 0;
            Lb_Input.Text = "Nhập tên và điểm các môn";
            // 
            // Tb_Input
            // 
            Tb_Input.BackColor = SystemColors.Info;
            Tb_Input.Location = new Point(129, 107);
            Tb_Input.Multiline = true;
            Tb_Input.Name = "Tb_Input";
            Tb_Input.Size = new Size(676, 34);
            Tb_Input.TabIndex = 1;
            // 
            // Lb_Result
            // 
            Lb_Result.BorderStyle = BorderStyle.FixedSingle;
            Lb_Result.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Result.Location = new Point(61, 190);
            Lb_Result.Name = "Lb_Result";
            Lb_Result.Size = new Size(588, 342);
            Lb_Result.TabIndex = 2;
            // 
            // Btn_Result
            // 
            Btn_Result.BackColor = Color.LightCyan;
            Btn_Result.ForeColor = SystemColors.ControlText;
            Btn_Result.Location = new Point(721, 205);
            Btn_Result.Name = "Btn_Result";
            Btn_Result.Size = new Size(138, 42);
            Btn_Result.TabIndex = 3;
            Btn_Result.Text = "Xuất kết quả";
            Btn_Result.UseVisualStyleBackColor = false;
            Btn_Result.Click += Btn_Result_Click;
            // 
            // Btn_Clear
            // 
            Btn_Clear.BackColor = Color.LightCyan;
            Btn_Clear.Location = new Point(721, 324);
            Btn_Clear.Name = "Btn_Clear";
            Btn_Clear.Size = new Size(138, 42);
            Btn_Clear.TabIndex = 4;
            Btn_Clear.Text = "Xóa";
            Btn_Clear.UseVisualStyleBackColor = false;
            Btn_Clear.Click += Btn_Clear_Click;
            // 
            // Btn_Exit
            // 
            Btn_Exit.BackColor = Color.LightCyan;
            Btn_Exit.Location = new Point(721, 453);
            Btn_Exit.Name = "Btn_Exit";
            Btn_Exit.Size = new Size(138, 42);
            Btn_Exit.TabIndex = 5;
            Btn_Exit.Text = "Thoát";
            Btn_Exit.UseVisualStyleBackColor = false;
            Btn_Exit.Click += Btn_Exit_Click;
            // 
            // Bai7Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(923, 579);
            Controls.Add(Btn_Exit);
            Controls.Add(Btn_Clear);
            Controls.Add(Btn_Result);
            Controls.Add(Lb_Result);
            Controls.Add(Tb_Input);
            Controls.Add(Lb_Input);
            Name = "Bai7Form";
            Text = "Bài 7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lb_Input;
        private TextBox Tb_Input;
        private Label Lb_Result;
        private Button Btn_Result;
        private Button Btn_Clear;
        private Button Btn_Exit;
    }
}