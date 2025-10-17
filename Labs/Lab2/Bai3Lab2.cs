using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs.Labs.Lab2
{
    public partial class Bai3Lab2 : Form
    {
        public Bai3Lab2()
        {
            InitializeComponent();
        }

        private void Btn_ReadFile_Click(object sender, EventArgs e)
        {
            Rtb_File.Text = "";

            string filePath = @"../../../Labs/Lab2/" + Tb_InputName.Text.Trim();

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Rtb_File.AppendText(line + Environment.NewLine);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return;
            }
        }

        private void Btn_WriteFile_Click(object sender, EventArgs e)
        {
            string filePath = @"../../../Labs/Lab2/" + Tb_OutputName.Text.Trim();

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    string[] data = Rtb_File.Text.Trim().Split("\n");

                    foreach (string line in data)
                    {
                        string evaluated = EvaluateExpression(line.Trim());
                        if (!string.IsNullOrEmpty(evaluated))
                        {
                            sw.WriteLine(evaluated);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return;
            }
        }








        public static string EvaluateExpression(string input)
        {
            try
            {
                double result = Evaluate(input);
                if (double.IsInfinity(result) || double.IsNaN(result))
                    return ""; // chia cho 0 hoặc giá trị không hợp lệ

                return $"{input} = {result}";
            }
            catch
            {
                return ""; // lỗi cú pháp hoặc lỗi khác
            }
        }

        private static double Evaluate(string expr)
        {
            
            List<string> tokens = new List<string>();
            string num = "";
            foreach (char c in expr.Replace(" ", ""))
            {
                if (char.IsDigit(c) || c == '.')
                    num += c;
                else
                {
                    if (num != "")
                    {
                        tokens.Add(num);
                        num = "";
                    }
                    tokens.Add(c.ToString());
                }
            }
            if (num != "")
                tokens.Add(num);

            Stack<string> ops = new Stack<string>();
            List<string> postfix = new List<string>();
            Dictionary<string, int> prec = new Dictionary<string, int> {
            {"+", 1}, {"-", 1}, {"*", 2}, {"/", 2}
        };

            foreach (var t in tokens)
            {
                if (double.TryParse(t, out _))
                    postfix.Add(t);
                else if (t == "(")
                    ops.Push(t);
                else if (t == ")")
                {
                    while (ops.Count > 0 && ops.Peek() != "(")
                        postfix.Add(ops.Pop());
                    if (ops.Count == 0)
                        throw new Exception("Lỗi ngoặc");
                    ops.Pop();
                }
                else
                {
                    while (ops.Count > 0 && ops.Peek() != "(" && prec[ops.Peek()] >= prec[t])
                        postfix.Add(ops.Pop());
                    ops.Push(t);
                }
            }
            while (ops.Count > 0)
                postfix.Add(ops.Pop());

            Stack<double> values = new Stack<double>();
            foreach (var t in postfix)
            {
                if (double.TryParse(t, NumberStyles.Any, CultureInfo.InvariantCulture, out double val))
                    values.Push(val);
                else
                {
                    if (values.Count < 2)
                        throw new Exception("Lỗi biểu thức");

                    double b = values.Pop();
                    double a = values.Pop();

                    if (t == "/" && b == 0)
                        throw new DivideByZeroException();

                    switch (t)
                    {
                        case "+": values.Push(a + b); break;
                        case "-": values.Push(a - b); break;
                        case "*": values.Push(a * b); break;
                        case "/": values.Push(a / b); break;
                    }
                }
            }

            if (values.Count != 1)
                throw new Exception("Lỗi biểu thức");

            return values.Pop();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Rtb_File.Text = "";
            Tb_InputName.Text = "";
            Tb_OutputName.Text = "";
            Tb_InputName.Focus();
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
    }
}
