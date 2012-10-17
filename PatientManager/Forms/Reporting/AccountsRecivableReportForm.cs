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
    public partial class AccountsRecivableReportForm : Form
    {
        public AccountsRecivableReportForm(int docID)
        {
            InitializeComponent();

            BindingSource accRecBindingSource = new BindingSource();
            accRecBindingSource.DataSource = Database.Reporting.AccountsReceivableModel.getAccountsReceiveableModel(docID);
            AccountsReceivable1.SetDataSource(accRecBindingSource);

            if (docID > 0)
            {
                Database.DoctorMgr docMgr = new Database.DoctorMgr();
                AccountsReceivable1.SetParameterValue("DoctorName", docMgr.getDoctor(docID).docFullName);
            }

        }

    }
}
