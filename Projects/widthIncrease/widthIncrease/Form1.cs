using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace widthIncrease
{
    public partial class Form1 : Form
    {
        Boolean reachedEnd;
        //int originalWidth = t2.Width;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if(t1.Width > (this.Width - 100))
            {
                this.Text = "Maximum width reached";
            }else
            {
                t1.Width = t1.Width + 10;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {

            if (t2.Width > (this.Width - 100) &&(reachedEnd==false))
            {
                t2.Width = t2.Width - 10;
                this.Text = "going down..";
                reachedEnd = true;

            } else if (t2.Width < 50 && (reachedEnd == true))
            {
                t2.Width = t2.Width + 10;
                this.Text = "going up..";
                reachedEnd = false;
                
            }
            else if (t2.Width < (this.Width-100) && reachedEnd==true)
            {
                t2.Width = t2.Width - 10;
            }
            else if (reachedEnd == false)
            {
                t2.Width = t2.Width + 10;
            }

          
        }
    }
}
