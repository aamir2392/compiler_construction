namespace labMID_010
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            outputLabel = new Label();
            label2 = new Label();
            passwordOutput = new Label();
            generateBtn = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 71);
            label1.Name = "label1";
            label1.Size = new Size(82, 22);
            label1.TabIndex = 0;
            label1.Text = "INPUT : ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(128, 62);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(335, 42);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(158, 120);
            button1.Name = "button1";
            button1.Size = new Size(291, 51);
            button1.TabIndex = 2;
            button1.Text = "Start Parsing";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            outputLabel.ForeColor = Color.White;
            outputLabel.Location = new Point(250, 189);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(111, 31);
            outputLabel.TabIndex = 3;
            outputLabel.Text = "Output : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 239);
            label2.Name = "label2";
            label2.Size = new Size(140, 31);
            label2.TabIndex = 4;
            label2.Text = "Question 3";
            // 
            // passwordOutput
            // 
            passwordOutput.AutoSize = true;
            passwordOutput.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            passwordOutput.ForeColor = Color.White;
            passwordOutput.Location = new Point(250, 409);
            passwordOutput.Name = "passwordOutput";
            passwordOutput.Size = new Size(111, 31);
            passwordOutput.TabIndex = 7;
            passwordOutput.Text = "Output : ";
            // 
            // generateBtn
            // 
            generateBtn.BackColor = Color.Crimson;
            generateBtn.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            generateBtn.ForeColor = Color.White;
            generateBtn.Location = new Point(158, 331);
            generateBtn.Name = "generateBtn";
            generateBtn.Size = new Size(291, 51);
            generateBtn.TabIndex = 8;
            generateBtn.Text = "Generate Password";
            generateBtn.UseVisualStyleBackColor = false;
            generateBtn.Click += generateBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Crimson;
            label3.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(140, 31);
            label3.TabIndex = 9;
            label3.Text = "Question 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(380, 239);
            label4.Name = "label4";
            label4.Size = new Size(169, 31);
            label4.TabIndex = 10;
            label4.Text = "Aamir Habib";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(380, 282);
            label5.Name = "label5";
            label5.Size = new Size(189, 31);
            label5.TabIndex = 11;
            label5.Text = "FA20-BCS-010";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            ClientSize = new Size(617, 497);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(generateBtn);
            Controls.Add(passwordOutput);
            Controls.Add(label2);
            Controls.Add(outputLabel);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label outputLabel;
        private Label label2;
        private Label passwordOutput;
        private Button generateBtn;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}