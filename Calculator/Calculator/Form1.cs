using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int num1;
        int num2;
        string operation;
        int result;

        public Form1()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            result_box.Text = result_box.Text + "0";
        }

        private void one_Click(object sender, EventArgs e)
        {
            result_box.Text = result_box.Text + "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            result_box.Text = result_box.Text + "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            result_box.Text = result_box.Text + "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            result_box.Text = result_box.Text + "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            result_box.Text = result_box.Text + "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            result_box.Text = result_box.Text + "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            result_box.Text = result_box.Text + "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            result_box.Text = result_box.Text + "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            result_box.Text = result_box.Text + "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operation = "+";
            num1 = int.Parse(result_box.Text);

            result_box.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            operation = "-";
            num1 = int.Parse(result_box.Text);

            result_box.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operation = "*";
            num1 = int.Parse(result_box.Text);

            result_box.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            operation = "/";
            num1 = int.Parse(result_box.Text);

            result_box.Clear();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(result_box.Text);

            if (operation.Equals("+"))
                result = num1 + num2;

            if (operation.Equals("-"))
                result = num1 - num2;

            if (operation.Equals("*"))
                result = num1 * num2;

            if (operation.Equals("/"))
                result = num1 / num2;

            result_box.Text = result + "";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            result_box.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(result_box.Text);
            double result_func = Math.Sin(value);
            result_box.Text = result_func.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(result_box.Text);
            double result_func = Math.Cos(value);
            result_box.Text = result_func.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(result_box.Text);
            double result_func = Math.Tan(value);
            result_box.Text = result_func.ToString();
        }
    }
}
