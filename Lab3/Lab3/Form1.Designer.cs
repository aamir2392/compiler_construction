namespace Lab3
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
            this.input__box = new System.Windows.Forms.TextBox();
            this.floating__points = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.task__two = new System.Windows.Forms.Button();
            this.task__three = new System.Windows.Forms.Button();
            this.dataGridView__three = new System.Windows.Forms.DataGridView();
            this.input__box2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView__three)).BeginInit();
            this.SuspendLayout();
            // 
            // input__box
            // 
            this.input__box.Location = new System.Drawing.Point(29, 44);
            this.input__box.Multiline = true;
            this.input__box.Name = "input__box";
            this.input__box.Size = new System.Drawing.Size(443, 61);
            this.input__box.TabIndex = 0;
            // 
            // floating__points
            // 
            this.floating__points.Location = new System.Drawing.Point(29, 124);
            this.floating__points.Name = "floating__points";
            this.floating__points.Size = new System.Drawing.Size(443, 53);
            this.floating__points.TabIndex = 1;
            this.floating__points.Text = "Floating Points (Task 1)";
            this.floating__points.UseVisualStyleBackColor = true;
            this.floating__points.Click += new System.EventHandler(this.floating__points_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(33, 217);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(439, 229);
            this.dataGridView.TabIndex = 2;
            // 
            // task__two
            // 
            this.task__two.Location = new System.Drawing.Point(29, 467);
            this.task__two.Name = "task__two";
            this.task__two.Size = new System.Drawing.Size(443, 53);
            this.task__two.TabIndex = 3;
            this.task__two.Text = "Lab Task 2";
            this.task__two.UseVisualStyleBackColor = true;
            this.task__two.Click += new System.EventHandler(this.task__two_Click);
            // 
            // task__three
            // 
            this.task__three.Location = new System.Drawing.Point(532, 467);
            this.task__three.Name = "task__three";
            this.task__three.Size = new System.Drawing.Size(443, 53);
            this.task__three.TabIndex = 5;
            this.task__three.Text = "Lab Task 3";
            this.task__three.UseVisualStyleBackColor = true;
            this.task__three.Click += new System.EventHandler(this.task__three_Click);
            // 
            // dataGridView__three
            // 
            this.dataGridView__three.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView__three.Location = new System.Drawing.Point(536, 217);
            this.dataGridView__three.Name = "dataGridView__three";
            this.dataGridView__three.RowHeadersWidth = 62;
            this.dataGridView__three.RowTemplate.Height = 28;
            this.dataGridView__three.Size = new System.Drawing.Size(439, 229);
            this.dataGridView__three.TabIndex = 4;
            // 
            // input__box2
            // 
            this.input__box2.Location = new System.Drawing.Point(532, 44);
            this.input__box2.Multiline = true;
            this.input__box2.Name = "input__box2";
            this.input__box2.Size = new System.Drawing.Size(443, 61);
            this.input__box2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 568);
            this.Controls.Add(this.input__box2);
            this.Controls.Add(this.task__three);
            this.Controls.Add(this.dataGridView__three);
            this.Controls.Add(this.task__two);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.floating__points);
            this.Controls.Add(this.input__box);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView__three)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input__box;
        private System.Windows.Forms.Button floating__points;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button task__two;
        private System.Windows.Forms.Button task__three;
        private System.Windows.Forms.DataGridView dataGridView__three;
        private System.Windows.Forms.TextBox input__box2;
    }
}

