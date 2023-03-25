using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class TranslateNumToLetter : Form
    {
        public TranslateNumToLetter()
        {
            InitializeComponent();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtInput.Text = string.Empty;
            txtResult.Text = string.Empty;
            txtInput.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static string[] numChar = new string[10] { "không ","một ","hai ","ba ","bốn ","năm ",
"sáu ", "bảy ", "tám ","chín " };

        const int maxL = 10;
        static int[] c = new int[maxL + 2];

        //1.234.567.890
        static string getChar(int index)
        {
            if (index == maxL) return "";
            switch (index)
            {
                case 1:
                    return "tỉ ";
                    break;
                case 4:
                    if (!((c[index] == 0) && (c[index - 1] == 0) && (c[index - 2] == 0)))
                        return "triệu ";
                    break;
                case 7:
                    if (!((c[index] == 0) && (c[index - 1] == 0) && (c[index - 2] == 0)))
                        return "nghìn ";
                    break;
                case 2:
                case 5:
                case 8:
                    if (!(((c[index + 2] == 0) && (c[index + 1] == 0)) && (c[index] == 0)))
                        return "trăm ";
                    break;


                case 3:
                case 6:
                case 9:
                    if (c[index] != 0)
                    {
                        if (c[index] == 1)
                        {
                            return "mười ";
                        }
                        else return "mươi ";
                    }
                    else
                    {
                        if (c[index + 1] != 0)
                            return "lẻ ";
                    }
                    break;
            }

            return "";
        }

        static void numToArray(int n)
        {
            int i;
            for (i = 1; i <= maxL; i++)
                c[i] = 0;
            i = maxL;
            while (n != 0)
            {
                c[i] = n % 10;
                n = n / 10;
                i--;
            }
        }

        static string readNumber(int n)
        {
            string result = "";
            if (n < 0) result = "âm ";
            n = Math.Abs(n);
            numToArray(n);
            int index = maxL + 1, i;
            for (i = 1; i <= maxL; i++)
                if (c[i] != 0)
                {
                    index = i;
                    break;
                }
            if (index == (maxL + 1))
            {
                return "không";
            }
            for (i = index; i <= maxL; i++)
            {
                //1.234.567.890
                switch (c[i])
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        if (!((c[i] == 1) && ((i == 6) || (i == 3) || (i == 9))))
                            result += numChar[c[i]];
                        result += getChar(i);
                        break;
                    case 5:
                        if (i == 10)
                        {
                            if (c[i - 1] == 0)
                                result += "năm ";
                            else
                                result += "lăm ";
                        }
                        else
                        {
                            if (i == 4 || i == 7)
                            {
                                if (c[i - 1] == 0)
                                    result += "năm ";
                                else
                                    result += "lăm ";
                            }
                            else
                                result += numChar[c[i]];
                            result += getChar(i);
                        }
                        break;
                    case 0:
                        if (((i == 8) || (i == 5) || (i == 2)) && ((c[i + 2] != 0) || ((c[i + 1] != 0))))
                            result += numChar[c[i]];
                        result += getChar(i);
                        break;
                }
            }

            return result;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Int32.Parse(txtInput.Text.Trim());
                string result = readNumber(num);
                txtResult.Text = result;
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số tự nhiên");
            }
        }
    }
}
