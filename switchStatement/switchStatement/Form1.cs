using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switchStatement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void switchBTN_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            string messagetext = " ";

            /*switch (Convert.ToInt32(textBox1.Text))
              {
                  case 2:
                      messagetext = "x = 2";
                      break;
                  case 4:
                      messagetext = "x = 4";
                      break;
                  case 6:
                      messagetext = "x = 6";
                      break;
                  default:
                      messagetext = "x = 8";
                      break;
              }
              MessageBox.Show(messagetext); */

            switch (Convert.ToInt32(textBox1.Text))
            {
                case 2:
                    messagetext = "x = 2";
                    break;
                case 4:
                    messagetext = "x = 4";
                    break;
                case 6:
                    messagetext = "x = 6";
                    switch (Convert.ToInt32(textBox2.Text))
                    {
                        case 1:
                            messagetext += "y = 1";
                            break;
                        case 2:
                            messagetext += "y = 2";
                            break;
                        default:
                            messagetext += "y = 3";
                            break;
                    }
                    break;
                default:
                    messagetext = "x = 8";
                    break;
            }
            MessageBox.Show(messagetext);
        }
    }
}
