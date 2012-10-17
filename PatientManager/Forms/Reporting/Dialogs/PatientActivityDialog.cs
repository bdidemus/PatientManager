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
    public partial class PatientActivityDialog : Form
    {
        public PatientActivityDialog()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PatientActivityDialog_Load(object sender, EventArgs e)
        {
            cbMode.SelectedIndex = 0;

            // Setup doctors list will "All" options
            Database.DoctorMgr docMgr = new Database.DoctorMgr();
            List<Database.doctor> docs = docMgr.getActiveDoctors().ToList();

            Database.doctor allDocs = new Database.doctor();
            allDocs.docID = 0;
            allDocs.docFirstName = "All";

            docs.Insert(0, allDocs);

            cbDoctor.DataSource = docs;
            cbDoctor.DisplayMember = "docFullName";
            cbDoctor.ValueMember = "docID";

            cbTime.SelectedIndex = 0;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            PatientActivityReportForm frm = new PatientActivityReportForm((int)cbDoctor.SelectedValue, (int)nudTimeValue.Value,
                cbTime.SelectedIndex, cbMode.SelectedIndex == 0);
            frm.MdiParent = MainParent.MainMDIParent;
            frm.Show();
            
            Close();
        }
    }
}
