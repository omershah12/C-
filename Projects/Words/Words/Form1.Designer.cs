namespace Words
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.RadioButton();
            this.upper = new System.Windows.Forms.RadioButton();
            this.lower = new System.Windows.Forms.RadioButton();
            this.digits = new System.Windows.Forms.RadioButton();
            this.special = new System.Windows.Forms.RadioButton();
            this.click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(30, 22);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(193, 20);
            this.input.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(30, 207);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 20);
            this.textBox2.TabIndex = 1;
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(46, 48);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(87, 17);
            this.count.TabIndex = 2;
            this.count.TabStop = true;
            this.count.Text = "Count Words";
            this.count.UseVisualStyleBackColor = true;
            // 
            // upper
            // 
            this.upper.AutoSize = true;
            this.upper.Location = new System.Drawing.Point(46, 71);
            this.upper.Name = "upper";
            this.upper.Size = new System.Drawing.Size(89, 17);
            this.upper.TabIndex = 3;
            this.upper.TabStop = true;
            this.upper.Text = "Upper Letters";
            this.upper.UseVisualStyleBackColor = true;
            // 
            // lower
            // 
            this.lower.AutoSize = true;
            this.lower.Location = new System.Drawing.Point(46, 94);
            this.lower.Name = "lower";
            this.lower.Size = new System.Drawing.Size(89, 17);
            this.lower.TabIndex = 4;
            this.lower.TabStop = true;
            this.lower.Text = "Lower Letters";
            this.lower.UseVisualStyleBackColor = true;
            // 
            // digits
            // 
            this.digits.AutoSize = true;
            this.digits.Location = new System.Drawing.Point(46, 117);
            this.digits.Name = "digits";
            this.digits.Size = new System.Drawing.Size(51, 17);
            this.digits.TabIndex = 5;
            this.digits.TabStop = true;
            this.digits.Text = "Digits";
            this.digits.UseVisualStyleBackColor = true;
            // 
            // special
            // 
            this.special.AutoSize = true;
            this.special.Location = new System.Drawing.Point(46, 140);
            this.special.Name = "special";
            this.special.Size = new System.Drawing.Size(60, 17);
            this.special.TabIndex = 6;
            this.special.TabStop = true;
            this.special.Text = "Special";
            this.special.UseVisualStyleBackColor = true;
            // 
            // click
            // 
            this.click.Location = new System.Drawing.Point(63, 167);
            this.click.Name = "click";
            this.click.Size = new System.Drawing.Size(88, 25);
            this.click.TabIndex = 7;
            this.click.Text = "Click";
            this.click.UseVisualStyleBackColor = true;
            this.click.Click += new System.EventHandler(this.click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.click);
            this.Controls.Add(this.special);
            this.Controls.Add(this.digits);
            this.Controls.Add(this.lower);
            this.Controls.Add(this.upper);
            this.Controls.Add(this.count);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton count;
        private System.Windows.Forms.RadioButton upper;
        private System.Windows.Forms.RadioButton lower;
        private System.Windows.Forms.RadioButton digits;
        private System.Windows.Forms.RadioButton special;
        private System.Windows.Forms.Button click;
    }
}

