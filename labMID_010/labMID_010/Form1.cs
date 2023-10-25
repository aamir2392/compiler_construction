using System;
using System.Text;
using System.Windows.Forms;
using labMID_010; // Adjust the namespace if needed

namespace labMID_010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            LL1Parser parser = new LL1Parser(input);
            parser.Parse();
            if (parser.currentPosition == input.Length)
            {
                outputLabel.Text = "The input is valid.";
            }
            else
            {
                outputLabel.Text = "The input is invalid.";
            }
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            string password = GeneratePassword();
            passwordOutput.Text = password;
        }
        private string GeneratePassword()
        {
            Random random = new Random();
            StringBuilder password = new StringBuilder();

            // Rule (d): Must contain initials of first and last name, which are A and H
            password.Append("AH");

            // Rule (a): At least one uppercase alphabet
            char uppercaseChar = (char)random.Next('A', 'Z' + 1);
            password.Append(uppercaseChar);

            // Rule (b): At least 4 numbers, two numbers must be 1 and 0
            int[] requiredNumbers = { 1, 0 };
            int[] otherNumbers = { 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < 2; i++)
            {
                int num = requiredNumbers[i];
                password.Append(num);
            }
            for (int i = 0; i < 2; i++)
            {
                int num = otherNumbers[random.Next(otherNumbers.Length)];
                password.Append(num);
            }

            // Rule (c): At least 2 special characters
            string specialChars = "!@#$%^&*()_+";
            for (int i = 0; i < 2; i++)
            {
                char specialChar = specialChars[random.Next(specialChars.Length)];
                password.Append(specialChar);
            }

            // Shuffle the characters in the password for better randomness
            string shuffledPassword = new string(password.ToString().ToCharArray().OrderBy(x => random.Next()).ToArray());

            // Ensure the password length does not exceed 16 characters
            return shuffledPassword.Length <= 16 ? shuffledPassword : shuffledPassword.Substring(0, 16);
        }
    }
}
