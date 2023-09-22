using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void logical__operator_Click(object sender, EventArgs e)
        {
            string userInput = input_box.Text;
            string pattern = @"\s*(\|\||&&|!)\s*|\(|\)";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(userInput);

            foreach (Match match in matches)
            {
                output_box.Items.Add("Operator or Parenthesis: " + match.Value);
            }
        }

        private void relational__operator_Click(object sender, EventArgs e)
        {
            string userInput = input_box.Text;
            string pattern = @"\s*(==|!=|<=|>=|<|>)\s*";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(userInput);

            foreach (Match match in matches)
            {
                output_box.Items.Add("Relational Operators: " + match.Value);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            output_box.Items.Clear();
        }
    }
}
