using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string inp = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        string operations;
        double result=0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void clicked(Object b, EventArgs e)
        {

            Button btn = (Button)b;
            input.Text = input.Text + btn.Text;
            inp += input.Text;

        }
        //private void no1_Click(object sender, EventArgs e)
        //{
        //    this.input.Text = "";
        //    inp += "1";
        //    this.input.Text += inp;
        //}

        //private void no2_Click(object sender, EventArgs e)
        //{
        //    this.input.Text = "";
        //    inp += "2";
        //    this.input.Text += inp;
        //}

        //private void no3_Click(object sender, EventArgs e)
        //{
        //    this.input.Text = "";
        //    inp += "3";
        //    this.input.Text += inp;
        //}

        //private void no4_Click(object sender, EventArgs e)
        //{
        //    this.input.Text = "";
        //    inp += "4";
        //    this.input.Text += inp;
        //}

        //private void no5_Click(object sender, EventArgs e)
        //{
        //    this.input.Text = "";
        //    inp += "5";
        //    this.input.Text += inp;
        //}

        //private void no6_Click(object sender, EventArgs e)
        //{
        //    this.input.Text = "";
        //    inp += "6";
        //    this.input.Text += inp;
        //}

        //private void no7_Click(object sender, EventArgs e)
        //{
        //    this.input.Text = "";
        //    inp += "7";
        //    this.input.Text += inp;
        //}

        //private void no8_Click(object sender, EventArgs e)
        //{
        //    this.input.Text = "";
        //    inp += "8";
        //    this.input.Text += inp;
        //}

        //private void no9_Click(object sender, EventArgs e)
        //{
        //    this.input.Text = "";
        //    inp += "9";
        //    this.input.Text += inp;
        //}

        //private void no0_Click(object sender, EventArgs e)
        //{
        //    this.input.Text = "";
        //    inp += "0";
        //    this.input.Text += inp;
        //}

        //private void add_Click(object sender, EventArgs e)
        //{
        //    this.input.Text = "";
        //    operand1 = inp;
        //    operations = '+';
        //    inp = string.Empty;
        //}

        //private void minus_Click(object sender, EventArgs e)
        //{
        //    this.input.Text = "";
        //    operand1 = inp;
        //    operations = '-';
        //    inp = string.Empty;
        //}

        //private void multiply_Click(object sender, EventArgs e)
        //{
        //    this.input.Text = "";
        //    operand1 = inp;
        //    operations = '*';
        //    inp = string.Empty;
        //}

        //private void divide_Click(object sender, EventArgs e)
        //{
        //    this.input.Text = "";
        //    operand1 = inp;
        //    operations = '/';
        //    inp = string.Empty;
        //}

        private void clickOperation(Object b, EventArgs e)
        {

            this.input.Text = "";
            Button btn = (Button)b;
            operand1 = inp;
            operations = btn.Text;
            inp = string.Empty;

        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.input.Text = "";
            this.inp = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            operand2 = inp;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if(operations == "+")
            {
                result = num1 + num2;
                this.operand1 = string.Empty;
                this.operand2 = string.Empty;
                input.Text = result.ToString();
                this.inp = string.Empty;
                this.operand1 = string.Empty;
                this.operand2 = string.Empty;

            }
            else if (operations == "-")
            {
                result = num1 - num2;
                input.Text = result.ToString();
                this.inp = string.Empty;
                this.operand1 = string.Empty;
                this.operand2 = string.Empty;
            }
            else if(operations == "*")
            {
                result = num1 * num2;
                input.Text = result.ToString();
                this.inp = string.Empty;
                this.operand1 = string.Empty;
                this.operand2 = string.Empty;
            }
            else if(operations == "/")
            {
                result = num1 / num2;
                input.Text = result.ToString();
                this.inp = string.Empty;
                this.operand1 = string.Empty;
                this.operand2 = string.Empty;
            }
            else
            {
                input.Text = "DIV/ZERO";
            }
        }
    }
}