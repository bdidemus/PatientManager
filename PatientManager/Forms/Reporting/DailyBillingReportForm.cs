using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PatientManager.Forms.Reporting
{
    public partial class DailyBillingReportForm : Form
    {
        public DailyBillingReportForm(DateTime date, int docID)
        {
            InitializeComponent();

            Database.DoctorMgr docMgr = new Database.DoctorMgr();
            String doctorName = (docID > 0) ? "Dr. " + docMgr.getDoctor(docID).docFullName : "All Doctors";

            dailyBillingBindingSource.DataSource = Database.Reporting.DailyBillingsViewModel.getDailyBillingsViewModel(date, docID);
            DailyBillingsReport1.SetDataSource(dailyBillingBindingSource);
            DailyBillingsReport1.SetParameterValue("StartDate", date);
            DailyBillingsReport1.SetParameterValue("DocName", doctorName);
        }
    }
}
