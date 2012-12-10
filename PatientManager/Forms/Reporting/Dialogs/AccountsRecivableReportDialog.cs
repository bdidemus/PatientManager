using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace PatientManager.Forms.Reporting.Dialogs
{
    public partial class AccountsRecivableDialog : Form
    {
        private AccountsRecivableReportForm m_reportFrm;
        public delegate void updateFormProgress(int progress, int total);
        private Thread workerThread;

        public AccountsRecivableDialog()
        {
            InitializeComponent();

            dtpStart.Value = new DateTime(DateTime.Now.Year, 1, 1);
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
            m_reportFrm = new AccountsRecivableReportForm((int)cbDoctor.SelectedValue,
                dtpStart.Value, dtpEnd.Value, updateProgress);

            workerThread = new Thread(new ThreadStart(m_reportFrm.loadData));
            workerThread.Name = "AccRec";
            workerThread.Start();

            btnClose.Enabled = false;
            btnGenerate.Enabled = false;

            while (workerThread.IsAlive)
            {
                Application.DoEvents();
                Thread.Sleep(1);
            }

            finishLoading();
        }

        public void updateProgress(int progress, int total)
        {
            if (InvokeRequired && !IsDisposed)
            {
                Invoke(new Action<int, int>(updateProgress), progress, total);
            }
            else
            {
                if (pbProgress.Maximum != total)
                {
                    pbProgress.Maximum = total;
                }

                pbProgress.Value = progress;
            }
        }

        public void finishLoading()
        {
            m_reportFrm.MdiParent = MainParent.MainMDIParent;
            m_reportFrm.Show();
            Close();
        }

    }
}
