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
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
        }

        public AppointmentForm(int appID, Database.AppointmentMgr appMgr)
        {
            m_bIsNew = false;
            InitializeComponent();
            AppointmentManager = appMgr;
            m_appointment = m_appMgr.getAppointment(appID);
            appointmentBindingSource.DataSource = m_appointment;

            // Issue binding these data sources so just
            // assign their selection manually here. Bit of a hack but oh well.
            appStatusIDComboBox.SelectedIndex = m_appointment.appStatusID;
            appRenewIntervalIDComboBox.SelectedIndex = (m_appointment.appRenewIntervalID != null) ? (int)m_appointment.appRenewIntervalID : -1;

            m_nPatientID = (int)m_appointment.patID;
            m_nAppID = appID;

            txtColour.BackColor = ColorTranslator.FromHtml(m_appointment.appColour);
        }

        public AppointmentForm(DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            appDateDateTimePicker.Value = startDate;
            dtTime.Value = startDate;
            numDuration.Value = Convert.ToDecimal((endDate - startDate).TotalMinutes);
        }

        private void resetColour()
        {
            Color c = ColorTranslator.FromHtml("#96AAFF");
            colorDialog1.Color = c;
            txtColour.BackColor = c;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (m_nPatientID == -1)
            {
                MessageBox.Show("No patient selection", "PatientManager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (docIDComboBox.SelectedValue == null || (int)docIDComboBox.SelectedValue == -1)
            {
                MessageBox.Show("No doctor selected", "Patient Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Database.appointment appointment;
            if (m_bIsNew)
            {
                appointment = new Database.appointment();
            }
            else
            {
                appointment = m_appointment;
            }

            appointment.appDate = combineDateAndTime(appDateDateTimePicker.Value, dtTime.Value);
            appointment.appDuration = (int)numDuration.Value;
            appointment.appStatusID = (int)appStatusIDComboBox.SelectedIndex;
            appointment.appNote = appNoteTextBox.Text;
            appointment.appDateCreate = DateTime.Now;
            appointment.appAutoRenew = appRenewIntervalIDComboBox.SelectedIndex != 0; // Old design - this really isn't needed
            appointment.appRenewIntervalID = appRenewIntervalIDComboBox.SelectedIndex;
            appointment.patID = m_nPatientID;
            appointment.docID = (int)docIDComboBox.SelectedValue;
            appointment.appColour = ColorTranslator.ToHtml(txtColour.BackColor);
            appointment.itryID = (int)cbType.SelectedValue;

            if (m_bIsNew)
            {
                m_appMgr.saveAppointment(appointment);
            }
            else
            {
                m_appMgr.updateAppointment();
            }

            m_bIsSaved = true;
            MessageBox.Show("Saved");
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult r;
            if (!m_bIsSaved)
            {
                r = MessageBox.Show("Save appointment?", "PatientManager", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (r == DialogResult.No)
                {
                    Close();
                }
                else if (r == DialogResult.Yes)
                {
                    btnSave_Click(sender, e);
                }
            }
            else
            {
                Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ManagePatientsForm frmPat = new ManagePatientsForm(true);
            DialogResult r = frmPat.ShowDialog();
            if(r == DialogResult.OK)
            {
                selectPatient(frmPat.SelectedID);
            }
        }

        private void selectPatient(int patID)
        {
            m_nPatientID = patID;
            m_currentPatient = m_patMgr.getPatient(m_nPatientID);
            txtPatientName.Text = m_currentPatient.patFirstName + ", " + m_currentPatient.patLastName;

            setDoctor();

        }

        private void setDoctor()
        {
            docIDComboBox.SelectedValue = (m_currentPatient.docID != null) ? m_currentPatient.docID : 0;
            txtColour.BackColor = ColorTranslator.FromHtml(m_currentPatient.doctor.docDefaultColour);
        }

        private void Appointment_Load(object sender, EventArgs e)
        {

            // Check if an app manager hasnt been set yet
            if (m_appMgr == null)
            {
                m_appMgr = new Database.AppointmentMgr();
            }

            docIDComboBox.DataSource = m_docMgr.getActiveDoctors();
            docIDComboBox.ValueMember = "docID";
            docIDComboBox.DisplayMember = "docFullName";
            
            // Set patient default doctor if not already set
            if (m_currentPatient != null)
            {
                setDoctor();
            }

            cbType.DataSource = m_appMgr.getAppointmentTypes();
            cbType.ValueMember = "itryID";
            cbType.DisplayMember = "itryName";
            //cbType.SelectedIndex = 0;

            // If the app if is -1 then this is a new appointment so set these 
            // combo boxes to index 0, other wise they are already set in the contructor
            if (m_nAppID == -1)
            {
                appStatusIDComboBox.SelectedIndex = 0;
                appRenewIntervalIDComboBox.SelectedIndex = 0;
            }
            else
            {
                docIDComboBox.SelectedValue = m_appointment.docID;
                cbType.SelectedValue = m_appointment.itryID;
            }

        }

        /// <summary>
        /// Combines 2 datetime objects. One hold the date the other holds the time
        /// </summary>
        /// <param name="date">Date</param>
        /// <param name="time">Time of day</param>
        /// <returns></returns>
        private DateTime combineDateAndTime(DateTime date, DateTime time)
        {
            return new DateTime(date.Year,
                date.Month, date.Day, time.Hour, time.Minute, time.Second);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            txtColour.BackColor = colorDialog1.Color;
        }

        private void docIDComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (docIDComboBox.Items.Count > 0)
            {
                if (docIDComboBox.SelectedValue != null)
                {
                    Database.doctor d = m_docMgr.getDoctor((int)docIDComboBox.SelectedValue);
                    if (d != null)
                    {
                        txtColour.BackColor = ColorTranslator.FromHtml(d.docDefaultColour);
                    }
                }
            }
        }

        public int PatientID
        {
            set
            {
                selectPatient(value);
            }
        }

        public Database.AppointmentMgr AppointmentManager
        {
            set
            {
                m_appMgr = value;
            }
        }

        // ID of the paient the appointment is for
        private int m_nPatientID = -1; // -1 is an invalid id
        private int m_nAppID = -1; // Will stay as -1 if record is new
        private Database.patient m_currentPatient;
        private Database.appointment m_appointment;
        private Database.PatientMgr m_patMgr = new Database.PatientMgr();
        private Database.DoctorMgr m_docMgr = new Database.DoctorMgr();
        private Database.AppointmentMgr m_appMgr;
        private bool m_bIsNew = true;
        private bool m_bIsSaved = false;


    }
}
