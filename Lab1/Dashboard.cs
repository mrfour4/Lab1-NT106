using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            Calculator form1 = new Calculator();
            form1.ShowDialog();
        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            MinMax minMax = new MinMax();
            minMax.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TranslateNumToLetter translateNumToLetter = new TranslateNumToLetter();
            translateNumToLetter.ShowDialog();
        }

        private void btnCovertHDB_Click(object sender, EventArgs e)
        {
            ConverHDB converHDB = new ConverHDB();
            converHDB.ShowDialog();
        }

        private void btnManageStudent_Click(object sender, EventArgs e)
        {
            ManageStudent student = new ManageStudent();
            student.ShowDialog();
        }
    }
}
