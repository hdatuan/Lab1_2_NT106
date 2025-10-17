namespace Labs.Labs.Lab1.Bai8
{
    partial class Bai8Form
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
            Lb_AddMeal = new Label();
            Tb_AddMeal = new TextBox();
            Lb_MealList = new Label();
            Btn_AddMeal = new Button();
            label1 = new Label();
            Btn_Result = new Button();
            Btn_Clear = new Button();
            Btn_Exit = new Button();
            Lb_Result = new Label();
            Tb_Result = new TextBox();
            SuspendLayout();
            // 
            // Lb_AddMeal
            // 
            Lb_AddMeal.AutoSize = true;
            Lb_AddMeal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_AddMeal.Location = new Point(88, 51);
            Lb_AddMeal.Name = "Lb_AddMeal";
            Lb_AddMeal.Size = new Size(142, 28);
            Lb_AddMeal.TabIndex = 0;
            Lb_AddMeal.Text = "Thêm món ăn";
            // 
            // Tb_AddMeal
            // 
            Tb_AddMeal.Location = new Point(307, 52);
            Tb_AddMeal.Name = "Tb_AddMeal";
            Tb_AddMeal.Size = new Size(228, 27);
            Tb_AddMeal.TabIndex = 1;
            // 
            // Lb_MealList
            // 
            Lb_MealList.BorderStyle = BorderStyle.FixedSingle;
            Lb_MealList.Location = new Point(307, 121);
            Lb_MealList.Name = "Lb_MealList";
            Lb_MealList.Size = new Size(405, 194);
            Lb_MealList.TabIndex = 2;
            // 
            // Btn_AddMeal
            // 
            Btn_AddMeal.Location = new Point(618, 51);
            Btn_AddMeal.Name = "Btn_AddMeal";
            Btn_AddMeal.Size = new Size(94, 29);
            Btn_AddMeal.TabIndex = 3;
            Btn_AddMeal.Text = "Thêm";
            Btn_AddMeal.UseVisualStyleBackColor = true;
            Btn_AddMeal.Click += Btn_AddMeal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 132);
            label1.Name = "label1";
            label1.Size = new Size(187, 28);
            label1.TabIndex = 4;
            label1.Text = "Danh sách món ăn";
            // 
            // Btn_Result
            // 
            Btn_Result.Location = new Point(136, 365);
            Btn_Result.Name = "Btn_Result";
            Btn_Result.Size = new Size(126, 44);
            Btn_Result.TabIndex = 5;
            Btn_Result.Text = "Tìm món ăn";
            Btn_Result.UseVisualStyleBackColor = true;
            Btn_Result.Click += Btn_Result_Click;
            // 
            // Btn_Clear
            // 
            Btn_Clear.Location = new Point(336, 365);
            Btn_Clear.Name = "Btn_Clear";
            Btn_Clear.Size = new Size(126, 44);
            Btn_Clear.TabIndex = 6;
            Btn_Clear.Text = "Xóa";
            Btn_Clear.UseVisualStyleBackColor = true;
            Btn_Clear.Click += Btn_Clear_Click;
            // 
            // Btn_Exit
            // 
            Btn_Exit.Location = new Point(539, 365);
            Btn_Exit.Name = "Btn_Exit";
            Btn_Exit.Size = new Size(126, 44);
            Btn_Exit.TabIndex = 7;
            Btn_Exit.Text = "Thoát";
            Btn_Exit.UseVisualStyleBackColor = true;
            Btn_Exit.Click += button3_Click;
            // 
            // Lb_Result
            // 
            Lb_Result.AutoSize = true;
            Lb_Result.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Result.Location = new Point(336, 471);
            Lb_Result.Name = "Lb_Result";
            Lb_Result.Size = new Size(172, 28);
            Lb_Result.TabIndex = 8;
            Lb_Result.Text = "Món ăn hôm nay";
            // 
            // Tb_Result
            // 
            Tb_Result.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Tb_Result.Location = new Point(307, 518);
            Tb_Result.Name = "Tb_Result";
            Tb_Result.ReadOnly = true;
            Tb_Result.Size = new Size(244, 30);
            Tb_Result.TabIndex = 9;
            Tb_Result.Text = "Ăn gì cũng được !?";
            // 
            // Bai8Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(835, 606);
            Controls.Add(Tb_Result);
            Controls.Add(Lb_Result);
            Controls.Add(Btn_Exit);
            Controls.Add(Btn_Clear);
            Controls.Add(Btn_Result);
            Controls.Add(label1);
            Controls.Add(Btn_AddMeal);
            Controls.Add(Lb_MealList);
            Controls.Add(Tb_AddMeal);
            Controls.Add(Lb_AddMeal);
            Name = "Bai8Form";
            Text = "Bài 8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lb_AddMeal;
        private TextBox Tb_AddMeal;
        private Label Lb_MealList;
        private Button Btn_AddMeal;
        private Label label1;
        private Button Btn_Result;
        private Button Btn_Clear;
        private Button Btn_Exit;
        private Label Lb_Result;
        private TextBox Tb_Result;
    }
}