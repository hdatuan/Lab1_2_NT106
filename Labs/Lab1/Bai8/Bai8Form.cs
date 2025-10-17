using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs.Labs.Lab1.Bai8
{
    public partial class Bai8Form : Form
    {
        public Bai8Form()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void Btn_AddMeal_Click(object sender, EventArgs e)
        {
            string meal = Tb_AddMeal.Text.Trim();
            if (!string.IsNullOrWhiteSpace(meal))
            {
                Lb_MealList.Text += (meal) + "\n";
                Tb_AddMeal.Clear();
            }
            else
            {
                MessageBox.Show("Tên món ăn trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Btn_Result_Click(object sender, EventArgs e)
        {
            Tb_Result.Text = "";

            string mealsText = Lb_MealList.Text.Trim();

            if (string.IsNullOrEmpty(mealsText))
            {
                MessageBox.Show("Chưa có món ăn nào trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string[] meals = mealsText.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            if (meals.Length == 0)
            {
                MessageBox.Show("Danh sách món ăn trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Random rnd = new Random();
            int index = rnd.Next(meals.Length);
            string selectedMeal = meals[index].Trim();

            Tb_Result.Text = selectedMeal;
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Tb_AddMeal.Clear();
            Tb_Result.Clear();
            Lb_MealList.Text = "";
        }
    }
}
