using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> numberlist = new List<int>();
        List<string> textlist = new List<string>();
        List<Employee> employeeList = new List<Employee>();

        public List<Employee> fillList()
        {
            employeeList.Clear();

            Employee employee1 = new Employee();
            employee1.Id = 1;
            employee1.Name = "John";
            employee1.Surname = "Doe";
            employeeList.Add(employee1);

            Employee employee2 = new Employee();
            employee2.Id = 2;
            employee2.Name = "Asher Kairos";
            employee2.Surname = "Garvida";
            employeeList.Add(employee2);

            Employee employee3 = new Employee();
            employee3.Id = 3;
            employee3.Name = "Kairos";
            employee3.Surname = "Garvida";
            employeeList.Add(employee3);

            return employeeList;
        }

        List<days> comboList = new List<days>();

        private void Form1_Load(object sender, EventArgs e)
        {
            days day1 = new days();
            day1.ID = 1;
            day1.textvalue = "Sunday";
            comboList.Add(day1);

            days day2 = new days();
            day2.ID = 2;
            day2.textvalue = "Monday";
            comboList.Add(day2);

            days day3 = new days();
            day3.ID = 3;
            day3.textvalue = "Tuesday";
            comboList.Add(day3);

            days day4 = new days();
            day4.ID = 4;
            day4.textvalue = "Wednesday";
            comboList.Add(day4);

            days day5 = new days();
            day5.ID = 5;
            day5.textvalue = "Thursday";
            comboList.Add(day5);
             
            days day6 = new days();
            day6.ID = 6;
            day6.textvalue = "Friday";
            comboList.Add(day6);

            days day7 = new days();
            day7.ID = 7;
            day7.textvalue = "Saturday";
            comboList.Add(day7);

            cmbDays.DataSource = comboList;
            cmbDays.ValueMember = "ID";
            cmbDays.DisplayMember = "textvalue";

            daylist.DataSource = comboList;


        }

        private void btnFillList_Click(object sender, EventArgs e)
        {
            fillList();
            foreach (var item in employeeList)
            {
                txtNumber.Text += item.Id + " " + item.Name + " " + item.Surname + Environment.NewLine;
            }
            //fillList();
            //foreach (var item in numberlist)
            //{
            //    txtNumber.Text += item.ToString() + Environment.NewLine;
            //}
            //MessageBox.Show("List was filled.");
        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbDays.SelectedValue.ToString()); 
        }
    }
}
