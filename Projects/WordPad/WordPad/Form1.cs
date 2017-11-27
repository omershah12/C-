using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad
{
    public partial class Form1 : Form
    {
        //Boolean isSaved;
        Boolean isChanged;
        String fileN="";
        public Form1()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileN != "")
            {
                rt.SaveFile(fileN);
                //isSaved = true;
                isChanged = false;

            }else
            {
                SaveAs_Click(sender, e);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            rt.Height = this.Height;
            rt.Width = this.Width;
        }

        private void New_Click(object sender, EventArgs e)
        {
            if (isChanged == false)
            {
                rt.Text = "";
                isChanged = true;
                fileN = "";
            }
            else
            {
                DialogResult result;
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                result = MessageBox.Show("Do you want to save", "", buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                }
                else if(result == System.Windows.Forms.DialogResult.No)
                {
                    rt.Text = "";
                }else if(result == System.Windows.Forms.DialogResult.Cancel)
                {
                    this.DialogResult = DialogResult.None;
                }
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            
            if (openF.ShowDialog() == DialogResult.OK)
            {
                rt.LoadFile(openF.FileName);
                //isSaved = false;
                isChanged = false;
                fileN = openF.FileName;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isChanged==false)
            {
                Application.Exit();
            }
            else
            {
                New_Click(sender, e);
            }
        }

        private void rt_KeyPress(object sender, KeyPressEventArgs e)
        {
            isChanged = true;
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            saveF.ShowDialog();

                if (saveF.FileName != "")
                {
                    rt.SaveFile(saveF.FileName);
                    //isSaved = true;
                    isChanged = false;
                    fileN = saveF.FileName;
                }
            
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
                fontType.ShowDialog();
                rt.SelectionFont = fontType.Font;
            
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
                colorDialog1.ShowDialog();
                rt.SelectionColor = colorDialog1.Color;
            
        }
    }
}
