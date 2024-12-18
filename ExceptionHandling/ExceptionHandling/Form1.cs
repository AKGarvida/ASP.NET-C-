﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            //int firstnumber = Convert.ToInt32(txtFirstNumber.Text);
            try
            {
                int result = Convert.ToInt32(txtFirstNumber.Text) / Convert.ToInt32(txtSecondNumber.Text);
            }
            catch (DivideByZeroException ex)
            {

                //MessageBox.Show(ex.ToString());
                throw new Exception("You can't divide any number to zero.");
            }
            catch (Exception ex)
            {
                throw new Exception("Please use only numbers.");
            }
            finally
            {
                MessageBox.Show("Program was finished.");
            }
        }
    }
}
