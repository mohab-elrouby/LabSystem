using Lab.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Tests_in_month : UserControl
    {
        LabContext labContext=new LabContext();
        public Tests_in_month()
        {
            InitializeComponent();
            GVmonth.DataSource=labContext.TestPatients.ToList();
            comboTests.DataSource=labContext.Tests.Select(i=>i).ToList();
            comboTests.DisplayMember = "name";
            comboTests.ValueMember = "id";
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            GVmonth.DataSource = labContext.TestPatients.Where(x=>x.Date.Year>=dtpFrom.Value.Year&& x.Date.Year<=dtpTo.Value.Year)
                .Where(x => x.Date.Month >= dtpFrom.Value.Month && x.Date.Month <= dtpTo.Value.Month)
                .Where(x => x.Date.Day >= dtpFrom.Value.Day && x.Date.Day <= dtpTo.Value.Day).Select(x=>x).ToList();
        }

        private void comboTests_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //MessageBox.Show(comboTests.SelectedValue.ToString());
            var TestsEarnings_Jan=labContext.TestPatients.Where(x=>x.TestId==comboTests.SelectedIndex).Where(x=>x.Date.Month==1).Select(x=>x.PriceAfterDiscount).ToList().Sum();
            MessageBox.Show(TestsEarnings_Jan.ToString());
            GVtest.DataSource = labContext.TestPatients.Where(x => x.TestId == (int)comboTests.SelectedValue).ToList();
        }
    }
}
