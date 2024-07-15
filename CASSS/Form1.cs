using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CASSS
{
    public partial class Form1 : Form
    {
        int score;
        double grade;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            score = Convert.ToInt32(textBox1.Text);
            if (score <= 49)
            {
                grade = 0;
            }
            else if (score <= 54)
            {
                grade = 1;
            }
            else if (score <= 59)
            {
                grade = 1.5;
            }
            else if (score <= 64)
            {
                grade = 2;
            }
            else if (score <= 69)
            {
                grade = 2.5;
            }
            else if (score <= 74)
            {
                grade = 3;
            }
            else if (score <= 79)
            {
                grade = 3.5;
            }
            else if (score <= 100)
            {
                grade = 4;
            }
            else
            {
                grade = 0;
            }
            label4.Text = "มึงได้เกรด 👉 : " + grade.ToString();
        }
    }
}
