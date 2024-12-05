using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void fillTextBox(int x);
        string textvalue = "";
        
        public void fillMathNote(int ExamNote)
        {
            textvalue += "Your Math  Note is: " + ExamNote + Environment.NewLine;
        }

        public void fillChemistryNote(int ExamNote)
        {
            textvalue += "Your Chemistry Note is: " + ExamNote + Environment.NewLine;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void ShowinTextBox()
        {
            textBox1.Text = textvalue;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            //fillTextBox filltext = fillMathNote;
            //filltext(80);
            //fillTextBox filltext = new fillTextBox(fillMathNote);
            //filltext.Invoke(80);
            fillTextBox fillText = new fillTextBox(fillMathNote);
            fillText += fillChemistryNote;
            fillText(80);
            fillText -= fillMathNote;
            fillText(60);
            ShowinTextBox();
        }
    }
}
