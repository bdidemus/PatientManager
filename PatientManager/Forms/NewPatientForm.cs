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
    /// <summary>
    /// This calss needs to be cleaning up since it's the first one I wrote while I was refamiliarizing myself with
    /// .net again. There is some really bad code in here.
    /// </summary>
    public partial class NewPatientForm : Form
    {
        private Database.PatientManagerEntities m_context = new Database.PatientManagerEntities();
        private Database.PatientMgr m_patMgr = new Database.PatientMgr();
        private Database.patient m_patient;
        private bool m_isNewMode = true;

        public NewPatientForm()
        {
            InitializeComponent();
        }

        public NewPatientForm(Database.patient patient)
        {
            InitializeComponent();

            // Set window form name to patients name 
            this.Text = patient.patLastName + ", " + patient.patFirstName;
            m_patient = patient;
            m_isNewMode = false; // Update mode


            // Turn on update only tool strip buttons
            tsbAppointments.Visible = true;
            tsbBill.Visible = true;
            tsbStats.Visible = true;
        }

        private void fillFields()
        {
            txtID.Text = m_patient.patID.ToString();
            txtCreated.Text = m_patient.patDateCreate.ToShortDateString();
            txtFirstName.Text = m_patient.patFirstName;
            txtLastName.Text = m_patient.patLastName;
            cbSex.SelectedIndex = Convert.ToInt32(m_patient.patSex);
            dtBirthday.Value = (m_patient.patBirthday != null) ? m_patient.patBirthday.Value : DateTime.Now;
            txtReferedBy.Text = m_patient.patReferedBy;
            cbCountry.SelectedValue = m_patient.iso;
            txtProv.Text = m_patient.patProv;
            txtFlag.Text = m_patient.patFlag;
            txtPCode.Text = m_patient.patPCode;
            txtCity.Text = m_patient.patCity;
            txtAddress.Text = m_patient.patAddress;
            txtAddress2.Text = m_patient.patAddress2;
            txtPhone.Text = m_patient.patPhoneNumber;
            txtSecPhone.Text = m_patient.patSecNumber;
            txtMobile.Text = m_patient.patMobileNumber;
            txtHealthCard.Text = m_patient.patHealthCard;
            //cbInsProvider.SelectedValue = (m_patient.ipID != null) ? m_patient.ipID : 0;
            txtInsrProv.Text = m_patient.patInsuranceProv;
            txtInsurranceNumber.Text = m_patient.patInsuranceNum;
            if (m_patient.docID != null)
            {
                cbDoctors.SelectedValue = m_patient.docID;
            }
            txtNotes.Text = m_patient.patNotes;

            decimal total = m_patient.AccountBalance;

            if(total > 0)
            {
                tslAccTotal.ForeColor = Color.Green;
            }
            else if(total < 0)
            {
                tslAccTotal.ForeColor = Color.Red;
            }

            tslAccTotal.Text = "$" + total;
        }

        private void NewPatient_Load(object sender, EventArgs e)
        {
            cbCountry.DisplayMember = "name";
            cbCountry.ValueMember = "ISO";
            cbCountry.DataSource = ((ObjectQuery)(from countries in m_context.countries
                                    select new { ISO = countries.iso, name = countries.name })).Execute(MergeOption.OverwriteChanges);
            cbCountry.SelectedValue = "CA";

            cbDoctors.DisplayMember = "docName";
            cbDoctors.ValueMember = "docID";
            cbDoctors.DataSource = ((ObjectQuery)(from doctors in m_context.doctors
                                                  where doctors.docActive == true
                                                  select new { docID = doctors.docID, docName = doctors.docFirstName + " " + doctors.docLastName })).Execute(MergeOption.OverwriteChanges);

            if (!m_isNewMode)
            {
                pastAppointmentsModelBindingSource.DataSource = m_patMgr.getPastAppointments(m_patient.patID);
                Database.InvoiceMgr invMgr = Database.InvoiceMgr.Instance;
                List<Database.Reporting.PatientAccountHistoryModel> hist = Database.Reporting.PatientAccountHistoryModel.getPatientHistoryModel(
                    m_patient.patID).ToList();
                patientAccountHistoryModelBindingSource.DataSource = hist;
                //Populate the from details with the current patient data
                fillFields();
            }
            else
            {
                // Don;t need these tabs if creating a new patient
                tabPatient.TabPages.Remove(tpAppointments);
                tabPatient.TabPages.Remove(tpBills);
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {   
            // Form validation
            if (!ValidateChildren())
            {
                return;
            }

            //Setup the patient table object
            Database.patient patient;
            if (m_isNewMode)
            {
                 patient = new Database.patient();
            }
            else
            {
                 // Since I wrote this class all stupid and have context mixing issues that hack needs to be here/
                 // I'll fix it later
                 patient = (from pat in m_context.patients where pat.patID == m_patient.patID select pat).First();
            }
            
            //Inject the data from winform
            patient.patFirstName = txtFirstName.Text;
            patient.patLastName = txtLastName.Text;
            patient.patSex = cbSex.SelectedIndex == 1;
            patient.patHealthCard = txtHealthCard.Text;
            //if(cbInsProvider.SelectedIndex != 0)
            //{
            //    patient.patInsuranceNum = txtInsurranceNumber.Text;
            //    patient.ipID = Convert.ToInt32(cbInsProvider.SelectedValue);
            //}
            patient.patInsuranceProv = txtInsrProv.Text;
            patient.patAddress = txtAddress.Text;
            patient.patAddress2 = txtAddress2.Text;
            patient.patPhoneNumber = txtPhone.Text;
            patient.patMobileNumber = txtMobile.Text;
            patient.patSecNumber = txtSecPhone.Text;
            patient.patPCode = txtPCode.Text;
            patient.patFlag = txtFlag.Text;
            patient.patBirthday = dtBirthday.Value;
            patient.patReferedBy = txtReferedBy.Text;
            patient.patCity = txtCity.Text;
            patient.iso = (String)cbCountry.SelectedValue;
            patient.patProv = txtProv.Text;
            patient.patNotes = txtNotes.Text;
            patient.docID = (cbDoctors.SelectedIndex != -1) ? Convert.ToInt32(cbDoctors.SelectedValue) : 1;
            patient.patActive = true;
            patient.patDateCreate = DateTime.Now;

            // Save the newly created parient to the entity dataset
            if (m_isNewMode)
            {
                m_context.AddTopatients(patient);
            }
            m_context.SaveChanges();

            MessageBox.Show("Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Utility.clearControls(Controls);
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (txtFirstName.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(txtFirstName, "Missing first name");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (txtLastName.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(txtLastName, "Last name cannot be blank");
            }
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCountry.SelectedValue.ToString() == "US")
            {
                lblPostal.Text = "Zip:";
                lblProvince.Text = "State:";
            }
            else
            {
                lblPostal.Text = "Postal:";
                lblProvince.Text = "Province:";
            }
        }

        private void tsbAppointments_Click(object sender, EventArgs e)
        {
            AppointmentForm appFrm = new AppointmentForm();
            appFrm.PatientID = m_patient.patID;
            appFrm.MdiParent = MdiParent;
            appFrm.Show();
        }

        private void tsmiAccSummary_Click(object sender, EventArgs e)
        {
            if (m_patient != null)
            {
                Reporting.PatientAccountSummaryDialog dlg = new Reporting.PatientAccountSummaryDialog(m_patient.patID, false);
                dlg.ShowDialog();
            }
        }

        private void tsbBill_Click(object sender, EventArgs e)
        {
            InvoiceForm invForm = new InvoiceForm(m_patient.patID, true);
            invForm.MdiParent = MainParent.MainMDIParent;
            invForm.Show();
        }

        private void tsbStats_ButtonClick(object sender, EventArgs e)
        {
            tsbStats.ShowDropDown();
        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporting.PaymentReportRangePicker picker = new Reporting.PaymentReportRangePicker(m_patient.patID);
            picker.ShowDialog();
        }
    }
}
