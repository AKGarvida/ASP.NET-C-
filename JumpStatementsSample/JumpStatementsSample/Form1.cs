using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumpStatementsSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void breakBtn_Click(object sender, EventArgs e)
        {
            string ivalue = " ";
            for (int i = 0; i < 5;  i++)
            {
                if (i == 4)
                    break;
                ivalue += " " + i + " ";
            }
            MessageBox.Show(ivalue);
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            string ivalue = " ";
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                    continue;
                ivalue += " " + i + " ";
            }
            MessageBox.Show(ivalue);
        }

        private void goToBtn_Click(object sender, EventArgs e)
        {
            string messagetext = " ";
            int x = 3;
            switch (x)
            {
                case 1:
                    messagetext = "You entered 1";
                    break;
                case 2:
                    messagetext = "You entered 2";
                    break;
                case 3:
                    messagetext = "You entered 3";
                    goto case 2;
                default:
                    messagetext = "You entered 4";
                    break;
            }
            MessageBox.Show(messagetext);
        }
    }
}
