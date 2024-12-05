using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1parameter_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues(1);
            string messagetext = teacher.GetValues();
            textBox1.Text = messagetext;
        }

        private void btn2parameter_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues(1, "John");
            string messagetext = teacher.GetValues();
            textBox1.Text = messagetext;
        }

        private void btn3parameter_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues(1, "John", 18000);
            string messagetext = teacher.GetValues();
            textBox1.Text = messagetext;
        }

        private void btn4parameter_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues(1, "John", 18000, "Teacher");
            string messagetext = teacher.GetValues();
            textBox1.Text = messagetext;
        }

        private void btnVirtual_Click(object sender, EventArgs e)
        {
            Employee2 employee = new Employee2();
            string messagetext = employee.SetValues(1, "John", 18000);
            textBox1.Text = messagetext;
        }

        private void btnOverride_Click(object sender, EventArgs e)
        {
            Teacher2 employee = new Teacher2();
            string messagetext = employee.SetValues(1, "John", 18000);
            textBox1.Text = messagetext;
        }
    }
}
