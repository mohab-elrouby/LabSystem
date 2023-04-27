using Lab.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CRUD_Tests : UserControl
    {
        LabContext labContext = new LabContext();
        Test NewTest = new Test();
        public CRUD_Tests()
        {
            InitializeComponent();
            GVTests.AutoGenerateColumns = true;
            GVTests.DataSource = labContext.Tests.ToList();
            GVTests.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            //numTestSalary.ReadOnly = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTestName.Text == "" && numTestSalary.Value == 0)
            {
                MessageBox.Show("Please Fill Test Data");
            }
            else
            {
                NewTest.Name = txtTestName.Text;
                NewTest.Price = (float)numTestSalary.Value;
                if (NewTest.Id == 0)
                {
                    labContext.Tests.Add(NewTest);
                    MessageBox.Show("Add Sucessfully");
                }
                else
                {
                    labContext.Entry(NewTest).State = System.Data.Entity.EntityState.Modified;
                    MessageBox.Show("Updated Sucessfully");
                }
                labContext.SaveChanges();
                txtTestName.Text = "";
                numTestSalary.Value = 0;
                GVTests.DataSource = labContext.Tests.ToList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure to Delete this Test?", "message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(labContext.Entry(NewTest).State==EntityState.Deleted)
                {
                    labContext.Tests.Attach(NewTest);
                    labContext.Tests.Remove(NewTest);
                    labContext.SaveChanges();
                    txtTestName.Text = "";
                    numTestSalary.Value = 0;
                    MessageBox.Show("Deleted Successfully");
                }
            }
        }

        private void GVTests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GVTests.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(GVTests.CurrentRow.Cells[0].Value);
                NewTest = labContext.Tests.Where(x => x.Id == id).FirstOrDefault();
                txtTestName.Text = NewTest.Name;
                numTestSalary.Value = (decimal)NewTest.Price;
            }
            btnAdd.Text = "Update";
            btnAdd.FillColor = Color.DarkOrange;
            btnDelete.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTestName.Text = "";
            numTestSalary.Value = 0;
            btnAdd.Text = "ADD";
            btnAdd.FillColor = Color.MediumSeaGreen;
        }
    }
}
