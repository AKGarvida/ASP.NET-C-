using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartialClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public partial class Employee
        {
            public int EmployeeID { get; set; }
            public string Name { get; set; }
            public double Salary { get; set; }
        }

        public partial class Employee
        {
            public void SetValues()
            {
                Name = "John";
                EmployeeID = 1;
                Salary = 5000;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.SetValues();
            textBox1.Text += emp.EmployeeID + Environment.NewLine;
            textBox1.Text += emp.Name + Environment.NewLine;
            textBox1.Text += emp.Salary + Environment.NewLine;
        }
    }
}
