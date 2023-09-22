using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Lab Task 1
        private void floating__points_Click(object sender, EventArgs e)
        {
            string userInput = input__box.Text;
            string pattern = @"^-?\d{1,6}(\.\d{0,6})?$";

            if (Regex.IsMatch(userInput, pattern))
            {
                input__box2.Text = "Valid floating-point number.";
            }
            else
            {
                input__box2.Text ="Invalid (Digits Should be less than 6)";
            }
        }

        // Lab Task 2
        private void task__two_Click(object sender, EventArgs e)
        {
            
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Number");

            
            string pattern = @"^[+-]?\d+(\.\d+)?[eE][+-]?\d+$";

            // Sample input data
            string[] inputNumbers = { "8e4", "5e-2", "6e9", "Not a valid number", "42" };

           
            foreach (string input in inputNumbers)
            {
                if (Regex.IsMatch(input, pattern))
                {
                    dataTable.Rows.Add(input);
                }
            }

           
            dataGridView.DataSource = dataTable;
        }

        // Lab Task 3
        private void task__three_Click(object sender, EventArgs e)
        {
           
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Matching Words");

           
            string pattern = @"\b[tmTM]\w+\b";

            
            string document = "The quick brown fox jumped over the lazy dog. " +
                              "Many tigers and monkeys live in the jungle. " +
                              "Tom and Mary went to the market.";

            
            MatchCollection matches = Regex.Matches(document, pattern);

            
            foreach (Match match in matches)
            {
                dataTable.Rows.Add(match.Value);
            }

            
            dataGridView__three.DataSource = dataTable;
        }
    }
}
