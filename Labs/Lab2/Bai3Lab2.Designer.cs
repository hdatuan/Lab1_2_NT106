namespace Labs.Labs.Lab2
{
    partial class Bai3Lab2
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
            Btn_Clear = new Button();
            Lb_Output = new Label();
            Tb_OutputName = new TextBox();
            Lb_Input = new Label();
            Tb_InputName = new TextBox();
            Btn_Exit = new Button();
            Rtb_File = new RichTextBox();
            Btn_WriteFile = new Button();
            Btn_ReadFile = new Button();
            SuspendLayout();
            // 
            // Btn_Clear
            // 
            Btn_Clear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Clear.Location = new Point(688, 357);
            Btn_Clear.Name = "Btn_Clear";
            Btn_Clear.Size = new Size(146, 44);
            Btn_Clear.TabIndex = 17;
            Btn_Clear.Text = "Xóa";
            Btn_Clear.UseVisualStyleBackColor = true;
            Btn_Clear.Click += Btn_Clear_Click;
            // 
            // Lb_Output
            // 
            Lb_Output.AutoSize = true;
            Lb_Output.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Output.Location = new Point(605, 151);
            Lb_Output.Name = "Lb_Output";
            Lb_Output.Size = new Size(99, 23);
            Lb_Output.TabIndex = 16;
            Lb_Output.Text = "Tên file ghi";
            // 
            // Tb_OutputName
            // 
            Tb_OutputName.Location = new Point(753, 147);
            Tb_OutputName.Name = "Tb_OutputName";
            Tb_OutputName.PlaceholderText = "ex : output3.txt";
            Tb_OutputName.Size = new Size(156, 27);
            Tb_OutputName.TabIndex = 15;
            // 
            // Lb_Input
            // 
            Lb_Input.AutoSize = true;
            Lb_Input.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Input.Location = new Point(605, 92);
            Lb_Input.Name = "Lb_Input";
            Lb_Input.Size = new Size(102, 23);
            Lb_Input.TabIndex = 14;
            Lb_Input.Text = "Tên file đọc";
            // 
            // Tb_InputName
            // 
            Tb_InputName.Location = new Point(753, 88);
            Tb_InputName.Name = "Tb_InputName";
            Tb_InputName.PlaceholderText = "ex : input3.txt";
            Tb_InputName.Size = new Size(156, 27);
            Tb_InputName.TabIndex = 13;
            // 
            // Btn_Exit
            // 
            Btn_Exit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Exit.Location = new Point(688, 437);
            Btn_Exit.Name = "Btn_Exit";
            Btn_Exit.Size = new Size(146, 44);
            Btn_Exit.TabIndex = 12;
            Btn_Exit.Text = "Thoát";
            Btn_Exit.UseVisualStyleBackColor = true;
            Btn_Exit.Click += Btn_Exit_Click;
            // 
            // Rtb_File
            // 
            Rtb_File.Location = new Point(58, 66);
            Rtb_File.Name = "Rtb_File";
            Rtb_File.ReadOnly = true;
            Rtb_File.Size = new Size(493, 415);
            Rtb_File.TabIndex = 11;
            Rtb_File.Text = "";
            // 
            // Btn_WriteFile
            // 
            Btn_WriteFile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_WriteFile.Location = new Point(688, 283);
            Btn_WriteFile.Name = "Btn_WriteFile";
            Btn_WriteFile.Size = new Size(146, 44);
            Btn_WriteFile.TabIndex = 10;
            Btn_WriteFile.Text = "Ghi File";
            Btn_WriteFile.UseVisualStyleBackColor = true;
            Btn_WriteFile.Click += Btn_WriteFile_Click;
            // 
            // Btn_ReadFile
            // 
            Btn_ReadFile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_ReadFile.Location = new Point(688, 212);
            Btn_ReadFile.Name = "Btn_ReadFile";
            Btn_ReadFile.Size = new Size(146, 44);
            Btn_ReadFile.TabIndex = 9;
            Btn_ReadFile.Text = "Đọc File";
            Btn_ReadFile.UseVisualStyleBackColor = true;
            Btn_ReadFile.Click += Btn_ReadFile_Click;
            // 
            // Bai3Lab2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(950, 562);
            Controls.Add(Btn_Clear);
            Controls.Add(Lb_Output);
            Controls.Add(Tb_OutputName);
            Controls.Add(Lb_Input);
            Controls.Add(Tb_InputName);
            Controls.Add(Btn_Exit);
            Controls.Add(Rtb_File);
            Controls.Add(Btn_WriteFile);
            Controls.Add(Btn_ReadFile);
            Name = "Bai3Lab2";
            Text = "Bai3Lab2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Clear;
        private Label Lb_Output;
        private TextBox Tb_OutputName;
        private Label Lb_Input;
        private TextBox Tb_InputName;
        private Button Btn_Exit;
        private RichTextBox Rtb_File;
        private Button Btn_WriteFile;
        private Button Btn_ReadFile;
    }
}