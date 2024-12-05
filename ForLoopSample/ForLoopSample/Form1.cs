using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLoopSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void forLoopBTN_Click(object sender, EventArgs e)
        {
            string ivalue = " ";
            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 8;  k++)
                {
                    richTextBox1.Text += "i = " + i + " k = " + k + Environment.NewLine;
                }
                ivalue += " " + i + " ";
            }
            MessageBox.Show(ivalue);

            //For Loop
            /*string ivalue = " ";
            for (int i = 0; i < 10; i++)
            {
                ivalue += " " + i + " ";
            }
            MessageBox.Show(ivalue);*/
        }
    }
}
