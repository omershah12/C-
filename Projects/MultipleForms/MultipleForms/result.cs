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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
            
        }

        public void printNum(int result)
        {
            resultText.Text = ""+ result;
            this.Show();
        }

        private void returnToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
