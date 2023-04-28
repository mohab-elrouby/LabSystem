using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CRUD_Tests crud_Tests=new CRUD_Tests();
            guna2Panel2.Controls.Add(crud_Tests);
            crud_Tests.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Tests_in_month tests_In_Month=new Tests_in_month();
            guna2Panel2.Controls.Add(tests_In_Month);
            tests_In_Month.BringToFront();
        }
    }
}
