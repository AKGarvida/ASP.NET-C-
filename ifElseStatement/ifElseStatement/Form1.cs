using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifElseStatement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 20, b = 30;
            string name = "John";
            bool control = true;

            if (a == 20)
            {
                label1.Text = "If block 1 was executed";
            }
            if (!control)
            {
                textBox1.Text = "If block 2 was executed";
            }
            if (a <= b)
            {
                MessageBox.Show("If Block 3 was executed");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 20, b = 30;
            string name = "Doe";
            bool control = true;

            if (a == 30)
            {
                textBox1.Text = "If block 1 was executed";
            }
            else if (control)
            {
                textBox1.Text = "If block 2 was executed";
            }
            else if (a >= b)
            {
                textBox1.Text = "If block 3 was executed";
            }
            else
            {
                textBox1.Text = "If block 4 was executed";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to abort?", "if control", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                textBox1.Text = "YES was chosen";
            }
            else if (result == DialogResult.No)
            {
                textBox1.Text = "NO was chosen";
            }
            else
            {
                textBox1.Text = "CANCEL was chosen";
            }
        }

        private void ternaryBTN_Click(object sender, EventArgs e)
        {
            int a = 10, b = 20;
            string ternaryresult;
            ternaryresult = a < b ? b.ToString() : a.ToString();
            MessageBox.Show(ternaryresult);
        }
    }
}
