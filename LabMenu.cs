using Labs;
using Labs.Labs.Lab1;
using Labs.Labs.Lab2;

namespace Labs
{
    public partial class LabMenu : Form
    {
        public LabMenu()
        {
            InitializeComponent();
        }

        private void Btn_Lab1_Click(object sender, EventArgs e)
        {
            Lab1 lab1 = new Lab1();
            this.Hide();
            lab1.FormClosed += (s, args) => this.Show();
            lab1.Show();
        }

        private void LabMenu_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Lab2_Click(object sender, EventArgs e)
        {
            Lab2 lab2 = new Lab2();
            this.Hide();
            lab2.FormClosed += (s, args) => this.Show();
            lab2.Show();
        }
    }
}
