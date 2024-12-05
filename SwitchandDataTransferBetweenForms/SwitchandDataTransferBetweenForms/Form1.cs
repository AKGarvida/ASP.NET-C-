using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchandDataTransferBetweenForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /** //How to show another form
            frmShowData frmShow = new frmShowData();

            //Open Another Form using Show
            frmShow.Show();

            //Open Another Form using Dialog
            //frmShow.ShowDialog(); **/

            string Name = txtName.Text;
            string surname = txtSurname.Text;
            string NameSurname = Name + " " + surname;
            frmShowData frmShow = new frmShowData();
            frmShow.lblNameSurname.Text = NameSurname;
            frmShow.Show();

        }
    }
}
