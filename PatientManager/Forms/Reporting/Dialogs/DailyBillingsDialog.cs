using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PatientManager.Forms.Reporting.Dialogs
{
    public partial class DailyBillingsDialog : Form
    {
        public DailyBillingsDialog()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DailyBillingsDialog_Load(object sender, EventArgs e)
        {
            Database.DoctorMgr docMgr = new Database.DoctorMgr();
            List<Database.doctor> docs = docMgr.getActiveDoctors().ToList();

            Database.doctor allDocs = new Database.doctor();
            allDocs.docID = 0;
            allDocs.docFirstName = "All";

            docs.Insert(0, allDocs);

            cbDoctor.DataSource = docs;
            cbDoctor.DisplayMember = "docFullName";
            cbDoctor.ValueMember = "docID";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            DailyBillingReportForm reportFrm = new DailyBillingReportForm(dtpDate.Value.Date, (int)cbDoctor.SelectedValue);
            reportFrm.MdiParent = MainParent.MainMDIParent;
            reportFrm.Show();
            Close();
        }

    }
}
