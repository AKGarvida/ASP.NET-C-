using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstProject_WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "Review Objects in Toolbox";
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            label1.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean sodales leo risus, vel congue turpis varius ut. Nam tempor malesuada tempor. Mauris eu orci est.";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string messagetitle = "Close Windows Form";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, messagetitle, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            string labeltext = richTextBox1.Text;
            label3.Text = labeltext;
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            label3.Text = string.Empty;
        }
    }
}
