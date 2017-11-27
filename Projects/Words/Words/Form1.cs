using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Words
{
    public partial class Form1 : Form
    {
        string result;
        public Form1()
        {
            InitializeComponent();
        }

        private void click_Click(object sender, EventArgs e)
        {
            string inp = input.Text;

            if (count.Checked)
            {
                int r;
                r = inp.Split(' ').Length;
                textBox2.Text =r.ToString();
            }
            else if (upper.Checked)
            {
                result = String.Concat(inp.Where(x => Char.IsUpper(x)));
                textBox2.Text = result;
            }
            else if (lower.Checked)
            {
                result = String.Concat(inp.Where(x => Char.IsLower(x)));
                textBox2.Text = result;
            }
            else if (digits.Checked)
            {
                result = String.Concat(inp.Where(x => Char.IsDigit(x)));
                textBox2.Text = result;
            }
            else if (special.Checked)
            {
                result = String.Concat(inp.Where(x => !Char.IsLetterOrDigit(x)));
                textBox2.Text = result;
            }
        }
    }
}
