using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatetimepickerSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //How to display DateTimePicker value using button
            DateTime birthday = dateTimePicker1.Value;
            MessageBox.Show(birthday.ToString());

            //How to add and decrease value using button
            label1.Text = birthday.AddYears(5).ToLongDateString();
            label2.Text = birthday.AddYears(-5).ToLongDateString();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToLongDateString());
        }
    }
}
