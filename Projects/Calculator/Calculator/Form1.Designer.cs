namespace Calculator
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
            this.input = new System.Windows.Forms.TextBox();
            this.no1 = new System.Windows.Forms.Button();
            this.no2 = new System.Windows.Forms.Button();
            this.no3 = new System.Windows.Forms.Button();
            this.no6 = new System.Windows.Forms.Button();
            this.no5 = new System.Windows.Forms.Button();
            this.no4 = new System.Windows.Forms.Button();
            this.no9 = new System.Windows.Forms.Button();
            this.no8 = new System.Windows.Forms.Button();
            this.no7 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.no0 = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(6, 13);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(267, 20);
            this.input.TabIndex = 0;
            // 
            // no1
            // 
            this.no1.Location = new System.Drawing.Point(21, 40);
            this.no1.Name = "no1";
            this.no1.Size = new System.Drawing.Size(75, 23);
            this.no1.TabIndex = 1;
            this.no1.Text = "1";
            this.no1.UseVisualStyleBackColor = true;
            this.no1.Click += new System.EventHandler(this.clicked);
            // 
            // no2
            // 
            this.no2.Location = new System.Drawing.Point(101, 40);
            this.no2.Name = "no2";
            this.no2.Size = new System.Drawing.Size(75, 23);
            this.no2.TabIndex = 2;
            this.no2.Text = "2";
            this.no2.UseVisualStyleBackColor = true;
            this.no2.Click += new System.EventHandler(this.clicked);
            // 
            // no3
            // 
            this.no3.Location = new System.Drawing.Point(182, 40);
            this.no3.Name = "no3";
            this.no3.Size = new System.Drawing.Size(75, 23);
            this.no3.TabIndex = 3;
            this.no3.Text = "3";
            this.no3.UseVisualStyleBackColor = true;
            this.no3.Click += new System.EventHandler(this.clicked);
            // 
            // no6
            // 
            this.no6.Location = new System.Drawing.Point(182, 82);
            this.no6.Name = "no6";
            this.no6.Size = new System.Drawing.Size(75, 23);
            this.no6.TabIndex = 6;
            this.no6.Text = "6";
            this.no6.UseVisualStyleBackColor = true;
            this.no6.Click += new System.EventHandler(this.clicked);
            // 
            // no5
            // 
            this.no5.Location = new System.Drawing.Point(101, 82);
            this.no5.Name = "no5";
            this.no5.Size = new System.Drawing.Size(75, 23);
            this.no5.TabIndex = 5;
            this.no5.Text = "5";
            this.no5.UseVisualStyleBackColor = true;
            this.no5.Click += new System.EventHandler(this.clicked);
            // 
            // no4
            // 
            this.no4.Location = new System.Drawing.Point(21, 82);
            this.no4.Name = "no4";
            this.no4.Size = new System.Drawing.Size(75, 23);
            this.no4.TabIndex = 4;
            this.no4.Text = "4";
            this.no4.UseVisualStyleBackColor = true;
            this.no4.Click += new System.EventHandler(this.clicked);
            // 
            // no9
            // 
            this.no9.Location = new System.Drawing.Point(182, 121);
            this.no9.Name = "no9";
            this.no9.Size = new System.Drawing.Size(75, 23);
            this.no9.TabIndex = 9;
            this.no9.Text = "9";
            this.no9.UseVisualStyleBackColor = true;
            this.no9.Click += new System.EventHandler(this.clicked);
            // 
            // no8
            // 
            this.no8.Location = new System.Drawing.Point(101, 121);
            this.no8.Name = "no8";
            this.no8.Size = new System.Drawing.Size(75, 23);
            this.no8.TabIndex = 8;
            this.no8.Text = "8";
            this.no8.UseVisualStyleBackColor = true;
            this.no8.Click += new System.EventHandler(this.clicked);
            // 
            // no7
            // 
            this.no7.Location = new System.Drawing.Point(21, 121);
            this.no7.Name = "no7";
            this.no7.Size = new System.Drawing.Size(75, 23);
            this.no7.TabIndex = 7;
            this.no7.Text = "7";
            this.no7.UseVisualStyleBackColor = true;
            this.no7.Click += new System.EventHandler(this.clicked);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(182, 165);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 12;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.clickOperation);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(101, 165);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(75, 23);
            this.equals.TabIndex = 11;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // no0
            // 
            this.no0.Location = new System.Drawing.Point(21, 165);
            this.no0.Name = "no0";
            this.no0.Size = new System.Drawing.Size(75, 23);
            this.no0.TabIndex = 10;
            this.no0.Text = "0";
            this.no0.UseVisualStyleBackColor = true;
            this.no0.Click += new System.EventHandler(this.clicked);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(182, 206);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(75, 23);
            this.divide.TabIndex = 15;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.clickOperation);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(101, 206);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 23);
            this.multiply.TabIndex = 14;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.clickOperation);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(21, 206);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 23);
            this.minus.TabIndex = 13;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.clickOperation);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(21, 246);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(236, 23);
            this.clear.TabIndex = 16;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.add);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.no0);
            this.Controls.Add(this.no9);
            this.Controls.Add(this.no8);
            this.Controls.Add(this.no7);
            this.Controls.Add(this.no6);
            this.Controls.Add(this.no5);
            this.Controls.Add(this.no4);
            this.Controls.Add(this.no3);
            this.Controls.Add(this.no2);
            this.Controls.Add(this.no1);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button no1;
        private System.Windows.Forms.Button no2;
        private System.Windows.Forms.Button no3;
        private System.Windows.Forms.Button no6;
        private System.Windows.Forms.Button no5;
        private System.Windows.Forms.Button no4;
        private System.Windows.Forms.Button no9;
        private System.Windows.Forms.Button no8;
        private System.Windows.Forms.Button no7;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button no0;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button clear;
    }
}

