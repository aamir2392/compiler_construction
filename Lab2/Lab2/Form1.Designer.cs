namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.input_box = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.output_box = new System.Windows.Forms.ListBox();
            this.logical__operator = new System.Windows.Forms.Button();
            this.relational__operator = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_box
            // 
            this.input_box.Location = new System.Drawing.Point(39, 32);
            this.input_box.Multiline = true;
            this.input_box.Name = "input_box";
            this.input_box.Size = new System.Drawing.Size(490, 67);
            this.input_box.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // output_box
            // 
            this.output_box.FormattingEnabled = true;
            this.output_box.ItemHeight = 20;
            this.output_box.Location = new System.Drawing.Point(39, 115);
            this.output_box.Name = "output_box";
            this.output_box.Size = new System.Drawing.Size(490, 164);
            this.output_box.TabIndex = 2;
            // 
            // logical__operator
            // 
            this.logical__operator.Location = new System.Drawing.Point(39, 295);
            this.logical__operator.Name = "logical__operator";
            this.logical__operator.Size = new System.Drawing.Size(490, 53);
            this.logical__operator.TabIndex = 3;
            this.logical__operator.Text = "Logical Operator";
            this.logical__operator.UseVisualStyleBackColor = true;
            this.logical__operator.Click += new System.EventHandler(this.logical__operator_Click);
            // 
            // relational__operator
            // 
            this.relational__operator.Location = new System.Drawing.Point(39, 354);
            this.relational__operator.Name = "relational__operator";
            this.relational__operator.Size = new System.Drawing.Size(490, 53);
            this.relational__operator.TabIndex = 4;
            this.relational__operator.Text = "Relational Operator";
            this.relational__operator.UseVisualStyleBackColor = true;
            this.relational__operator.Click += new System.EventHandler(this.relational__operator_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(39, 413);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(490, 53);
            this.clear.TabIndex = 5;
            this.clear.Text = "Clear Output";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 518);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.relational__operator);
            this.Controls.Add(this.logical__operator);
            this.Controls.Add(this.output_box);
            this.Controls.Add(this.input_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_box;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox output_box;
        private System.Windows.Forms.Button logical__operator;
        private System.Windows.Forms.Button relational__operator;
        private System.Windows.Forms.Button clear;
    }
}

