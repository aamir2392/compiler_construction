using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void input_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();

        }

        private void InitializeDataGridView()
        {
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.Columns.Add("Token", "Token");
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string input = input_box.Text;
            List<string> tokens = AnalyzeInput(input);
            DisplayTokens(tokens);
        }

        private List<string> AnalyzeInput(string input)
        {
            List<string> tokens = new List<string>();
            string buffer1 = "";
            string buffer2 = "";
            bool usingBuffer1 = true;

            foreach (char c in input)
            {
                if (char.IsWhiteSpace(c))
                {
                    usingBuffer1 = !usingBuffer1;
                    continue;
                }

                if (usingBuffer1)
                {
                    buffer1 += c;
                    buffer2 = ProcessBuffer(buffer1, tokens, buffer2);
                    buffer1 = "";
                }
                else
                {
                    buffer2 += c;
                    buffer1 = ProcessBuffer(buffer2, tokens, buffer1);
                    buffer2 = "";
                }
            }

            if (usingBuffer1)
            {
                ProcessBuffer(buffer1, tokens, buffer2);
            }
            else
            {
                ProcessBuffer(buffer2, tokens, buffer1);
            }

            return tokens;
        }
        private void DisplayTokens(List<string> tokens)
        {
            dataGridView.Rows.Clear();

            foreach (string token in tokens)
            {
                dataGridView.Rows.Add(token);
            }
        }
        private string ProcessBuffer(string buffer, List<string> tokens, string remainder)
        {
            string pattern = @"\b[a-zA-Z_]\w*\b|\b\d+(\.\d+)?\b";

            MatchCollection matches = Regex.Matches(buffer + remainder, pattern);

            foreach (Match match in matches)
            {
                tokens.Add(match.Value);
            }

            return "";
        }

        private void activity_Click(object sender, EventArgs e)
        {
            // Taking user input from rich textbox
            String userInput = tfInput.Text;

            // List of keywords which will be used to separate keywords from variables
            List<String> keywordList = new List<String>();
            keywordList.Add("int");
            keywordList.Add("float");
            keywordList.Add("while");
            keywordList.Add("main");
            keywordList.Add("if");
            keywordList.Add("else");
            keywordList.Add("new");

            // Row is an index counter for the symbol table
            int row = 1;

            // Count is a variable to increment variable id in tokens
            int count = 1;

            // Line_num is a counter for lines in user input
            int line_num = 0;


            String[,] SymbolTable = new String[20, 6];
            List<String> varListinSymbolTable = new List<String>();

            // Input Buffering
            ArrayList finalArray = new ArrayList();
            ArrayList finalArrayc = new ArrayList();
            ArrayList tempArray = new ArrayList();
            char[] charinput = userInput.ToCharArray();

            // Regular Expression for Variables
            Regex variable_Reg = new Regex(@"^[A-Za-z|_][A-Za-z|0-9]*$");

            // Regular Expression for Constants
            Regex constants_Reg = new Regex(@"^[0-9]+([.][0-9]+)?([e]([+|-])?[0-9]+)?$");

            // Regular Expression for Operators
            Regex operators_Reg = new Regex(@"^[-*+/><&&||=]$");

            // Regular Expression for Special_Characters
            Regex Special_Reg = new Regex(@"^[.,'\[\]{}();:?]$");

            for (int itr = 0; itr < charinput.Length; itr++)
            {
                Match Match_Variable = variable_Reg.Match(charinput[itr] + "");
                Match Match_Constant = constants_Reg.Match(charinput[itr] + "");
                Match Match_Operator = operators_Reg.Match(charinput[itr] + "");
                Match Match_Special = Special_Reg.Match(charinput[itr] + "");

                if (Match_Variable.Success || Match_Constant.Success || Match_Operator.Success || Match_Special.Success || charinput[itr].Equals(' '))
                {
                    tempArray.Add(charinput[itr]);
                }

                if (charinput[itr].Equals('\n'))
                {
                    if (tempArray.Count != 0)
                    {
                        int j = 0;
                        String fin = "";
                        for (; j < tempArray.Count; j++)
                        {
                            fin += tempArray[j];
                        }
                        finalArray.Add(fin);
                        tempArray.Clear();
                    }
                }
            }

            if (tempArray.Count != 0)
            {
                int j = 0;
                String fin = "";
                for (; j < tempArray.Count; j++)
                {
                    fin += tempArray[j];
                }
                finalArray.Add(fin);
                tempArray.Clear();
            }

            // Final Array SO far correct
            tfTokens.Clear();
            for (int i = 0; i < SymbolTable.GetLength(0); i++)
            {
                for (int j = 0; j < SymbolTable.GetLength(1); j++)
                {
                    SymbolTable[i, j] = ""; // Set each element to an empty string
                }
            }

            // Looping on all lines in user input
            for (int i = 0; i < finalArray.Count; i++)
            {
                String line = finalArray[i].ToString();
                char[] lineChar = line.ToCharArray();
                line_num++;

                // Taking the current line and splitting it into lexemes by space
                for (int itr = 0; itr < lineChar.Length; itr++)
                {
                    Match Match_Variable = variable_Reg.Match(lineChar[itr] + "");
                    Match Match_Constant = constants_Reg.Match(lineChar[itr] + "");
                    Match Match_Operator = operators_Reg.Match(lineChar[itr] + "");
                    Match Match_Special = Special_Reg.Match(lineChar[itr] + "");

                    if (Match_Variable.Success || Match_Constant.Success)
                    {
                        tempArray.Add(lineChar[itr]);
                    }

                    if (lineChar[itr].Equals(' '))
                    {
                        if (tempArray.Count != 0)
                        {
                            int j = 0;
                            String fin = "";
                            for (; j < tempArray.Count; j++)
                            {
                                fin += tempArray[j];
                            }
                            finalArrayc.Add(fin);
                            tempArray.Clear();
                        }
                    }

                    if (Match_Operator.Success || Match_Special.Success)
                    {
                        if (tempArray.Count != 0)
                        {
                            int j = 0;
                            String fin = "";
                            for (; j < tempArray.Count; j++)
                            {
                                fin += tempArray[j];
                            }
                            finalArrayc.Add(fin);
                            tempArray.Clear();
                        }
                        finalArrayc.Add(lineChar[itr]);
                    }
                }

                if (tempArray.Count != 0)
                {
                    String fina = "";
                    for (int k = 0; k < tempArray.Count; k++)
                    {
                        fina += tempArray[k];
                    }
                    finalArrayc.Add(fina);
                    tempArray.Clear();
                }

                // We have a split line here
                for (int x = 0; x < finalArrayc.Count; x++)
                {
                    Match operators = operators_Reg.Match(finalArrayc[x].ToString());
                    Match variables = variable_Reg.Match(finalArrayc[x].ToString());
                    Match digits = constants_Reg.Match(finalArrayc[x].ToString());
                    Match punctuations = Special_Reg.Match(finalArrayc[x].ToString());

                    if (operators.Success)
                    {
                        // If a current lexeme is an operator then make a token e.g. <op, = >
                        tfTokens.AppendText("<op, " + finalArrayc[x].ToString() + "> ");
                    }
                    else if (digits.Success)
                    {
                        // If a current lexeme is a digit then make a token e.g. <digit, 12.33 >
                        tfTokens.AppendText("<digit, " + finalArrayc[x].ToString() + "> ");
                    }
                    else if (punctuations.Success)
                    {
                        // If a current lexeme is a punctuation then make a token e.g. <punc, ; >
                        tfTokens.AppendText("<punc, " + finalArrayc[x].ToString() + "> ");
                    }
                    else if (variables.Success)
                    {
                        // If a current lexeme is a variable and not a keyword
                        if (!keywordList.Contains(finalArrayc[x].ToString())) // If it is not a keyword
                        {
                            // Check what is the category of the variable, handling only two cases here
                            // Category1- Variable initialization of type digit e.g. int count = 10 ;
                            // Category2- Variable initialization of type String e.g. String var = ' Hello ' ;
                            Regex reg1 = new Regex(@"^(int|String|float|double)\s([A-Za-z|_][A-Za-z|0-9]{0,10})\s(=)\s([0-9]+([.][0-9]+)?([e][+|-]?[0-9]+)?)\s(;)$"); // Line of type int alpha = 2 ;
                            Match category1 = reg1.Match(line);
                            Regex reg2 = new Regex(@"^(String|char)\s([A-Za-z|][A-Za-z|0-9]{0,10})\s(=)\s[']\s([A-Za-z|][A-Za-z|0-9]{0,30})\s[']\s(;)$"); // Line of type String alpha = ' Hello ' ;
                            Match category2 = reg2.Match(line);

                            // If it is a category 1 then add a row in the symbol table containing the information related to that variable
                            if (category1.Success)
                            {
                                SymbolTable[row, 1] = row.ToString(); // Index
                                SymbolTable[row, 2] = finalArrayc[x].ToString(); // Variable name
                                SymbolTable[row, 3] = finalArrayc[x - 1].ToString(); // Type
                                SymbolTable[row, 4] = finalArrayc[x + 2].ToString(); // Value
                                SymbolTable[row, 5] = line_num.ToString(); // Line number
                                tfTokens.AppendText("<var" + count + ", " + row + "> ");

                                tfTokens.AppendText(SymbolTable[row, 1].ToString() + " \t ");
                                tfTokens.AppendText(SymbolTable[row, 2].ToString() + " \t ");
                                tfTokens.AppendText(SymbolTable[row, 3].ToString() + " \t ");
                                tfTokens.AppendText(SymbolTable[row, 4].ToString() + " \t ");
                                tfTokens.AppendText(SymbolTable[row, 5].ToString() + " \n ");
                                row++;
                                count++;
                            }
                            // If it is a category 2 then add a row in the symbol table containing the information related to that variable
                            else if (category2.Success)
                            {
                                // If a line such as String var = ' Hello ' ; comes and the loop moves to the index of the array containing Hello,
                                // then this if condition prevents addition of Hello in symbol Table because it is not a variable, it is just a string
                                if (!(finalArrayc[x - 1].ToString().Equals("'") && finalArrayc[x + 1].ToString().Equals("'")))
                                {
                                    SymbolTable[row, 1] = row.ToString(); // Index
                                    SymbolTable[row, 2] = finalArrayc[x].ToString(); // Varname
                                    SymbolTable[row, 3] = finalArrayc[x - 1].ToString(); // Type
                                    SymbolTable[row, 4] = finalArrayc[x + 3].ToString(); // Value
                                    SymbolTable[row, 5] = line_num.ToString(); // Line number
                                    tfTokens.AppendText("<var" + count + ", " + row + "> ");

                                    tfTokens.AppendText(SymbolTable[row, 1].ToString() + " \t ");
                                    tfTokens.AppendText(SymbolTable[row, 2].ToString() + " \t ");
                                    tfTokens.AppendText(SymbolTable[row, 3].ToString() + " \t ");
                                    tfTokens.AppendText(SymbolTable[row, 4].ToString() + " \t ");
                                    tfTokens.AppendText(SymbolTable[row, 5].ToString() + " \n ");
                                    row++;
                                    count++;
                                }
                                else
                                {
                                    tfTokens.AppendText("<String" + count + ", " + finalArrayc[x].ToString() + "> ");
                                }
                            }
                            else
                            {
                                // If any other category line comes in, we check if we have initialized that variable before.
                                // If we have initialized it before, then we put the index of that variable in the symbol table in its token.
                                String ind = "Default";
                                String ty = "Default";
                                String val = "Default";
                                String lin = "Default";


                            }
                        }
                        // If a current lexeme is not a variable but a keyword, then make a token such as: <keyword, int>
                        else
                        {
                            tfTokens.AppendText("<keyword, " + finalArrayc[x].ToString() + "> ");
                        }
                    }
                }
                tfTokens.AppendText("\n");
                finalArrayc.Clear();
            }
        }
    }
}
