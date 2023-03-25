using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab1
{
    public partial class ConverHDB : Form
    {
        private Dictionary<string, int> baseNum = new Dictionary<string, int>()
        {
            {"Decimal", 10 },
            {"Hexadecimal", 16 },
            {"Binary" , 2}
        };

        public ConverHDB()
        {
            InitializeComponent();
        }

        static string ConvertBase(string number, int fromBase, int toBase)
        {
            try
            {
                string result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
                return result;
            }
            catch
            {
                switch (fromBase)
                {
                    case 2:
                        MessageBox.Show("Vui lòng nhập số nhị phân chỉ gồm các kí tự 0 và 1");
                        break;
                    case 10:
                        MessageBox.Show("Vui lòng nhập số nguyên");
                        break;
                    case 16:
                        MessageBox.Show("Vui lòng nhập số thập lục phân chỉ gồm các kí tự từ 0 -> 9, A -> F");
                        break;
                    default:
                        MessageBox.Show("Hệ cơ số không hợp lệ");
                        break;
                }
                return "Invalid input";

            }

        }

        static string DoubleConvertBase(string number, int fromBase, int toBase)
        {
            if (fromBase != 10 && toBase != 10)
            {
                return ConvertBase(number, fromBase, toBase);
            }

            if (fromBase == 10)
            {
                try
                {
                    double d = Double.Parse(number);
                    long to = BitConverter.DoubleToInt64Bits(d);
                    return Convert.ToString(to, toBase);
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập số thập phân");
                    return "";
                }

            }
            else
            {
                try
                {
                    long to = Convert.ToInt64(number, fromBase);
                    return BitConverter.Int64BitsToDouble(to).ToString("F");

                }
                catch
                {
                    if (fromBase == 2)
                    {
                        MessageBox.Show("Vui lòng nhập số nguyên dạng nhị phân gồm các kí tự 0 và 1");
                    }
                    else if (fromBase == 16)
                    {
                        MessageBox.Show("Vui lòng nhập số thập lục phân chỉ gồm các kí tự từ 0 -> 9, A -> F");
                    }
                    return "";
                }
            }

        }

        private void btnConver_Click(object sender, System.EventArgs e)
        {

            string number = txtInput.Text.Trim().ToUpper();
            string fromBase = Convert.ToString(selectFrom.SelectedItem);
            string toBase = Convert.ToString(selectTo.SelectedItem);

            string result = "";

            if (Convert.ToString(selectTypeNum.SelectedItem) == "Số nguyên")
            {
                result = ConvertBase(number, baseNum[fromBase], baseNum[toBase]);
            }
            else
            if (Convert.ToString(selectTypeNum.SelectedItem) == "Số thập phân")
            {
                result = DoubleConvertBase(number, baseNum[fromBase], baseNum[toBase]);
            }
            txtResult.Text = result;
            if (result == "Invalid input")
            {
                txtInput.Text = "";
                txtResult.Text = "";
                txtInput.Focus();
            }

        }

        private void ConverHDB_Load(object sender, EventArgs e)
        {
            selectTypeNum.SelectedItem = "Số nguyên";
            selectFrom.SelectedItem = "Decimal";
            selectTo.SelectedItem = "Binary";
        }

        private void selectTypeNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            titleTypeNum.Text = String.Concat("Chuyển đổi số ", selectTypeNum.SelectedItem).ToUpper();
            txtInput.Text = "";
            txtResult.Text = "";
            txtInput.Focus();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtResult.Text = "";
            txtInput.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
