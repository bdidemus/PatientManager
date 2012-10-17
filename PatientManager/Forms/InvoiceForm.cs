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
    public partial class InvoiceForm : Form
    {

        private int m_nPatientID = -1;
        private Database.patient m_currentPatient;
        private Database.invoice m_currentInvoice;
        private Database.PatientMgr m_patMgr = new Database.PatientMgr();
        private InvoiceBuilder m_invBuilder;
        private bool m_bIsUpdate = false;

        public InvoiceForm()
        {
            InitializeComponent();
            cbStatus.SelectedIndex = 0;
            m_invBuilder = new InvoiceBuilder();
        }

        public InvoiceForm(int patID, int itryID)
        {
            InitializeComponent();
            cbStatus.SelectedIndex = 0;

            m_invBuilder = new InvoiceBuilder();

            m_currentInvoice = m_invBuilder.Invoice;

            selectPatient(patID);

            addNewRow(itryID);
        }

        public InvoiceForm(int invID)
        {
            InitializeComponent();
            // Constuct invoice builder with premade invoice
            m_invBuilder = new InvoiceBuilder(invID);
            m_currentInvoice = m_invBuilder.Invoice;
            // Set binding source
            invoiceBindingSource.DataSource = m_currentInvoice;

            dtpBillDate.Value = m_currentInvoice.invDate;
            cbStatus.SelectedIndex = (m_currentInvoice.invStatus != null) ? (int)m_currentInvoice.invStatus : 0;

            selectPatient(m_currentInvoice.patID);
            // Read only mode since this invoice is already saved
            m_bIsUpdate = true;

            tsbDelete.Enabled = true;
            tsbSavePDF.Enabled = true;
            tsbStatement.Enabled = true;

            populateDataGrid();
        }

        public InvoiceForm(int patID, bool isPatID)
        {
            InitializeComponent();
            cbStatus.SelectedIndex = 0;

            m_invBuilder = new InvoiceBuilder();

            m_currentInvoice = m_invBuilder.Invoice;

            selectPatient(patID);
        }

        private void populateDataGrid()
        {
            // Populate the data grid with all line items
            int i = 0;
            foreach (var line in m_currentInvoice.inv_line)
            {
                int index = dgvInvoice.Rows.Add();
                DataGridViewRow dgr = (DataGridViewRow)dgvInvoice.Rows[index];
                dgr.Cells[0].Value = ++i;
                dgr.Cells[1].Value = line.inventory.itryName;
                dgr.Cells[2].Value = line.inventory.itryDesc;
                dgr.Cells[3].Value = line.linePrice;
                dgr.Cells[4].Value = line.itryQty;
            }
        }

        ///// <summary>
        ///// Prevents previously saved invoices from being modified
        ///// </summary>
        //private void enableReadOnlyMode()
        //{
            
        //    btnSearch.Enabled = false;
        //    dgvInvoice.ReadOnly = true;
        //    dgvInvoice.AllowUserToAddRows = false;
        //    dgvInvoice.AllowUserToDeleteRows = false;
        //    tsbAddItem.Enabled = false;
        //    tsbRemoveRow.Enabled = false;
        //    cbDoctor.Enabled = false;
        //}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ManagePatientsForm frmPat = new ManagePatientsForm(true);
            DialogResult r = frmPat.ShowDialog(this);
            if (r == DialogResult.OK)
            {
                selectPatient(frmPat.SelectedID);
                cbDoctor.SelectedValue = m_currentPatient.docID;
            }
        }

        public void selectPatient(int patID)
        {
            m_nPatientID = patID;
            m_currentPatient = m_patMgr.getPatient(m_nPatientID);
            txtPatientName.Text = m_currentPatient.patFirstName + ", " + m_currentPatient.patLastName;
        }

        private void dgvInvoice_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvInvoice.Rows[e.RowIndex].Cells[0].Value = dgvInvoice.Rows.Count-1;
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            Database.DoctorMgr docMgr = new Database.DoctorMgr();

            cbDoctor.DataSource = docMgr.getActiveDoctors();
            cbDoctor.ValueMember = "docID";
            cbDoctor.DisplayMember = "docFullName";

            if (m_bIsUpdate)
            {
                cbDoctor.SelectedValue = m_currentInvoice.docID;
            }
            else if (m_currentPatient != null)
            {
                cbDoctor.SelectedValue = m_currentPatient.docID;
            }
        }

        private void dgvInvoice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                addNewRow();
            }
        }

        private void dgvInvoice_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Prevents editing rows that don't have a part associated yet, ie the row doesn't exist
            if (dgvInvoice.Rows[e.RowIndex].Cells[1].Value == null)
            {
                e.Cancel = true;
            }
        }

        private void addNewRow()
        {
            ManageInventoryForm frmMngInv = new ManageInventoryForm(true);
            frmMngInv.ShowDialog();
            if (frmMngInv.DialogResult == DialogResult.OK)
            {
                // Item canot already be on the invoice
                if (!m_invBuilder.itemAlreadyOnInvoice(frmMngInv.SelectedID))
                {
                    int rowid = dgvInvoice.Rows.Add();
                    int invID = (m_currentInvoice == null) ? -1 : m_currentInvoice.invID;
                    Database.inventory newItem = m_invBuilder.addNewItem(frmMngInv.SelectedID, 1);
                    dgvInvoice.Rows[rowid].Cells[1].Value = newItem.itryName;
                    dgvInvoice.Rows[rowid].Cells[2].Value = newItem.itryDesc;
                    dgvInvoice.Rows[rowid].Cells[3].Value = newItem.itrySellingPrive;
                    dgvInvoice.Rows[rowid].Cells[4].Value = 1;
                }
            }
        }

        // dupe code, im lazy right now
        private void addNewRow(int itryID)
        {
            // Item canot already be on the invoice
            if (!m_invBuilder.itemAlreadyOnInvoice(itryID))
            {
                int rowid = dgvInvoice.Rows.Add();
                int invID = (m_currentInvoice == null) ? -1 : m_currentInvoice.invID;
                Database.inventory newItem = m_invBuilder.addNewItem(itryID, 1);
                dgvInvoice.Rows[rowid].Cells[1].Value = newItem.itryName;
                dgvInvoice.Rows[rowid].Cells[2].Value = newItem.itryDesc;
                dgvInvoice.Rows[rowid].Cells[3].Value = newItem.itrySellingPrive;
                dgvInvoice.Rows[rowid].Cells[4].Value = 1;
            }
        }

        private void removeRow()
        {
            // Make sure not trying to delete the row for new records
            if (dgvInvoice.SelectedRows.Count > 0 && !dgvInvoice.SelectedRows[0].IsNewRow)
            {
                m_invBuilder.removeLine((int)dgvInvoice.SelectedRows[0].Cells[0].Value-1);
                dgvInvoice.Rows.Remove(dgvInvoice.SelectedRows[0]);
            }
        }

        private void tsbAddItem_Click(object sender, EventArgs e)
        {
            addNewRow();
        }

        private void dgvInvoice_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInvoice.SelectedRows.Count == 0)
            {
                tsbRemoveRow.Enabled = false;
            }
            else
            {
                tsbRemoveRow.Enabled = true;
            }
        }

        private void tsbRemoveRow_Click(object sender, EventArgs e)
        {
            removeRow();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            //if (!m_bIsUpdate)
            //{
            if (!ValidateChildren())
            {
                return;
            }
            if (cbDoctor.SelectedIndex == -1)
            {
                MessageBox.Show("A doctor needs to be selected");
                return;
            }

            // Go through the rows and update invoice builder values to possible user entered values
            foreach (DataGridViewRow row in dgvInvoice.Rows)
            {
                if (!row.IsNewRow)
                {
                    try
                    {
                        m_invBuilder.modifyItemPrice(row.Index, Convert.ToDecimal(dgvInvoice.Rows[row.Index].Cells[3].Value));
                        m_invBuilder.modifyItemQuanity(row.Index, Convert.ToInt32(dgvInvoice.Rows[row.Index].Cells[4].Value));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Invalid values given, use only numbers for Quantity and price");
                        return;
                    }
                }
            }

            int invID = m_invBuilder.saveInvoice(m_nPatientID, cbStatus.SelectedIndex, (int)cbDoctor.SelectedValue, dtpBillDate.Value);
            if (invID == -1) // Error occured
            {
                MessageBox.Show("An unknown error occured saving the invoice", "Something bad happened", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // enable the delete and reprot button
                tsbSavePDF.Enabled = true;
                tsbDelete.Enabled = true;

                // Position the current invoice as the datasource of the form;
                m_currentInvoice = m_invBuilder.Invoice;
                invoiceBindingSource.DataSource = m_currentInvoice;
                
                // Set some flags to indicate update mode now
                m_bIsUpdate = true;
                m_invBuilder.IsSaved = true; 

                DialogResult r = MessageBox.Show("Invoice commited to " + m_currentPatient.FullName + "'s account\nWould you like to process a payment now?",
                    "Payout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    PaymentForm frmPay = new PaymentForm(m_currentPatient.patID,
                        Database.InvoiceMgr.Instance.getInvoiceTotal(m_currentInvoice), invID, m_currentInvoice.docID);
                    frmPay.ShowDialog();
                }

                r = MessageBox.Show("Print reciept?", "PatientManager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    generateInvoiceReport(true);
                }

                r = MessageBox.Show("Generate patient account statement?", "PatientManager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    generateAccountStatement(true);
                }
            }

            // Used for when called a dialog to check if the invoice was saved successfully
            DialogResult = DialogResult.OK;
        }

        private void txtPatientName_Validating(object sender, CancelEventArgs e)
        {
            if (txtPatientName.Text == String.Empty)
            {
                e.Cancel = true;
                errorProvider.SetError(txtPatientName, "Missing patient field");
            }
        }

        private void dgvInvoice_Validating(object sender, CancelEventArgs e)
        {
            if (dgvInvoice.Rows.Count == 1)
            {
                e.Cancel = true;
                MessageBox.Show("Unable to save blank invoice");
            }
        }

        private void generateInvoiceReport(bool asDialog)
        {
            if (m_currentInvoice != null)
            {
                Reporting.InvoiceReportForm rf = 
                    new Reporting.InvoiceReportForm(m_currentInvoice.invID, m_nPatientID, DateTime.MinValue, DateTime.MaxValue);

                if (asDialog)
                {
                    rf.ShowDialog();
                }
                else
                {
                    rf.MdiParent = MdiParent;
                    rf.Show();
                }
            }
            else
            {
                DialogResult r = MessageBox.Show("Invoice must be commited before generating a report\nCommit invoice?",
                    "Patient Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    tsbSave.PerformClick();
                }
            }
        }

        private void generateAccountStatement(bool asDialog)
        {
            if (m_currentInvoice != null && m_currentInvoice.patient != null)
            {
                Reporting.PatientAccountSummaryDialog dlg = new Reporting.PatientAccountSummaryDialog(m_currentInvoice.patient.patID, asDialog);
                dlg.ShowDialog();
            }
        }

        private void tsbSavePDF_Click(object sender, EventArgs e)
        {
            generateInvoiceReport(false);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (m_bIsUpdate)
            {
                DialogResult r = MessageBox.Show("Are you sure you want to delete this invoice?", "PatientManger",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    m_invBuilder.deleteInvoice(m_currentInvoice);
                    Close();
                }            
            }
        }

        private void tsbStatement_Click(object sender, EventArgs e)
        {
            generateAccountStatement(false);
        }

    }
}
