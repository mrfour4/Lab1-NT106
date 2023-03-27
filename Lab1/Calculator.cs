using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum;
            try
            {
                num1 = Int32.Parse(txt1.Text.Trim());
                num2 = Int32.Parse(txt2.Text.Trim());
                sum = Convert.ToInt64(num1) + Convert.ToInt64(num2);
                txtResult.Text = sum.ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số nguyên");
                txtResult.Text = "";
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sub = 0;
            try
            {
                num1 = Int32.Parse(txt1.Text.Trim());
                num2 = Int32.Parse(txt2.Text.Trim());
                sub = Convert.ToInt64(num1) - Convert.ToInt64(num2);
                txtResult.Text = sub.ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số nguyên");
                txtResult.Text = "";
            }
        }

        private void btnMulitiple_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long mul = 0;
            try
            {
                num1 = Int32.Parse(txt1.Text.Trim());
                num2 = Int32.Parse(txt2.Text.Trim());
                mul = Convert.ToInt64(num1) * Convert.ToInt64(num2);
                txtResult.Text = mul.ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số nguyên");
                txtResult.Text = "";
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int num1, num2;
            double divide = 0;

            try
            {
                num1 = Int32.Parse(txt1.Text.Trim());
                num2 = Int32.Parse(txt2.Text.Trim());
                if (num2 == 0)
                {
                    MessageBox.Show("Số chia phải khác 0");
                    txtResult.Text = "";
                }
                else
                {
                    divide = Convert.ToDouble(num1) / Convert.ToDouble(num2);
                    txtResult.Text = divide.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số nguyên");
                txtResult.Text = "";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txtResult.Text = "";
            txt1.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
