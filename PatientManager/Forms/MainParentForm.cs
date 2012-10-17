using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PatientManager.Forms;

namespace PatientManager
{
    public partial class MainParent : Form
    {
        private static MainParent m_mdiSingleton;
        public static MainParent MainMDIParent { get { return m_mdiSingleton; } }

        public MainParent()
        {
            InitializeComponent();
            m_mdiSingleton = this;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = this.ActiveMdiChild;
            // No form selected
            if (f == null)
                return;

            // Find the control that has focus
            Control focusedControl = f.ActiveControl;

            // See if focusedControl is of a type that can select text/data
            if (focusedControl is TextBox)
            {
                TextBox tb = focusedControl as TextBox;
                Clipboard.SetDataObject(tb.SelectedText);
            }
            else if (focusedControl is DataGridView)
            {
                DataGridView dgv = focusedControl as DataGridView;
                Clipboard.SetDataObject(dgv.GetClipboardContent());
            }

        }

        private void c3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = this.ActiveMdiChild;
            // No form selected
            if (f == null)
                return;

            // Find the control that has focus
            Control focusedControl = f.ActiveControl;

            // See if focusedControl is of a type that can select text/data
            if (focusedControl is TextBox)
            {
                TextBox tb = focusedControl as TextBox;
                Clipboard.SetDataObject(tb.SelectedText);
                tb.Text = String.Empty;      
            }
            else if (focusedControl is DataGridView)
            {
                DataGridView dgv = focusedControl as DataGridView;
                Clipboard.SetDataObject(dgv.GetClipboardContent());
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = this.ActiveMdiChild;
            // No form selected
            if (f == null)
                return;

            // Find the control that has focus
            Control focusedControl = f.ActiveControl;

            // See if focusedControl is of a type that can select text/data
            if (focusedControl is TextBox)
            {
                TextBox tb = focusedControl as TextBox;
                tb.Text = Clipboard.GetText();
            }
        }

        private void MainParent_Shown(object sender, EventArgs e)
        {
            /* Loop forever until user either exits the program or
             * enters valid credentials 
             */
            while (!LoginMgr.Instance.isLoggedIn)
            {
                Forms.LoginForm frmLogin = new Forms.LoginForm();
                DialogResult r = frmLogin.ShowDialog(this);
                if (r == DialogResult.Cancel)
                {
                    Close();
                    break;
                }
            }

            activateTools();
        }

        private void activateTools()
        {
            tspNewPatient.Enabled = true;
            tspUseMod.Enabled = true;
            tsbDoctors.Enabled = true;
            tsbAppointments.Enabled = true;
            tsbBilling.Enabled = true;
            tsbManageInventory.Enabled = true;
            tsbAddInventory.Enabled = true;
            tsbViewInvoices.Enabled = true;
        }

        private void tspNewPatient_Click(object sender, EventArgs e)
        {
            Forms.NewPatientForm frmNewPat = new Forms.NewPatientForm();
            frmNewPat.MdiParent = this;
            frmNewPat.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tspUseMod_Click(object sender, EventArgs e)
        {
            if (!checkForOpenForm("ManagePatientsForm"))
            {
                ManagePatientsForm frmMangage = new ManagePatientsForm();
                frmMangage.MdiParent = this;
                frmMangage.Show();
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented");
            //SettingsForm frmSettings = new SettingsForm();
            //frmSettings.ShowDialog(this);
        }

        private void tsbDoctors_Click(object sender, EventArgs e)
        {
            if (!checkForOpenForm("DoctorsForm"))
            {
                Form frmDoctors = new DoctorsForm();
                frmDoctors.MdiParent = this;
                frmDoctors.Show();
            }
        }

        private void tsbAppointments_Click(object sender, EventArgs e)
        {
            if(!checkForOpenForm("AppointmentViewForm"))
            {
                if (!checkForActiveDoctors())
                {
                    return;
                }
                AppointmentViewForm frmAppointments = new AppointmentViewForm();
                frmAppointments.MdiParent = this;
                frmAppointments.Show();
            }
        }

        private void tsbBilling_Click(object sender, EventArgs e)
        {
            if (!checkForActiveDoctors())
            {
                return;
            }
            InvoiceForm frmInvoice = new InvoiceForm();
            frmInvoice.MdiParent = this;
            frmInvoice.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void tsbAddInventory_Click(object sender, EventArgs e)
        {
            InventoryForm frmItry = new InventoryForm();
            frmItry.MdiParent = this;
            frmItry.Show();
        }

        private void tsbManageInventory_Click(object sender, EventArgs e)
        {
            if (!checkForOpenForm("ManageInventoryForm"))
            {
                ManageInventoryForm frmMngInvetory = new ManageInventoryForm();
                frmMngInvetory.MdiParent = this;
                frmMngInvetory.Show();
            }
        }

        private void tsbViewInvoices_Click(object sender, EventArgs e)
        {
            if (!checkForOpenForm("InvoiceManagerForm"))
            {
                InvoiceManagerForm frmInvoices = new InvoiceManagerForm();
                frmInvoices.MdiParent = this;
                frmInvoices.Show();
            }
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented");
        }

        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tspNewPatient.PerformClick();
        }

        private void managePatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tspUseMod.PerformClick();
        }

        private void manageDoctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbDoctors.PerformClick();
        }

        private void appointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbAppointments.PerformClick();
        }

        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbBilling.PerformClick();
        }

        private void billingHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbViewInvoices.PerformClick();
        }

        private void addInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbAddInventory.PerformClick();
        }

        private void manageInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbManageInventory.PerformClick();
        }

        private void tsbPayment_Click(object sender, EventArgs e)
        {
            if (!checkForOpenForm("PaymentForm"))
            {
                if (!checkForActiveDoctors())
                {
                    return;
                }
                PaymentForm pFrm = new PaymentForm();
                pFrm.MdiParent = this;
                pFrm.Show();
            }
        }

        private bool checkForActiveDoctors()
        {
            Database.DoctorMgr docMgr = new Database.DoctorMgr();
            if (docMgr.getActiveDoctors().Count() == 0)
            {
                MessageBox.Show("There are no active doctors in the database.\nBefore working with many of the modules at least one active doctor needs to be created.",
                    "PatientManager", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            return true;
        }

        private bool checkForOpenForm(String requestedForm)
        {
            Form frm = Application.OpenForms[requestedForm];
            if (frm != null)
            {
                frm.WindowState = FormWindowState.Normal;
                frm.BringToFront();
                frm.Activate();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void billingPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountSummaryReportDialog diag = new AccountSummaryReportDialog(this);
            diag.ShowDialog();
        }

        private void tsiDailyBillings_Click(object sender, EventArgs e)
        {
            Forms.Reporting.Dialogs.DailyBillingsDialog billdlg = new Forms.Reporting.Dialogs.DailyBillingsDialog();
            billdlg.ShowDialog();
        }

        private void activityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Reporting.Dialogs.PatientActivityDialog dlg = new Forms.Reporting.Dialogs.PatientActivityDialog();
            dlg.ShowDialog();
        }

        private void accountBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Reporting.Dialogs.AccountsRecivableDialog dlg = new Forms.Reporting.Dialogs.AccountsRecivableDialog();
            dlg.ShowDialog();
        }
    }
}
