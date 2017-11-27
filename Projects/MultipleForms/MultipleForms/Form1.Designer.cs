namespace MultipleForms
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
            this.t1 = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.RadioButton();
            this.minus = new System.Windows.Forms.RadioButton();
            this.multiply = new System.Windows.Forms.RadioButton();
            this.divide = new System.Windows.Forms.RadioButton();
            this.t2 = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(46, 12);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(167, 20);
            this.t1.TabIndex = 0;
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.Location = new System.Drawing.Point(63, 79);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(31, 17);
            this.add.TabIndex = 1;
            this.add.TabStop = true;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.CheckedChanged += new System.EventHandler(this.add_CheckedChanged);
            // 
            // minus
            // 
            this.minus.AutoSize = true;
            this.minus.Location = new System.Drawing.Point(63, 102);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(28, 17);
            this.minus.TabIndex = 2;
            this.minus.TabStop = true;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.CheckedChanged += new System.EventHandler(this.minus_CheckedChanged);
            // 
            // multiply
            // 
            this.multiply.AutoSize = true;
            this.multiply.Location = new System.Drawing.Point(63, 125);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(29, 17);
            this.multiply.TabIndex = 3;
            this.multiply.TabStop = true;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.CheckedChanged += new System.EventHandler(this.multiply_CheckedChanged);
            // 
            // divide
            // 
            this.divide.AutoSize = true;
            this.divide.Location = new System.Drawing.Point(63, 148);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(30, 17);
            this.divide.TabIndex = 4;
            this.divide.TabStop = true;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.CheckedChanged += new System.EventHandler(this.divide_CheckedChanged);
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(46, 43);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(166, 20);
            this.t2.TabIndex = 5;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(63, 189);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 6;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.add);
            this.Controls.Add(this.t1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.RadioButton add;
        private System.Windows.Forms.RadioButton minus;
        private System.Windows.Forms.RadioButton multiply;
        private System.Windows.Forms.RadioButton divide;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.Button calculate;
    }
}

