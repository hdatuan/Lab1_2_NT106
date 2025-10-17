using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs.Labs.Lab1.Bai4
{
    public partial class Bai4Form : Form
    {

        public String Movie = "";
        public int indexMovie = -1;
        int[] price = { 45000, 100000, 70000, 90000 };
        int totalPrice = 0;



        public Bai4Form()
        {
            InitializeComponent();
            GB_Ticket1.Enabled = false;
            GB_Ticket2.Enabled = false;
            CB_Count.Enabled = false;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_Count.Items.Clear();
            if (!String.IsNullOrEmpty(CB_Movie.Text))
            {
                Movie = CB_Movie.Text;
                CB_Count.Enabled = true;
                CB_Count.Text = "";

                CB_Room1.Items.Clear();
                CB_Room2.Items.Clear();
                if (Movie == "Đào, phở và piano")
                {
                    CB_Count.Items.AddRange(new object[] { 1, 2 });
                    CB_Room1.Items.AddRange(new object[] { 1, 2, 3 });
                    CB_Room2.Items.AddRange(new object[] { 1, 2, 3 });
                    indexMovie = 0;
                }
                else if (Movie == "Mai")
                {
                    CB_Count.Items.AddRange(new object[] { 1, 2 });
                    CB_Room1.Items.AddRange(new object[] { 2, 3 });
                    CB_Room2.Items.AddRange(new object[] { 2, 3 });
                    indexMovie = 1;
                }
                else if (Movie == "Gặp lại chị bầu")
                {
                    CB_Count.Items.AddRange(new object[] { 1 });
                    CB_Room1.Items.AddRange(new object[] { 1 });
                    CB_Room2.Items.AddRange(new object[] { 1 });
                    indexMovie = 2;
                }
                else if (Movie == "Tarot")
                {
                    CB_Count.Items.AddRange(new object[] { 1 });
                    CB_Room1.Items.AddRange(new object[] { 3 });
                    CB_Room2.Items.AddRange(new object[] { 3 });
                    indexMovie = 3;
                }
                else
                {
                    CB_Room1.Items.Clear();
                    CB_Room2.Items.Clear();
                    indexMovie = -1;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CB_Count_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Count.Text == "2")
            {
                GB_Ticket2.Enabled = true;
                GB_Ticket1.Enabled = true;
            }
            else if (CB_Count.Text == "1")
            {
                GB_Ticket1.Enabled = true;
                GB_Ticket2.Enabled = false;
            }
            else
            {
                GB_Ticket2.Enabled = false;
                GB_Ticket1.Enabled = false;
            }


        }

        private void CB_Room1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CB_TicketType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(CB_TicketType1.Text))
            {
                CLB_Seat1.Items.Clear();
                string ticketType = CB_TicketType1.Text;

                if (ticketType == "Thường")
                {
                    CLB_Seat1.Items.AddRange(new object[] { "A2", "A3", "A4", "C2", "C3", "C4" });
                }
                else if (ticketType == "Vớt")
                {
                    CLB_Seat1.Items.AddRange(new object[] { "A1", "A5", "C1", "C5" });
                }
                else if (ticketType == "VIP")
                {
                    CLB_Seat1.Items.AddRange(new object[] { "B2", "B3", "B4" });
                }
                else
                {
                    CLB_Seat1.Items.Clear();
                }
            }
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CB_TicketType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(CB_TicketType2.Text))
            {
                CLB_Seat2.Items.Clear();
                string ticketType = CB_TicketType2.Text;

                if (ticketType == "Thường")
                {
                    CLB_Seat2.Items.AddRange(new object[] { "A2", "A3", "A4", "C2", "C3", "C4" });
                }
                else if (ticketType == "Vớt")
                {
                    CLB_Seat2.Items.AddRange(new object[] { "A1", "A5", "C1", "C5" });
                }
                else if (ticketType == "VIP")
                {
                    CLB_Seat2.Items.AddRange(new object[] { "B2", "B3", "B4" });
                }
                else
                {
                    CLB_Seat2.Items.Clear();
                }
            }
        }

        private void GB_Ticket2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Lbl_Ticket_CusName.Text = "Tên khách hàng: ";
            Lbl_Ticket_SDT.Text = "Số điện thoại: ";
            Lbl_Ticket_Movie.Text = "Phim: ";
            Lbl_Tickets.Text = "Tổng số vé: ";
            Lbl_Ticket_Cost.Text = "Tổng tiền: ";
            Lbl_Ticket_Seat.Text = "Ghế: ";
            totalPrice = 0;

            // Kiểm tra trùng ghế giữa Seat1 và Seat2
            if (CB_Count.Text == "2") // chỉ kiểm tra nếu có phòng 2
            {
                
                if ( CB_Room1.Text == CB_Room2.Text)
                {
                    MessageBox.Show("Không thể chọn 2 phòng giống nhau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // dừng Save, bắt user chọn lại
                }
                 
            }



            if (String.IsNullOrEmpty(TB_Name.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[a-zA-ZÀ-ỹ\\s]+$");
            if (!regex.IsMatch(TB_Name.Text))
            {
                MessageBox.Show("Tên khách hàng chỉ được chứa chữ cái và khoảng trắng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(TB_SDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TB_SDT.Text.Length != 10 || !TB_SDT.Text.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(CB_Movie.Text))
            {
                MessageBox.Show("Vui lòng chọn phim!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(CB_Count.Text))
            {
                MessageBox.Show("Vui lòng chọn số lượng phòng chiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(CB_Room1.Text))
            {
                MessageBox.Show("Vui lòng chọn phòng cho phòng chiếu thứ nhất!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(CB_TicketType1.Text))
            {
                MessageBox.Show("Vui lòng chọn loại vé cho phòng chiếu thứ nhất!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CLB_Seat1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ghế cho phòng chiếu thứ nhất!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CB_Count.Text == "2")
            {
                if (String.IsNullOrEmpty(CB_Room2.Text))
                {
                    MessageBox.Show("Vui lòng chọn phòng cho phòng chiếu thứ hai!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (String.IsNullOrEmpty(CB_TicketType2.Text))
                {
                    MessageBox.Show("Vui lòng chọn loại vé cho phòng chiếu thứ hai!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (CLB_Seat2.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ghế cho phòng chiếu thứ hai!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (CLB_Seat1.CheckedItems.Count + CLB_Seat2.CheckedItems.Count > 2)
                {
                    MessageBox.Show("Tổng số ghế ở 2 phòng khác nhau được vượt quá 2!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Lbl_Ticket_CusName.Text += TB_Name.Text;
            Lbl_Ticket_CusName.Visible = true;

            Lbl_Ticket_SDT.Text += TB_SDT.Text;
            Lbl_Ticket_SDT.Visible = true;

            Lbl_Ticket_Movie.Text += CB_Movie.Text;
            Lbl_Ticket_Movie.Visible = true;

            Lbl_Tickets.Text += CLB_Seat1.CheckedItems.Count + CLB_Seat2.CheckedItems.Count;
            Lbl_Tickets.Visible = true;

            if (CB_TicketType1.Text == "Thường")
            {
                totalPrice += price[indexMovie] * CLB_Seat1.CheckedItems.Count;
            }
            else if (CB_TicketType1.Text == "Vớt")
            {
                totalPrice += (int)(price[indexMovie] * 0.25) * CLB_Seat1.CheckedItems.Count;
            }
            else if (CB_TicketType1.Text == "VIP")
            {
                totalPrice += price[indexMovie] * 2 * CLB_Seat1.CheckedItems.Count;
            }

            if (CB_Count.Text == "2")
            {
                if (CB_TicketType2.Text == "Thường")
                {
                    totalPrice += price[indexMovie] * CLB_Seat2.CheckedItems.Count;
                }
                else if (CB_TicketType2.Text == "Vớt")
                {
                    totalPrice += (int)(price[indexMovie] * 0.25) * CLB_Seat2.CheckedItems.Count;
                }
                else if (CB_TicketType2.Text == "VIP")
                {
                    totalPrice += price[indexMovie] * 2 * CLB_Seat2.CheckedItems.Count;
                }
            }
            Lbl_Ticket_Cost.Text += totalPrice.ToString("N0") + " VND";
            Lbl_Ticket_Cost.Visible = true;

            foreach (var item in CLB_Seat1.CheckedItems)
            {
                Lbl_Ticket_Seat.Text += item.ToString() + " ";
            }
            Lbl_Ticket_Seat.Text += " (Phòng chiếu " + CB_Room1.Text + ") ";

            if (CB_Count.Text == "2")
            {
                foreach (var item in CLB_Seat2.CheckedItems)
                {
                    Lbl_Ticket_Seat.Text += item.ToString() + " ";
                }
                Lbl_Ticket_Seat.Text += " (Phòng chiếu " + CB_Room2.Text + ") ";
            }
            Lbl_Ticket_Seat.Visible = true;


        }

        private void CLB_Seat1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Bai4Form_Load(object sender, EventArgs e)
        {



        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            TB_Name.Clear();
            TB_SDT.Clear();

            // Reset các combobox
            CB_Movie.SelectedIndex = -1;
            CB_Count.SelectedIndex = -1;
            CB_Room1.Items.Clear();
            CB_Room2.Items.Clear();
            CB_TicketType1.SelectedIndex = -1;
            CB_TicketType2.SelectedIndex = -1;

            // Reset các group box
            GB_Ticket1.Enabled = false;
            GB_Ticket2.Enabled = false;
            CB_Count.Enabled = false;

            // Reset ghế
            CLB_Seat1.Items.Clear();
            CLB_Seat2.Items.Clear();

            // Ẩn label kết quả
            Lbl_Ticket_CusName.Visible = false;
            Lbl_Ticket_SDT.Visible = false;
            Lbl_Ticket_Movie.Visible = false;
            Lbl_Tickets.Visible = false;
            Lbl_Ticket_Cost.Visible = false;
            Lbl_Ticket_Seat.Visible = false;

            // Reset biến tính toán
            totalPrice = 0;
            indexMovie = -1;
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?",
                                          "Xác nhận thoát",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Btn_Export_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thành công", "Xuất vé", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
