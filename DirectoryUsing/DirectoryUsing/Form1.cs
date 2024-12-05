using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DirectoryUsing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Directory.CreateDirectory("temp");
            //if (Directory.Exists("folder2"))
            //{
            //    Directory.CreateDirectory("folder2");
            //}

            //DirectoryInfo dr = new DirectoryInfo("temp2");
            //dr.Create();
            //MessageBox.Show("Folder was created.");
            DirectoryInfo dr = new DirectoryInfo("folder2");
            string accesstime = dr.LastAccessTime.ToString();
            MessageBox.Show(accesstime);
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            Directory.Move("temp", @"C:\new folder\temp");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Directory.Delete("temp2");
        }
    }
}
