using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingMathClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtFirstNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') >- 1))
            {
                 e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txtSecondNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        double firstNumber = 0, secondNumber = 0;
        bool control = false;

        void set1Parameter(string text)
        {
            if (text.Trim() != " ")
            {
                control = true;
                firstNumber = Convert.ToDouble(text);
            }
            else
            {
                control = false;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            control = false;
            txtFirstNumber.Clear();
            txtSecondNumber.Clear();
            txtResult.Clear();
            firstNumber = 0;
            secondNumber = 0;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            try
            {
                set2Parameter(txtFirstNumber.Text, txtSecondNumber.Text);
                if (!control)
                {
                    MessageBox.Show("Please fill the necessary area.");
                }
                else
                {
                    txtResult.Text = Math.Min(Convert.ToDecimal(firstNumber), Convert.ToDecimal(secondNumber)).ToString();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please fill the necessary area");
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            try
            {
                set2Parameter(txtFirstNumber.Text, txtSecondNumber.Text);
                if (!control)
                {
                    MessageBox.Show("Please fill the necessary area.");
                }
                else
                {
                    txtResult.Text = Math.Max(Convert.ToDecimal(firstNumber), Convert.ToDecimal(secondNumber)).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill the necessary area");
            }
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            try
            {
                set1Parameter(txtFirstNumber.Text);
                if (!control)
                {
                    MessageBox.Show("Please fill the necessary area.");
                }
                else
                {
                    txtResult.Text = Math.Abs(firstNumber).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill the necessary area");
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            try
            {
                set1Parameter(txtFirstNumber.Text);
                if (!control)
                {
                    MessageBox.Show("Please fill the necessary area.");
                }
                else
                {
                    txtResult.Text = Math.Sign(Convert.ToDecimal(firstNumber)).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill the necessary area");
            }
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            try
            {
                set1Parameter(txtFirstNumber.Text);
                if (!control)
                {
                    MessageBox.Show("Please fill the necessary area.");
                }
                else
                {
                    double temp = (firstNumber * (Math.PI)) / 180;
                    txtResult.Text = Math.Sin(temp).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill the necessary area");
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            try
            {
                set1Parameter(txtFirstNumber.Text);
                if (!control)
                {
                    MessageBox.Show("Please fill the necessary area.");
                }
                else
                {
                    double temp = (firstNumber * (Math.PI)) / 180;
                    txtResult.Text = Math.Cos(temp).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill the necessary area");
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            try
            {
                set1Parameter(txtFirstNumber.Text);
                if (!control)
                {
                    MessageBox.Show("Please fill the necessary area.");
                }
                else
                {
                    double temp = (firstNumber * (Math.PI)) / 180;
                    txtResult.Text = Math.Tan(temp).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill the necessary area");
            }
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            try
            {
                set2Parameter(txtFirstNumber.Text, txtSecondNumber.Text);
                if (!control)
                {
                    MessageBox.Show("Please fill the necessary area.");
                }
                else
                {
                    txtResult.Text = Math.Pow(firstNumber, secondNumber).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill the necessary area");
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            try
            {
                set1Parameter(txtFirstNumber.Text);
                if (!control)
                {
                    MessageBox.Show("Please fill the necessary area.");
                }
                else
                {
                    txtResult.Text = Math.Sqrt(firstNumber).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill the necessary area");
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                set2Parameter(txtFirstNumber.Text, txtSecondNumber.Text);
                if (!control)
                {
                    MessageBox.Show("Please fill the necessary area.");
                }
                else
                {
                    txtResult.Text = Math.Log(secondNumber, firstNumber).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill the necessary area");
            }
        }

        private void btnLog10_Click(object sender, EventArgs e)
        {
            try
            {
                set1Parameter(txtFirstNumber.Text);
                if (!control)
                {
                    MessageBox.Show("Please fill the necessary area.");
                }
                else
                {
                    txtResult.Text = Math.Log10(firstNumber).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill the necessary area");
            }
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            try
            {
                set1Parameter(txtFirstNumber.Text);
                if (!control)
                {
                    MessageBox.Show("Please fill the necessary area.");
                }
                else
                {
                    txtResult.Text = Math.Exp(firstNumber).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill the necessary area");
            }
        }

        private void btnCopyFirstNumber_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Trim() != " ")
            {
                txtFirstNumber.Text = txtResult.Text;
                txtResult.Clear();
                txtSecondNumber.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void set2Parameter(string text, string text2)   
        {
            if (text.Trim() != " " && text2.Trim() != " ")
            {
                control = true;
                firstNumber = Convert.ToDouble(text);
                secondNumber = Convert.ToDouble(text2);
            }
        }
    }
}
