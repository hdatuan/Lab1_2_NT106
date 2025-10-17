namespace Labs.Labs.Lab1.Bai5
{
    partial class Bai5Form
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
            Lbl_NumberA = new Label();
            Lbl_NumberB = new Label();
            Btn_Cal = new Button();
            GB_Result = new GroupBox();
            Lbl_Result = new Label();
            CB_Option = new ComboBox();
            TB_NumberA = new TextBox();
            TB_NumberB = new TextBox();
            Lbl_Option = new Label();
            Btn_Clear = new Button();
            Btn_Exit = new Button();
            GB_Result.SuspendLayout();
            SuspendLayout();
            // 
            // Lbl_NumberA
            // 
            Lbl_NumberA.AutoSize = true;
            Lbl_NumberA.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_NumberA.Location = new Point(79, 97);
            Lbl_NumberA.Name = "Lbl_NumberA";
            Lbl_NumberA.Size = new Size(54, 28);
            Lbl_NumberA.TabIndex = 0;
            Lbl_NumberA.Text = "Số A";
            // 
            // Lbl_NumberB
            // 
            Lbl_NumberB.AutoSize = true;
            Lbl_NumberB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_NumberB.Location = new Point(79, 163);
            Lbl_NumberB.Name = "Lbl_NumberB";
            Lbl_NumberB.Size = new Size(53, 28);
            Lbl_NumberB.TabIndex = 1;
            Lbl_NumberB.Text = "Số B";
            // 
            // Btn_Cal
            // 
            Btn_Cal.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Cal.Location = new Point(181, 400);
            Btn_Cal.Name = "Btn_Cal";
            Btn_Cal.Size = new Size(121, 38);
            Btn_Cal.TabIndex = 2;
            Btn_Cal.Text = "Tính toán";
            Btn_Cal.UseVisualStyleBackColor = true;
            Btn_Cal.Click += Btn_Cal_Click;
            // 
            // GB_Result
            // 
            GB_Result.Controls.Add(Lbl_Result);
            GB_Result.Location = new Point(455, 37);
            GB_Result.Name = "GB_Result";
            GB_Result.Size = new Size(450, 296);
            GB_Result.TabIndex = 3;
            GB_Result.TabStop = false;
            GB_Result.Text = "Kết quả";
            // 
            // Lbl_Result
            // 
            Lbl_Result.AutoSize = true;
            Lbl_Result.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Result.Location = new Point(40, 44);
            Lbl_Result.Name = "Lbl_Result";
            Lbl_Result.Size = new Size(0, 21);
            Lbl_Result.TabIndex = 10;
            // 
            // CB_Option
            // 
            CB_Option.FormattingEnabled = true;
            CB_Option.Items.AddRange(new object[] { "Bảng cửu chương", "Tính toán các giá trị" });
            CB_Option.Location = new Point(220, 231);
            CB_Option.Name = "CB_Option";
            CB_Option.Size = new Size(151, 28);
            CB_Option.TabIndex = 4;
            CB_Option.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // TB_NumberA
            // 
            TB_NumberA.Location = new Point(220, 101);
            TB_NumberA.Name = "TB_NumberA";
            TB_NumberA.Size = new Size(151, 27);
            TB_NumberA.TabIndex = 5;
            // 
            // TB_NumberB
            // 
            TB_NumberB.Location = new Point(220, 167);
            TB_NumberB.Name = "TB_NumberB";
            TB_NumberB.Size = new Size(151, 27);
            TB_NumberB.TabIndex = 6;
            // 
            // Lbl_Option
            // 
            Lbl_Option.AutoSize = true;
            Lbl_Option.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Option.Location = new Point(79, 227);
            Lbl_Option.Name = "Lbl_Option";
            Lbl_Option.Size = new Size(99, 28);
            Lbl_Option.TabIndex = 7;
            Lbl_Option.Text = "Tính toán";
            // 
            // Btn_Clear
            // 
            Btn_Clear.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Clear.Location = new Point(395, 400);
            Btn_Clear.Name = "Btn_Clear";
            Btn_Clear.Size = new Size(121, 38);
            Btn_Clear.TabIndex = 8;
            Btn_Clear.Text = "Xóa";
            Btn_Clear.UseVisualStyleBackColor = true;
            Btn_Clear.Click += Btn_Clear_Click;
            // 
            // Btn_Exit
            // 
            Btn_Exit.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Exit.Location = new Point(611, 400);
            Btn_Exit.Name = "Btn_Exit";
            Btn_Exit.Size = new Size(121, 38);
            Btn_Exit.TabIndex = 9;
            Btn_Exit.Text = "Thoát";
            Btn_Exit.UseVisualStyleBackColor = true;
            Btn_Exit.Click += Btn_Exit_Click;
            // 
            // Bai5Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(935, 493);
            Controls.Add(Btn_Exit);
            Controls.Add(Btn_Clear);
            Controls.Add(Lbl_Option);
            Controls.Add(TB_NumberB);
            Controls.Add(TB_NumberA);
            Controls.Add(CB_Option);
            Controls.Add(GB_Result);
            Controls.Add(Btn_Cal);
            Controls.Add(Lbl_NumberB);
            Controls.Add(Lbl_NumberA);
            Name = "Bai5Form";
            Text = "Bài 5";
            GB_Result.ResumeLayout(false);
            GB_Result.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_NumberA;
        private Label Lbl_NumberB;
        private Button Btn_Cal;
        private GroupBox GB_Result;
        private ComboBox CB_Option;
        private TextBox TB_NumberA;
        private TextBox TB_NumberB;
        private Label Lbl_Option;
        private Button Btn_Clear;
        private Button Btn_Exit;
        private Label Lbl_Result;
    }
}