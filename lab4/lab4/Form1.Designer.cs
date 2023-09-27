namespace lab4
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
            this.input_box = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tfInput = new System.Windows.Forms.TextBox();
            this.tfTokens = new System.Windows.Forms.RichTextBox();
            this.activity = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // input_box
            // 
            this.input_box.Location = new System.Drawing.Point(32, 35);
            this.input_box.Multiline = true;
            this.input_box.Name = "input_box";
            this.input_box.Size = new System.Drawing.Size(321, 45);
            this.input_box.TabIndex = 0;
            this.input_box.TextChanged += new System.EventHandler(this.input_box_TextChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(32, 102);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(321, 181);
            this.dataGridView.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn.Location = new System.Drawing.Point(32, 310);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(321, 51);
            this.btn.TabIndex = 2;
            this.btn.Text = "Lab Task";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input 1 :";
            // 
            // tfInput
            // 
            this.tfInput.Location = new System.Drawing.Point(406, 35);
            this.tfInput.Multiline = true;
            this.tfInput.Name = "tfInput";
            this.tfInput.Size = new System.Drawing.Size(325, 45);
            this.tfInput.TabIndex = 4;
            // 
            // tfTokens
            // 
            this.tfTokens.Location = new System.Drawing.Point(406, 102);
            this.tfTokens.Name = "tfTokens";
            this.tfTokens.Size = new System.Drawing.Size(325, 181);
            this.tfTokens.TabIndex = 5;
            this.tfTokens.Text = "";
            // 
            // activity
            // 
            this.activity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.activity.Location = new System.Drawing.Point(407, 310);
            this.activity.Name = "activity";
            this.activity.Size = new System.Drawing.Size(324, 51);
            this.activity.TabIndex = 6;
            this.activity.Text = "Lab Activity";
            this.activity.UseVisualStyleBackColor = true;
            this.activity.Click += new System.EventHandler(this.activity_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(403, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Input 2 : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 375);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.activity);
            this.Controls.Add(this.tfTokens);
            this.Controls.Add(this.tfInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.input_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_box;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tfInput;
        private System.Windows.Forms.RichTextBox tfTokens;
        private System.Windows.Forms.Button activity;
        private System.Windows.Forms.Label label2;
    }
}

