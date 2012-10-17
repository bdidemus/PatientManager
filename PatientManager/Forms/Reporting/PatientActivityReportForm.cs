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
    public partial class PatientActivityReportForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="docID"></param>
        /// <param name="unit">0 = weeks, 1 = months, 2 = years</param>
        public PatientActivityReportForm(int docID, int value, int unit, bool inactive)
        {
            InitializeComponent();

            setupReportData(docID, value, unit, inactive);
        }

        private void setupReportData(int docID, int value, int unit, bool inactive)
        {
            DateTime date; 
            switch (unit)
            {
                case 0:
                    date = DateTime.Now.AddDays(-(7 * value));
                    break;
                case 1:
                    date = DateTime.Now.AddMonths(-value);
                    break;
                case 2:
                    date = DateTime.Now.AddYears(-value);
                    break;
                default:
                    // This code, really, should never execute.
                    date = DateTime.Now;
                    break;
            }

            List<Database.Reporting.PatientActivityReportModel> data;
            if (inactive)
            {
                data = Database.Reporting.PatientActivityReportModel.getInactivePatientActivityModel(date, docID);
            }
            else
            {
                data = null;
            }

            // Set the datasource to the report list
            patientActivityBindingSource.DataSource = data;
            patientActivityReport.SetDataSource(patientActivityBindingSource);

            // Setup report params
            if (inactive)
            {
                patientActivityReport.SetParameterValue("ReportDesc", "Inactive Since");
            }
            else
            {
                patientActivityReport.SetParameterValue("ReportDesc", "Active up to");
            }
            String docName;
            if(docID != 0)
            {
                Database.DoctorMgr docMgr = new Database.DoctorMgr();
                docName = docMgr.getDoctor(docID).docFullName;
                
            }
            else 
            {
                docName = "Clinic"; // Shows for all doctors
            }
            patientActivityReport.SetParameterValue("DoctorName", docName);
            patientActivityReport.SetParameterValue("Date", date);
        }
    }
}
