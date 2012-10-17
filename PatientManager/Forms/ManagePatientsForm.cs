using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;
using System.Data.Objects.DataClasses;

namespace PatientManager.Forms
{
    public partial class ManagePatientsForm : Form
    {
        public ManagePatientsForm(bool searchMode = false)
        {
            InitializeComponent();
            m_bSearchMode = searchMode;
            // If in search mode then turn off some buttons that arn't used
            if (m_bSearchMode)
            {
                tsbSelect.Visible = true;
                tsbAdd.Visible = false;
                tsbDelete.Visible = false;
                tsbEdit.Visible = false;
                dgvPatients.CellDoubleClick += new DataGridViewCellEventHandler(tsbSelect_Click);
            }
            else
            {
                dgvPatients.CellDoubleClick += new DataGridViewCellEventHandler(tsbEdit_Click);
            }
        }

        private void ManagePatients_Load(object sender, EventArgs e)
        {
            tscbFilterBy.SelectedIndex = 0;
            updateGrid();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            NewPatientForm frmNewPat = new NewPatientForm();
            frmNewPat.MdiParent = this.MdiParent;
            frmNewPat.Show();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you want to delete " +
                dgvPatients.SelectedRows[0].Cells[2].Value.ToString() + " " + 
                dgvPatients.SelectedRows[0].Cells[1].Value.ToString() + "?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                int patID = (int)dgvPatients.SelectedRows[0].Cells[0].Value;
                m_patMgr.deactiveatePatient(patID);

                /*
                Database.patient patient = (from pat in pmEntities.patients
                                                     where pat.patID == patID
                                                     select pat).First();
                patient.patActive = false;
                pmEntities.SaveChanges();
                */
                updateGrid();
            }
        }

        private void updateGrid()
        {
            patientBindingSource.DataSource = m_patMgr.getPatients();
            dgvPatients.Refresh();
        }

        private void dgvPatients_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 1 && dgvPatients.SelectedRows[0].Cells[0].Value != null)
            {
                tsbDelete.Enabled = true;
                m_nSelectedID = (int)dgvPatients.SelectedRows[0].Cells[0].Value;
            }
            else
            {
                tsbDelete.Enabled = false;
            }         
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count > 0)
            {
                int patID = (int)dgvPatients.SelectedRows[0].Cells[0].Value;

                Database.patient patient = m_patMgr.getPatient(m_nSelectedID);
                NewPatientForm frmNewPat = new NewPatientForm(patient);
                frmNewPat.MdiParent = MdiParent;
                frmNewPat.Show();
            }            
        }

        public int SelectedID
        {
            get
            {
                return m_nSelectedID;
            }
        }

        private void tsbSelect_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            // 
            if (txtFilter.Text == String.Empty)
            {
                // Also resets the binding adapter to have no filter
                updateGrid();
                return;
            }
            switch (tscbFilterBy.SelectedIndex)
            {
                // By first name
                case 1:
                    patientBindingSource.DataSource = m_patMgr.findPatientsByFirstNameLike(txtFilter.Text);
                    break;
                // By last name
                case 0:
                    patientBindingSource.DataSource = m_patMgr.findPatientsByLastNameLike(txtFilter.Text);
                    break;
                // By phone number
                case 2:
                    patientBindingSource.DataSource = m_patMgr.findPatientByPhoneNumber(txtFilter.Text);
                    break;
                // No filter
                default:
                    updateGrid(); // reset
                    break;
            }
        }

        private void tscbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter_TextChanged(sender, e);
        }

        // Refresh from database when focus regained
        private void ManagePatientsForm_Activated(object sender, EventArgs e)
        {
            m_patMgr.refreshFromDataSource();
            updateGrid();
            if (txtFilter.Text.Length > 0)
            {
                txtFilter_TextChanged(sender, e);
            }
            txtFilter.Focus();
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            m_patMgr.refreshFromDataSource();
            updateGrid();
        }

        private Database.PatientMgr m_patMgr = new Database.PatientMgr();
        private bool m_bSearchMode;
        private int m_nSelectedID = -1;
    }
}
