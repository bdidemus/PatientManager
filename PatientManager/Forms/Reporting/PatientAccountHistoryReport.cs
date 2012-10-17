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
    public partial class PatientAccountHistoryReport : Form
    {
        public PatientAccountHistoryReport(int patID, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            decimal prevBalance = Database.Reporting.PatientAccountHistoryModel.getPatientPrevBalance(patID, startDate);
            
            accountBindingSource.DataSource = Database.Reporting.PatientAccountHistoryModel.getPatientHistoryModel(patID, startDate, endDate);
            patientItemizedStatement1.SetDataSource(accountBindingSource);
            patientItemizedStatement1.SetParameterValue("PrevBalance", prevBalance);
        }
    }
}
