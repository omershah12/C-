namespace BankSystem
{
    partial class deposit
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
            this.label1 = new System.Windows.Forms.Label();
            this.accNoSearch = new System.Windows.Forms.TextBox();
            this.accNoSearchBtn = new System.Windows.Forms.Button();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.accTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.genderTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.currentBalance = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.amtTxt = new System.Windows.Forms.TextBox();
            this.depositBtn = new System.Windows.Forms.Button();
            this.infoPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number";
            // 
            // accNoSearch
            // 
            this.accNoSearch.Location = new System.Drawing.Point(105, 26);
            this.accNoSearch.Name = "accNoSearch";
            this.accNoSearch.Size = new System.Drawing.Size(100, 20);
            this.accNoSearch.TabIndex = 1;
            // 
            // accNoSearchBtn
            // 
            this.accNoSearchBtn.Location = new System.Drawing.Point(211, 26);
            this.accNoSearchBtn.Name = "accNoSearchBtn";
            this.accNoSearchBtn.Size = new System.Drawing.Size(61, 20);
            this.accNoSearchBtn.TabIndex = 2;
            this.accNoSearchBtn.Text = "...";
            this.accNoSearchBtn.UseVisualStyleBackColor = true;
            this.accNoSearchBtn.Click += new System.EventHandler(this.accNoSearchBtn_Click);
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.panel1);
            this.infoPanel.Controls.Add(this.currentBalance);
            this.infoPanel.Controls.Add(this.label7);
            this.infoPanel.Controls.Add(this.genderTxt);
            this.infoPanel.Controls.Add(this.label6);
            this.infoPanel.Controls.Add(this.label5);
            this.infoPanel.Controls.Add(this.accTxt);
            this.infoPanel.Controls.Add(this.label4);
            this.infoPanel.Controls.Add(this.addressTxt);
            this.infoPanel.Controls.Add(this.nameTxt);
            this.infoPanel.Controls.Add(this.addressLbl);
            this.infoPanel.Controls.Add(this.label3);
            this.infoPanel.Controls.Add(this.nameLbl);
            this.infoPanel.Controls.Add(this.label2);
            this.infoPanel.Location = new System.Drawing.Point(15, 76);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(283, 279);
            this.infoPanel.TabIndex = 3;
            this.infoPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(87, 19);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(0, 13);
            this.nameLbl.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(87, 41);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(0, 13);
            this.addressLbl.TabIndex = 3;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(58, 18);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(100, 20);
            this.nameTxt.TabIndex = 4;
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(58, 48);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(100, 20);
            this.addressTxt.TabIndex = 5;
            // 
            // accTxt
            // 
            this.accTxt.Location = new System.Drawing.Point(93, 87);
            this.accTxt.Name = "accTxt";
            this.accTxt.Size = new System.Drawing.Size(100, 20);
            this.accTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Account Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Gender";
            // 
            // genderTxt
            // 
            this.genderTxt.Location = new System.Drawing.Point(58, 121);
            this.genderTxt.Name = "genderTxt";
            this.genderTxt.Size = new System.Drawing.Size(100, 20);
            this.genderTxt.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Balance";
            // 
            // currentBalance
            // 
            this.currentBalance.Location = new System.Drawing.Point(62, 156);
            this.currentBalance.Name = "currentBalance";
            this.currentBalance.Size = new System.Drawing.Size(100, 20);
            this.currentBalance.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.depositBtn);
            this.panel1.Controls.Add(this.amtTxt);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(30, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 66);
            this.panel1.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Amount";
            // 
            // amtTxt
            // 
            this.amtTxt.Location = new System.Drawing.Point(57, 25);
            this.amtTxt.Name = "amtTxt";
            this.amtTxt.Size = new System.Drawing.Size(100, 20);
            this.amtTxt.TabIndex = 13;
            // 
            // depositBtn
            // 
            this.depositBtn.Location = new System.Drawing.Point(163, 24);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(61, 20);
            this.depositBtn.TabIndex = 14;
            this.depositBtn.Text = "Deposit";
            this.depositBtn.UseVisualStyleBackColor = true;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 369);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.accNoSearchBtn);
            this.Controls.Add(this.accNoSearch);
            this.Controls.Add(this.label1);
            this.Name = "deposit";
            this.Text = "Deposit";
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accNoSearch;
        private System.Windows.Forms.Button accNoSearchBtn;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.TextBox amtTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox currentBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox genderTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox accTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label label2;
    }
}