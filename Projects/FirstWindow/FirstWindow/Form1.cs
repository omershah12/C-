using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindow
{
    public partial class QAC : Form
    {
        int a, b, c;
        public QAC()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                a = Int32.Parse(number1.Text);
                b = Int32.Parse(number2.Text);

                c = a + b;

                sum.Text = "" + c;
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                a = Int32.Parse(number1.Text);
                b = Int32.Parse(number2.Text);

                c = a - b;

                sum.Text = "" + c;
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                a = Int32.Parse(number1.Text);
                b = Int32.Parse(number2.Text);

                c = a * b;

                sum.Text = "" + c;
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                a = Int32.Parse(number1.Text);
                b = Int32.Parse(number2.Text);

                c = a / b;

                sum.Text = "" + c;
            }
        }

        public bool checkInputs()
        {
            if (number1.Text == "")
            {
                MessageBox.Show("Number1 is missing");
                number1.Focus();
                return false;
            }
             else if(number2.Text == "")
            {
                MessageBox.Show("Number2 is missing");
                number2.Focus();
                return false;
            }
            return true;
        }
    }
}
