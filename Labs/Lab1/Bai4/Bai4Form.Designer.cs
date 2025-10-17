namespace Labs.Labs.Lab1.Bai4
{
    partial class Bai4Form
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
            CB_Movie = new ComboBox();
            Lbl_Movie = new Label();
            Lbl_Name = new Label();
            TB_Name = new TextBox();
            TB_SDT = new TextBox();
            Lbl_SDT = new Label();
            Lbl_Count = new Label();
            CB_Count = new ComboBox();
            Lbl_CustomerInfo = new Label();
            Lbl_Seat1 = new Label();
            Lbl_Room1 = new Label();
            CB_Room1 = new ComboBox();
            Lbl_Seat2 = new Label();
            Lbl_Room2 = new Label();
            CB_Room2 = new ComboBox();
            GB_Ticket1 = new GroupBox();
            CLB_Seat1 = new CheckedListBox();
            Lbl_TicketType1 = new Label();
            CB_TicketType1 = new ComboBox();
            GB_Ticket2 = new GroupBox();
            CLB_Seat2 = new CheckedListBox();
            Lbl_TicketType2 = new Label();
            CB_TicketType2 = new ComboBox();
            Btn_Save = new Button();
            Lbl_TicketInfo = new Label();
            Btn_Clear = new Button();
            Btn_Exit = new Button();
            Btn_Export = new Button();
            Lbl_Ticket_CusName = new Label();
            Lbl_Ticket = new Label();
            Lbl_Ticket_SDT = new Label();
            Lbl_Ticket_Movie = new Label();
            Lbl_Tickets = new Label();
            Lbl_Ticket_Seat = new Label();
            Lbl_Ticket_Cost = new Label();
            GB_Ticket1.SuspendLayout();
            GB_Ticket2.SuspendLayout();
            SuspendLayout();
            // 
            // CB_Movie
            // 
            CB_Movie.FormattingEnabled = true;
            CB_Movie.Items.AddRange(new object[] { "Đào, phở và piano", "Mai", "Gặp lại chị bầu", "Tarot" });
            CB_Movie.Location = new Point(279, 257);
            CB_Movie.Name = "CB_Movie";
            CB_Movie.Size = new Size(203, 28);
            CB_Movie.TabIndex = 0;
            CB_Movie.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Lbl_Movie
            // 
            Lbl_Movie.AutoSize = true;
            Lbl_Movie.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            Lbl_Movie.Location = new Point(47, 257);
            Lbl_Movie.Name = "Lbl_Movie";
            Lbl_Movie.Size = new Size(66, 31);
            Lbl_Movie.TabIndex = 2;
            Lbl_Movie.Text = "Phim";
            // 
            // Lbl_Name
            // 
            Lbl_Name.AutoSize = true;
            Lbl_Name.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            Lbl_Name.Location = new Point(41, 148);
            Lbl_Name.Name = "Lbl_Name";
            Lbl_Name.Size = new Size(114, 31);
            Lbl_Name.TabIndex = 5;
            Lbl_Name.Text = "Họ và tên";
            // 
            // TB_Name
            // 
            TB_Name.Location = new Point(279, 148);
            TB_Name.Name = "TB_Name";
            TB_Name.Size = new Size(203, 27);
            TB_Name.TabIndex = 6;
            // 
            // TB_SDT
            // 
            TB_SDT.Location = new Point(279, 200);
            TB_SDT.Name = "TB_SDT";
            TB_SDT.Size = new Size(203, 27);
            TB_SDT.TabIndex = 8;
            // 
            // Lbl_SDT
            // 
            Lbl_SDT.AutoSize = true;
            Lbl_SDT.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            Lbl_SDT.Location = new Point(41, 200);
            Lbl_SDT.Name = "Lbl_SDT";
            Lbl_SDT.Size = new Size(151, 31);
            Lbl_SDT.TabIndex = 7;
            Lbl_SDT.Text = "Số điện thoại";
            // 
            // Lbl_Count
            // 
            Lbl_Count.AutoSize = true;
            Lbl_Count.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            Lbl_Count.Location = new Point(47, 312);
            Lbl_Count.Name = "Lbl_Count";
            Lbl_Count.Size = new Size(182, 31);
            Lbl_Count.TabIndex = 11;
            Lbl_Count.Text = "Số lượng phòng";
            // 
            // CB_Count
            // 
            CB_Count.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            CB_Count.FormattingEnabled = true;
            CB_Count.Items.AddRange(new object[] { "1", "2" });
            CB_Count.Location = new Point(279, 315);
            CB_Count.Name = "CB_Count";
            CB_Count.Size = new Size(203, 28);
            CB_Count.TabIndex = 15;
            CB_Count.Tag = "";
            CB_Count.Text = "Vui lòng chọn phim";
            CB_Count.SelectedIndexChanged += CB_Count_SelectedIndexChanged;
            // 
            // Lbl_CustomerInfo
            // 
            Lbl_CustomerInfo.AutoSize = true;
            Lbl_CustomerInfo.Font = new Font("Candara", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_CustomerInfo.Location = new Point(111, 74);
            Lbl_CustomerInfo.Name = "Lbl_CustomerInfo";
            Lbl_CustomerInfo.Size = new Size(229, 58);
            Lbl_CustomerInfo.TabIndex = 16;
            Lbl_CustomerInfo.Text = "Thông tin ";
            // 
            // Lbl_Seat1
            // 
            Lbl_Seat1.AutoSize = true;
            Lbl_Seat1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            Lbl_Seat1.Location = new Point(37, 166);
            Lbl_Seat1.Name = "Lbl_Seat1";
            Lbl_Seat1.Size = new Size(108, 31);
            Lbl_Seat1.TabIndex = 23;
            Lbl_Seat1.Text = "Ghế ngồi";
            // 
            // Lbl_Room1
            // 
            Lbl_Room1.AutoSize = true;
            Lbl_Room1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            Lbl_Room1.Location = new Point(37, 64);
            Lbl_Room1.Name = "Lbl_Room1";
            Lbl_Room1.Size = new Size(142, 31);
            Lbl_Room1.TabIndex = 22;
            Lbl_Room1.Text = "Phòng chiếu";
            // 
            // CB_Room1
            // 
            CB_Room1.FormattingEnabled = true;
            CB_Room1.Location = new Point(196, 64);
            CB_Room1.Name = "CB_Room1";
            CB_Room1.Size = new Size(203, 28);
            CB_Room1.TabIndex = 21;
            CB_Room1.SelectedIndexChanged += CB_Room1_SelectedIndexChanged;
            // 
            // Lbl_Seat2
            // 
            Lbl_Seat2.AutoSize = true;
            Lbl_Seat2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            Lbl_Seat2.Location = new Point(32, 166);
            Lbl_Seat2.Name = "Lbl_Seat2";
            Lbl_Seat2.Size = new Size(108, 31);
            Lbl_Seat2.TabIndex = 29;
            Lbl_Seat2.Text = "Ghế ngồi";
            // 
            // Lbl_Room2
            // 
            Lbl_Room2.AutoSize = true;
            Lbl_Room2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            Lbl_Room2.Location = new Point(32, 64);
            Lbl_Room2.Name = "Lbl_Room2";
            Lbl_Room2.Size = new Size(142, 31);
            Lbl_Room2.TabIndex = 28;
            Lbl_Room2.Text = "Phòng chiếu";
            // 
            // CB_Room2
            // 
            CB_Room2.FormattingEnabled = true;
            CB_Room2.Location = new Point(191, 64);
            CB_Room2.Name = "CB_Room2";
            CB_Room2.Size = new Size(203, 28);
            CB_Room2.TabIndex = 27;
            // 
            // GB_Ticket1
            // 
            GB_Ticket1.Controls.Add(CLB_Seat1);
            GB_Ticket1.Controls.Add(Lbl_TicketType1);
            GB_Ticket1.Controls.Add(CB_TicketType1);
            GB_Ticket1.Controls.Add(CB_Room1);
            GB_Ticket1.Controls.Add(Lbl_Room1);
            GB_Ticket1.Controls.Add(Lbl_Seat1);
            GB_Ticket1.Location = new Point(535, 65);
            GB_Ticket1.Name = "GB_Ticket1";
            GB_Ticket1.Size = new Size(435, 280);
            GB_Ticket1.TabIndex = 32;
            GB_Ticket1.TabStop = false;
            GB_Ticket1.Text = "Vé phòng 1";
            // 
            // CLB_Seat1
            // 
            CLB_Seat1.FormattingEnabled = true;
            CLB_Seat1.Location = new Point(196, 171);
            CLB_Seat1.Name = "CLB_Seat1";
            CLB_Seat1.Size = new Size(203, 92);
            CLB_Seat1.TabIndex = 39;
            CLB_Seat1.SelectedIndexChanged += CLB_Seat1_SelectedIndexChanged;
            // 
            // Lbl_TicketType1
            // 
            Lbl_TicketType1.AutoSize = true;
            Lbl_TicketType1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            Lbl_TicketType1.Location = new Point(37, 112);
            Lbl_TicketType1.Name = "Lbl_TicketType1";
            Lbl_TicketType1.Size = new Size(87, 31);
            Lbl_TicketType1.TabIndex = 25;
            Lbl_TicketType1.Text = "Loại vé";
            // 
            // CB_TicketType1
            // 
            CB_TicketType1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CB_TicketType1.FormattingEnabled = true;
            CB_TicketType1.Items.AddRange(new object[] { "Thường", "Vớt", "VIP" });
            CB_TicketType1.Location = new Point(196, 118);
            CB_TicketType1.Name = "CB_TicketType1";
            CB_TicketType1.Size = new Size(203, 28);
            CB_TicketType1.TabIndex = 26;
            CB_TicketType1.Tag = "";
            CB_TicketType1.SelectedIndexChanged += CB_TicketType1_SelectedIndexChanged;
            // 
            // GB_Ticket2
            // 
            GB_Ticket2.Controls.Add(CLB_Seat2);
            GB_Ticket2.Controls.Add(Lbl_TicketType2);
            GB_Ticket2.Controls.Add(CB_TicketType2);
            GB_Ticket2.Controls.Add(Lbl_Room2);
            GB_Ticket2.Controls.Add(CB_Room2);
            GB_Ticket2.Controls.Add(Lbl_Seat2);
            GB_Ticket2.Location = new Point(1027, 65);
            GB_Ticket2.Name = "GB_Ticket2";
            GB_Ticket2.Size = new Size(435, 280);
            GB_Ticket2.TabIndex = 34;
            GB_Ticket2.TabStop = false;
            GB_Ticket2.Text = "Vé phòng 2";
            GB_Ticket2.Enter += GB_Ticket2_Enter;
            // 
            // CLB_Seat2
            // 
            CLB_Seat2.FormattingEnabled = true;
            CLB_Seat2.Location = new Point(191, 171);
            CLB_Seat2.Name = "CLB_Seat2";
            CLB_Seat2.Size = new Size(203, 92);
            CLB_Seat2.TabIndex = 40;
            CLB_Seat2.SelectedIndexChanged += checkedListBox2_SelectedIndexChanged;
            // 
            // Lbl_TicketType2
            // 
            Lbl_TicketType2.AutoSize = true;
            Lbl_TicketType2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            Lbl_TicketType2.Location = new Point(32, 112);
            Lbl_TicketType2.Name = "Lbl_TicketType2";
            Lbl_TicketType2.Size = new Size(87, 31);
            Lbl_TicketType2.TabIndex = 31;
            Lbl_TicketType2.Text = "Loại vé";
            // 
            // CB_TicketType2
            // 
            CB_TicketType2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CB_TicketType2.FormattingEnabled = true;
            CB_TicketType2.Items.AddRange(new object[] { "Thường", "Vớt", "VIP" });
            CB_TicketType2.Location = new Point(191, 118);
            CB_TicketType2.Name = "CB_TicketType2";
            CB_TicketType2.Size = new Size(203, 28);
            CB_TicketType2.TabIndex = 32;
            CB_TicketType2.Tag = "";
            CB_TicketType2.SelectedIndexChanged += CB_TicketType2_SelectedIndexChanged;
            // 
            // Btn_Save
            // 
            Btn_Save.BackColor = SystemColors.MenuHighlight;
            Btn_Save.Location = new Point(1192, 375);
            Btn_Save.Name = "Btn_Save";
            Btn_Save.Size = new Size(132, 41);
            Btn_Save.TabIndex = 38;
            Btn_Save.Text = "Lưu thông tin";
            Btn_Save.UseVisualStyleBackColor = false;
            Btn_Save.Click += Btn_Save_Click;
            // 
            // Lbl_TicketInfo
            // 
            Lbl_TicketInfo.BackColor = SystemColors.InactiveCaption;
            Lbl_TicketInfo.BorderStyle = BorderStyle.FixedSingle;
            Lbl_TicketInfo.Location = new Point(47, 384);
            Lbl_TicketInfo.Name = "Lbl_TicketInfo";
            Lbl_TicketInfo.Size = new Size(923, 426);
            Lbl_TicketInfo.TabIndex = 39;
            // 
            // Btn_Clear
            // 
            Btn_Clear.BackColor = Color.SandyBrown;
            Btn_Clear.Location = new Point(1192, 453);
            Btn_Clear.Name = "Btn_Clear";
            Btn_Clear.Size = new Size(132, 41);
            Btn_Clear.TabIndex = 40;
            Btn_Clear.Text = "Xóa thông tin";
            Btn_Clear.UseVisualStyleBackColor = false;
            Btn_Clear.Click += Btn_Clear_Click;
            // 
            // Btn_Exit
            // 
            Btn_Exit.BackColor = Color.LightCoral;
            Btn_Exit.Location = new Point(1192, 535);
            Btn_Exit.Name = "Btn_Exit";
            Btn_Exit.Size = new Size(132, 41);
            Btn_Exit.TabIndex = 41;
            Btn_Exit.Text = "Thoát";
            Btn_Exit.UseVisualStyleBackColor = false;
            Btn_Exit.Click += Btn_Exit_Click;
            // 
            // Btn_Export
            // 
            Btn_Export.BackColor = Color.Gold;
            Btn_Export.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Export.Location = new Point(1160, 638);
            Btn_Export.Name = "Btn_Export";
            Btn_Export.Size = new Size(202, 71);
            Btn_Export.TabIndex = 42;
            Btn_Export.Text = "Xuất vé";
            Btn_Export.UseVisualStyleBackColor = false;
            Btn_Export.Click += Btn_Export_Click;
            // 
            // Lbl_Ticket_CusName
            // 
            Lbl_Ticket_CusName.AutoSize = true;
            Lbl_Ticket_CusName.BackColor = SystemColors.InactiveCaption;
            Lbl_Ticket_CusName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            Lbl_Ticket_CusName.Location = new Point(74, 484);
            Lbl_Ticket_CusName.Name = "Lbl_Ticket_CusName";
            Lbl_Ticket_CusName.Size = new Size(193, 31);
            Lbl_Ticket_CusName.TabIndex = 43;
            Lbl_Ticket_CusName.Text = "Tên khách hàng : ";
            Lbl_Ticket_CusName.Visible = false;
            Lbl_Ticket_CusName.Click += label1_Click;
            // 
            // Lbl_Ticket
            // 
            Lbl_Ticket.AutoSize = true;
            Lbl_Ticket.BackColor = SystemColors.InactiveCaption;
            Lbl_Ticket.Font = new Font("Consolas", 22.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            Lbl_Ticket.Location = new Point(279, 409);
            Lbl_Ticket.Name = "Lbl_Ticket";
            Lbl_Ticket.Size = new Size(439, 43);
            Lbl_Ticket.TabIndex = 44;
            Lbl_Ticket.Text = "Thông tin vé xem phim";
            // 
            // Lbl_Ticket_SDT
            // 
            Lbl_Ticket_SDT.AutoSize = true;
            Lbl_Ticket_SDT.BackColor = SystemColors.InactiveCaption;
            Lbl_Ticket_SDT.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            Lbl_Ticket_SDT.Location = new Point(78, 535);
            Lbl_Ticket_SDT.Name = "Lbl_Ticket_SDT";
            Lbl_Ticket_SDT.Size = new Size(169, 31);
            Lbl_Ticket_SDT.TabIndex = 45;
            Lbl_Ticket_SDT.Text = "Số điện thoại : ";
            Lbl_Ticket_SDT.Visible = false;
            // 
            // Lbl_Ticket_Movie
            // 
            Lbl_Ticket_Movie.AutoSize = true;
            Lbl_Ticket_Movie.BackColor = SystemColors.InactiveCaption;
            Lbl_Ticket_Movie.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            Lbl_Ticket_Movie.Location = new Point(78, 577);
            Lbl_Ticket_Movie.Name = "Lbl_Ticket_Movie";
            Lbl_Ticket_Movie.Size = new Size(84, 31);
            Lbl_Ticket_Movie.TabIndex = 46;
            Lbl_Ticket_Movie.Text = "Phim : ";
            Lbl_Ticket_Movie.Visible = false;
            // 
            // Lbl_Tickets
            // 
            Lbl_Tickets.AutoSize = true;
            Lbl_Tickets.BackColor = SystemColors.InactiveCaption;
            Lbl_Tickets.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            Lbl_Tickets.Location = new Point(78, 626);
            Lbl_Tickets.Name = "Lbl_Tickets";
            Lbl_Tickets.Size = new Size(156, 31);
            Lbl_Tickets.TabIndex = 47;
            Lbl_Tickets.Text = "Số lượng vé : ";
            Lbl_Tickets.Visible = false;
            // 
            // Lbl_Ticket_Seat
            // 
            Lbl_Ticket_Seat.AutoSize = true;
            Lbl_Ticket_Seat.BackColor = SystemColors.InactiveCaption;
            Lbl_Ticket_Seat.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            Lbl_Ticket_Seat.Location = new Point(78, 678);
            Lbl_Ticket_Seat.Name = "Lbl_Ticket_Seat";
            Lbl_Ticket_Seat.Size = new Size(126, 31);
            Lbl_Ticket_Seat.TabIndex = 48;
            Lbl_Ticket_Seat.Text = "Ghế ngồi : ";
            Lbl_Ticket_Seat.Visible = false;
            // 
            // Lbl_Ticket_Cost
            // 
            Lbl_Ticket_Cost.AutoSize = true;
            Lbl_Ticket_Cost.BackColor = SystemColors.InactiveCaption;
            Lbl_Ticket_Cost.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            Lbl_Ticket_Cost.Location = new Point(78, 727);
            Lbl_Ticket_Cost.Name = "Lbl_Ticket_Cost";
            Lbl_Ticket_Cost.Size = new Size(141, 31);
            Lbl_Ticket_Cost.TabIndex = 49;
            Lbl_Ticket_Cost.Text = "Thành tiền : ";
            Lbl_Ticket_Cost.Visible = false;
            // 
            // Bai4Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1502, 835);
            Controls.Add(Lbl_Ticket_Cost);
            Controls.Add(Lbl_Ticket_Seat);
            Controls.Add(Lbl_Tickets);
            Controls.Add(Lbl_Ticket_Movie);
            Controls.Add(Lbl_Ticket_SDT);
            Controls.Add(Lbl_Ticket);
            Controls.Add(Lbl_Ticket_CusName);
            Controls.Add(Btn_Export);
            Controls.Add(Btn_Exit);
            Controls.Add(Btn_Clear);
            Controls.Add(Btn_Save);
            Controls.Add(GB_Ticket2);
            Controls.Add(Lbl_CustomerInfo);
            Controls.Add(CB_Count);
            Controls.Add(Lbl_Count);
            Controls.Add(TB_SDT);
            Controls.Add(Lbl_SDT);
            Controls.Add(TB_Name);
            Controls.Add(Lbl_Name);
            Controls.Add(Lbl_Movie);
            Controls.Add(CB_Movie);
            Controls.Add(GB_Ticket1);
            Controls.Add(Lbl_TicketInfo);
            Name = "Bai4Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 4";
            Load += Bai4Form_Load;
            GB_Ticket1.ResumeLayout(false);
            GB_Ticket1.PerformLayout();
            GB_Ticket2.ResumeLayout(false);
            GB_Ticket2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CB_Movie;
        private Label Lbl_Movie;
        private Label Lbl_Name;
        private TextBox TB_Name;
        private TextBox TB_SDT;
        private Label Lbl_SDT;
        private Label Lbl_Count;
        private ComboBox CB_Count;
        private Label Lbl_CustomerInfo;
        private Label Lbl_Seat1;
        private Label Lbl_Room1;
        private ComboBox CB_Room1;
        private Label Lbl_Seat2;
        private Label Lbl_Room2;
        private ComboBox CB_Room2;
        private GroupBox GB_Ticket1;
        private GroupBox GB_Ticket2;
        private Button Btn_Save;
        private Label Lbl_TicketType1;
        private ComboBox CB_TicketType1;
        private Label Lbl_TicketType2;
        private ComboBox CB_TicketType2;
        private CheckedListBox CLB_Seat1;
        private CheckedListBox CLB_Seat2;
        private Label Lbl_TicketInfo;
        private Button Btn_Clear;
        private Button Btn_Exit;
        private Button Btn_Export;
        private Label Lbl_Ticket_CusName;
        private Label Lbl_Ticket;
        private Label Lbl_Ticket_SDT;
        private Label Lbl_Ticket_Movie;
        private Label Lbl_Tickets;
        private Label Lbl_Ticket_Seat;
        private Label Lbl_Ticket_Cost;
    }
}