using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class MinMax : Form
    {
        public MinMax()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;
            double maxNum, minNum;

            if (txt1.Text.Trim() == "" || txt2.Text.Trim() == "" || txt3.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ 3 số thực");
                txtMax.Text = "";
                txtMin.Text = "";
            }
            else
            {

                try
                {
                    num1 = Double.Parse(txt1.Text.Trim());
                    num2 = Double.Parse(txt2.Text.Trim());
                    num3 = Double.Parse(txt3.Text.Trim());
                    maxNum = Math.Max(num1, Math.Max(num2, num3));
                    minNum = Math.Min(num1, Math.Min(num2, num3));
                    txtMax.Text = maxNum.ToString();
                    txtMin.Text = minNum.ToString();
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập số thực");
                    txtMax.Text = "";
                    txtMin.Text = "";
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txtMax.Text = "";
            txtMin.Text = "";
            txt1.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
