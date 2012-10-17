using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PatientManager.Forms
{
    public partial class PaymentForm : Form
    {
        private Database.PatientMgr m_patMgr = new Database.PatientMgr();
        private Database.PaymentMgr m_payMgr = new Database.PaymentMgr();
        private Database.InvoiceMgr m_invMgr = Database.InvoiceMgr.Instance;
        private Database.patient m_patient;
        private bool m_closeAfterCommit = false;

        public PaymentForm()
        {
            InitializeComponent();
            paymentsViewModelBindingSource.DataSource = m_payMgr.getPaymentViewModelForToday();
            paymenttypeBindingSource.DataSource = m_payMgr.getPaymentTypes();
            //cbPaymentType.SelectedIndex = 0;        
        }

        public PaymentForm(int patID, decimal amount, int invID, int docID)
        {
            InitializeComponent();
            // Get the patient and populate textbox
            paymentsViewModelBindingSource.DataSource = m_payMgr.getPaymentViewModelForToday();
            paymenttypeBindingSource.DataSource = m_payMgr.getPaymentTypes();
            Patient = m_patMgr.getPatient(patID);

            // If the docID is different for this invoice/payment
            // than their default docotor this serves as as shortcut
            cbDoctor.SelectedValue = docID;

            //Set payment amound to invoice total
            txtAmount.Text = amount.ToString();

            // if the form was opened from the invoice window then close once a payment has been posted
            m_closeAfterCommit = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ManagePatientsForm frmPat = new ManagePatientsForm(true);
            DialogResult r = frmPat.ShowDialog();
            if (r == DialogResult.OK)
            {
                int patID = frmPat.SelectedID;
                Patient = m_patMgr.getPatient(frmPat.SelectedID);
            }
        }

        private Database.patient Patient
        {
            get
            {
                return m_patient;
            }
            set
            {
                if (value != null)
                {
                    m_patient = value;
                    txtPatientName.Text = m_patient.patFirstName + ", " + m_patient.patLastName;
                    invoiceBindingSource.DataSource = m_invMgr.getOutstandingInvoices(m_patient.patID);
                    if (m_patient.docID > 0)
                    {
                        cbDoctor.SelectedValue = m_patient.docID;
                    }

                    lblAccBal.Visible = true;
                    lblActualBalance.Visible = true;
                    String description = "";
                    decimal balance =  m_patient.AccountBalance;
                    if (balance < 0)
                    {
                        description = "Oweing:";
                    }
                    else if (balance > 0) 
                    {
                        description = "Credit:";
                    }
                    
                    lblActualBalance.Text = description + " $" +  balance.ToString();
                }
                else
                {
                    m_patient = null;
                    txtPatientName.Text = String.Empty;
                    invoiceBindingSource.DataSource = null;

                    lblAccBal.Visible = false;
                    lblActualBalance.Visible = false;
                }
            }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (m_patient != null)
            {
                decimal amount = Math.Round(Convert.ToDecimal(txtAmount.Text), 2);
                int payID = m_payMgr.insertPayment(amount, Convert.ToInt32(cbPaymentType.SelectedValue), m_patient.patID, (int)cbDoctor.SelectedValue, mcDate.SelectionStart);

                refreshGrid();

                m_patient = null;
                txtAmount.Text = String.Empty;
                Patient = null; // Clears patient object, combobox and text field
                cbPaymentType.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Select an client first");
            }

            if (m_closeAfterCommit) Close();
        }

        private void refreshGrid()
        {
            // refresh grid
            m_payMgr.refreshFromDataSource();
            paymentsViewModelBindingSource.DataSource = m_payMgr.getPaymentViewModelForDay(mcDate.SelectionStart);
            dgvPayments.Refresh();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utility.isCharNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text.Length == 0)
            {
                btnCommit.Enabled = false;
            }
            else
            {
                btnCommit.Enabled = true;
            }
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            Database.DoctorMgr docMgr = new Database.DoctorMgr();

            cbDoctor.DataSource = docMgr.getActiveDoctors();
            cbDoctor.ValueMember = "docID";
            cbDoctor.DisplayMember = "docFullName";

            if (m_patient != null)
            {
                cbDoctor.SelectedValue = m_patient.docID;
            }
        }

        private void mcDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            paymentsViewModelBindingSource.DataSource = m_payMgr.getPaymentViewModelForDay(mcDate.SelectionStart);
        }

        private void deletePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvPayments.SelectedRows.Count > 0)
            {
                DialogResult r = MessageBox.Show("Really delete payment?", "PatientManager", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int payID = (int)dgvPayments.SelectedRows[0].Cells[5].Value;
                    m_payMgr.deletePayment(payID);

                    refreshGrid();
                }
            }
        }

        private void changePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPayments.SelectedRows.Count > 0)
            {
                int payID = (int)dgvPayments.SelectedRows[0].Cells[5].Value;
                ChangePaymentDialog payDlg = new ChangePaymentDialog(payID, m_payMgr);
                DialogResult r = payDlg.ShowDialog();
                if (r == DialogResult.OK)
                {
                    refreshGrid();
                }
            }
        }

        private void generateRecieptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int payID = (int)dgvPayments.SelectedRows[0].Cells[5].Value;
            int patID = m_payMgr.getPayment(payID).patID;
            Reporting.PaymentReportForm pRpt = new Reporting.PaymentReportForm(patID,
                mcDate.SelectionStart, mcDate.SelectionStart.AddDays(1));
            pRpt.MdiParent = this.MdiParent;
            pRpt.Show();
        }

        private void cmsDateGrid_Opening(object sender, CancelEventArgs e)
        {
            if (dgvPayments.SelectedRows.Count == 0)
            {
                e.Cancel = true;
            }
        }
    }
}
