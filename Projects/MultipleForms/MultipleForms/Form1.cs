using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleForms
{
    public partial class Form1 : Form
    {
        Result r = new Result();
        int result;
        public Form1()
        {
            InitializeComponent();
            

        }

        private void add_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void minus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void multiply_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void divide_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(t1.Text);
            int num2 = Int32.Parse(t2.Text);
            if (add.Checked)
            {
                result = num1 + num2;
                t1.Text = "";
                t2.Text = "";
            }
            else if (minus.Checked)
            {
                result = num1 - num2;
                t1.Text = "";
                t2.Text = "";
            }
            else if (multiply.Checked) 
            {
                result = num1 * num2;
                t1.Text = "";
                t2.Text = "";
            }
            else if (divide.Checked)
            {
                result = num1 / num2;
                t1.Text = "";
                t2.Text = "";
            }
            r.printNum(result);
            r.Show();
        }
    }
}
