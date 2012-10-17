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
    public partial class DoctorsForm : Form
    {
        private bool m_bIsNew = true;
        private Database.PatientManagerEntities m_context = new Database.PatientManagerEntities();
        private Database.DoctorMgr m_docMgr = new Database.DoctorMgr();

        public DoctorsForm()
        {
            InitializeComponent();
        }

        private void Doctors_Load(object sender, EventArgs e)
        {
            doctorGridBindingSource.DataSource = m_docMgr.getActiveDoctors();
            dtDecComboBox.DataSource = m_context.doc_type;
            dtDecComboBox.DisplayMember = "dtDec";
            dtDecComboBox.ValueMember = "docTypeID";

            resetColour();
        }

        private void resetColour()
        {
            Color c = ColorTranslator.FromHtml("#96AAFF");
            colorDialog1.Color = c;
            txtColour.BackColor = c;
        }

        private void tsbNewDoctor_Click(object sender, EventArgs e)
        {
            m_bIsNew = true;
            tsbDelete.Enabled = false;
            resetColour();
            doctorBindingSource.DataSource = typeof(Database.doctor);

            Utility.clearControls(Controls);
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(docIDTextBox.Text) == 1)
            {
                MessageBox.Show("Cannot modify default doctor");
                return;
            }

            doctorBindingSource.EndEdit();

            // Form validation
            if (!ValidateChildren())
            {
                return;
            }

            Database.doctor doctor;
            if (m_bIsNew)
            {
                doctor = new Database.doctor();         
            }
            else
            {
                doctor = m_docMgr.getDoctor(Convert.ToInt32(docIDTextBox.Text));
            }
            doctor.docFirstName = docFirstNameTextBox.Text;
            doctor.docLastName = docLastNameTextBox.Text;
            doctor.docAddress = docAddressTextBox.Text;
            doctor.docLicence = docLicenceTextBox.Text;
            doctor.docLicence2 = txtLicence2.Text;
            doctor.docCity = docCityTextBox.Text;
            doctor.docOfficeNumber = docOfficeNumberTextBox.Text;
            doctor.docMobileNumber = docMobileNumberTextBox.Text;
            doctor.dovSecondaryNumber = docSecondaryNumberTextBox.Text;
            doctor.docPCode = docPCodeTextBox.Text;
            doctor.docTypeID = (dtDecComboBox.SelectedValue != null) ? (int?)dtDecComboBox.SelectedValue : null;
            doctor.docDateCreated = DateTime.Now;
            doctor.docActive = true;
            if (colorDialog1.Color != null)
            {
                doctor.docDefaultColour = ColorTranslator.ToHtml(colorDialog1.Color);
            }

            if (m_bIsNew)
            {
                m_docMgr.insertNewDoctor(doctor);
            }
            else
            {
                Database.ADatabaseInteractor.Context.SaveChanges();
            }

            doctorBindingSource.DataSource = typeof(Database.doctor);
            Utility.clearControls(Controls);
            refreshGrid();
        }

        private void docFirstNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (docFirstNameTextBox.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(docFirstNameTextBox, "First name is required");
            }
        }

        private void dgvDoctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            m_bIsNew = false;
            int docID = Convert.ToInt32(dgvDoctors.SelectedRows[0].Cells[0].Value);
            Database.doctor doc = m_docMgr.getDoctor(docID);
            doctorBindingSource.DataSource = doc;
            tsbDelete.Enabled = true;
            if (doc.docDefaultColour != null || doc.docDefaultColour != String.Empty)
            {
                txtColour.BackColor = ColorTranslator.FromHtml(doc.docDefaultColour);
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(docIDTextBox.Text) == 1)
            {
                MessageBox.Show("Cannot delete the clinic doctor", "PatientManager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult r = MessageBox.Show("Delete selected doctor?\nThis operation can be undone but the feature is not yet implemented.",
                "Doctors", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                m_docMgr.softDeleteDoctor(Convert.ToInt32(docIDTextBox.Text));
                refreshGrid();
                doctorBindingSource.DataSource = typeof(Database.doctor);
                Utility.clearControls(gbDetails.Controls);
                m_bIsNew = true;
            }
            tsbDelete.Enabled = false;
        }

        private void refreshGrid()
        {
            m_docMgr.refreshFromDataSource();
            dgvDoctors.DataSource = m_docMgr.getActiveDoctors();
        }

        private void txtColour_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            txtColour.BackColor = colorDialog1.Color;
        }
    }
}
