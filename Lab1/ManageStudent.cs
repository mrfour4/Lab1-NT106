using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab1
{
    public partial class ManageStudent : Form
    {
        public ManageStudent()
        {
            InitializeComponent();
        }

        static string FormatScore(double score)
        {
            return String.Format("{0:0.##}", score);
        }
        private void btn_Click(object sender, System.EventArgs e)
        {
            txtLayout.Controls.Clear();
            txtInput.Text = Regex.Replace(txtInput.Text, " {2,}", " ");
            string[] scores = txtInput.Text.Trim().Split(' ');
            try
            {
                double[] num = new double[scores.Length];
                for (int i = 0; i < scores.Length; i++)
                {

                    bool isSuccess = Double.TryParse(scores[i], out num[i]);
                    if (!isSuccess || num[i] < 0 || num[i] > 10)
                    {
                        MessageBox.Show("Vui lòng nhập điểm là số thực từ 0 đến 10");
                        return;
                    }
                }

                double avgScore, minScore, maxScore, cntPass, cntUnpass;
                avgScore = cntPass = cntUnpass = 0;
                minScore = 11;
                maxScore = -1;

                string ranked = "";



                for (int i = 0; i < num.Length; i++)
                {
                    Label subject = new Label();
                    string score = FormatScore(num[i]);
                    subject.Text = $"Môn {i + 1}: {score} đ";
                    subject.Width = 120;
                    txtLayout.Controls.Add(subject);

                    avgScore += num[i];
                    minScore = Math.Min(minScore, num[i]);
                    maxScore = Math.Max(maxScore, num[i]);



                    if (num[i] < 5)
                    {
                        cntUnpass++;
                    }
                    else cntPass++;
                }

                avgScore = avgScore / num.Length;

                if (avgScore >= 8 && minScore >= 6.5) ranked = "Giỏi";
                else if (avgScore >= 6.5 && minScore >= 5) ranked = "Khá";
                else if (avgScore >= 5 && minScore >= 3.5) ranked = "TB";
                else if (avgScore >= 3.5 && minScore >= 2) ranked = "Yếu";
                else ranked = "Kém";

                txtAvg.Text = FormatScore(avgScore);
                txtRanked.Text = ranked;
                txtMaxScore.Text = FormatScore(maxScore);
                txtMinScore.Text = FormatScore(minScore);
                txtPass.Text = cntPass.ToString();
                txtUnpass.Text = cntUnpass.ToString();

            }
            catch
            {
                MessageBox.Show("Nhập sai định dạng!. Các phần tử điểm cách nhau bởi một khoảng trắng ");
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtLayout.Controls.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageStudent_Load(object sender, EventArgs e)
        {
            txtAvg.Text = txtRanked.Text = txtMaxScore.Text = txtMinScore.Text = txtPass.Text = txtUnpass.Text = "";
        }
    }
}
