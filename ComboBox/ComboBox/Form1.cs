using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //How to manually add items in Combobox
            comboBox1.Items.Add("Game Day");

            //How to choose first option automatically
            //comboBox1.SelectedIndex = 6;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Selected Item in Combobox + MessageBox using button click event
            /**string selectedItem = comboBox1.SelectedItem.ToString();
            MessageBox.Show("You chose " + selectedItem);**/


            //How to display the value of items
            /**int valueorder = comboBox1.SelectedIndex;
            MessageBox.Show(valueorder.ToString());**/

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "Selected Index was changed";
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            label2.Text = "Combo Box selected value was changed.";
        }
    }
}
