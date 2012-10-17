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
    public partial class InvoiceManagerForm : Form
    {
        public InvoiceManagerForm()
        {
            InitializeComponent();
            refreshGrid();
            txtStartDate.Text = m_startDate.ToShortDateString();
            txtEndDate.Text = m_endDate.ToShortDateString();
        }

        private Database.InvoiceMgr m_invMgr = Database.InvoiceMgr.Instance;
        private int m_selectedID = -1;
        private DateTime m_startDate = DateTime.Today.Date;
        private DateTime m_endDate = DateTime.Today.AddDays(1); // For date range picker

        private void dgvInvoices_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvInvoices.SelectedRows.Count > 0)
            {
                if (dgvInvoices.SelectedRows[0].Cells[0].Value != null)
                {
                    m_selectedID = (int)dgvInvoices.SelectedRows[0].Cells[0].Value;
                }
            }
        }

        private void dgvInvoices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            viewInvoice();
        }

        private void viewInvoice()
        {
            InvoiceForm frmInvoice = new InvoiceForm(m_selectedID);
            frmInvoice.MdiParent = MdiParent;
            frmInvoice.Show();
        }

        private void tsbSelect_Click(object sender, EventArgs e)
        {
            viewInvoice();
        }

        private void InvoiceManagerForm_Load(object sender, EventArgs e)
        {
            tscbFilterBy.SelectedIndex = 0;
        }

        private void InvoiceManagerForm_Activated(object sender, EventArgs e)
        {
            txtFilter.Focus();
            if (m_invMgr.DataChanged)
            {
                refreshGrid();
            }
        }

        private void refreshGrid()
        {
            m_invMgr.refreshFromDataSource();
            invoiceBindingSource.DataSource = m_invMgr.getInvoicesForGridWithDateRange(m_startDate, m_endDate);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.Text == String.Empty)
            {
                refreshGrid();
            }
            else
            {
                switch (tscbFilterBy.SelectedIndex)
                {
                    case 0:
                        invoiceBindingSource.DataSource = m_invMgr.getInvoicesForGridWithLikeLastName(txtFilter.Text, m_startDate, m_endDate);
                        break;
                    case 1:
                        invoiceBindingSource.DataSource = m_invMgr.getInvoicesForGridWithLikeFirstName(txtFilter.Text, m_startDate, m_endDate);
                        break;
                    case 2:
                        filterByDate();
                        break;
                    default:
                        break;
                }
            }
        }

        private void txtStartDate_Click(object sender, EventArgs e)
        {
            DatePickerDialog dpd = new DatePickerDialog();
            dpd.MaxDate = m_endDate;
            DialogResult r = dpd.ShowDialog();
            if (r == DialogResult.OK)
            {
                m_startDate = dpd.SelectedDate;
                txtStartDate.Text = m_startDate.ToShortDateString();
            }
            filterByDate();
        }

        private void txtEndDate_Click(object sender, EventArgs e)
        {
            DatePickerDialog dpd = new DatePickerDialog();
            dpd.MinDate = m_startDate;
            DialogResult r = dpd.ShowDialog();
            if (r == DialogResult.OK)
            {
                m_endDate = dpd.SelectedDate;
                txtEndDate.Text = m_endDate.ToShortDateString();
            }
            filterByDate();
        }

        private void filterByDate()
        {
            if (txtFilter.Text == String.Empty)
            {
                invoiceBindingSource.DataSource = m_invMgr.getInvoicesForGridWithDateRange(m_startDate, m_endDate);
            }
            else
            {
                invoiceBindingSource.DataSource = m_invMgr.getInvoicesForGridWithDateRange(m_startDate, m_endDate, txtFilter.Text);
            }

        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            refreshGrid();
            txtFilter_TextChanged(sender, e);
        }
    }
}
