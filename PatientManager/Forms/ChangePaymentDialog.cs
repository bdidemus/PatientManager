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
    public partial class ChangePaymentDialog : Form
    {
        private Database.payment m_payment;
        private Database.PaymentMgr m_payMgr;

        public ChangePaymentDialog(int payID, Database.PaymentMgr payMgr)
        {
            InitializeComponent();
            m_payMgr = payMgr;
            m_payment = m_payMgr.getPayment(payID);
            txtAmount.Text = m_payment.payAmount.ToString();

            paymentTypeBindingSource.DataSource = m_payMgr.getPaymentTypes();
        }

        private void ChangePaymentDialog_Load(object sender, EventArgs e)
        {
            dtpDate.Value = m_payment.payDate;

            Database.DoctorMgr docMgr = new Database.DoctorMgr();

            cbDoctor.DataSource = docMgr.getActiveDoctors();
            cbDoctor.ValueMember = "docID";
            cbDoctor.DisplayMember = "docFullName";

            cbDoctor.SelectedValue = m_payment.docID;

            cbPaymentType.SelectedValue = m_payment.ptID;

            Database.InvoiceMgr invMgr = Database.InvoiceMgr.Instance;

            invoiceBindingSource.DataSource = invMgr.getOutstandingInvoices(m_payment.patID);
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text != String.Empty)
            {
                m_payMgr.changePayment(m_payment, Convert.ToDecimal(txtAmount.Text),
                    (int)cbDoctor.SelectedValue, (int)cbPaymentType.SelectedValue, dtpDate.Value);

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Amount cannot be empty");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
