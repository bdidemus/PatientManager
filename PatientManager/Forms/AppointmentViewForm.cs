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
    public partial class AppointmentViewForm : Form
    {
        private List<Calendar.Appointment> m_appointments;
        private Database.AppointmentMgr m_appMgr = new Database.AppointmentMgr();
        private Database.DoctorMgr m_docMgr = new Database.DoctorMgr();

        public AppointmentViewForm()
        {
            InitializeComponent();
            dvAppointments.StartDate = DateTime.Now;
            dvAppointments.StartHour = 6; // My day starts much much later than this
        }

        private void AppointmentViewForm_Load(object sender, EventArgs e)
        {
            doctorBindingSource.DataSource = m_docMgr.getActiveDoctors();
            cbDoctors.DisplayMember = "docFullName";
            cbDoctors.SelectedIndex = -1;

            fillAppointments();
        }

        private void mcCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            dvAppointments.StartDate = mcCalendar.SelectionStart;
            fillAppointments();
        }

        private void newAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppointmentForm app;
            // Determin if the user made a selection on the calendar to be passed to the new
            // appointment form. By default the dayview control sets the date to an abritray value so this
            // if statement checks if the selection is actually valid
            if (dvAppointments.SelectionStart >= dvAppointments.StartDate)
            {
                app = new AppointmentForm(dvAppointments.SelectionStart, dvAppointments.SelectionEnd);
            }
            else
            {
                app = new AppointmentForm();
            }
            app.AppointmentManager = m_appMgr;
            app.ShowDialog(this);
            fillAppointments();
        }

        /// <summary>
        /// 
        /// </summary>
        private void fillAppointments()
        {
            if (cbDoctors.SelectedIndex == -1)
            {
                m_appointments = m_appMgr.fillCalenderAppointments(mcCalendar.SelectionStart);
                dvAppointments.Invalidate();
            }
            else
            {
                fillAppointments((int)cbDoctors.SelectedValue);
            }
        }

        private void fillAppointments(int docID)
        {
            m_appMgr.refreshFromDataSource();
            m_appointments = m_appMgr.fillCalenderAppointments(mcCalendar.SelectionStart, docID);
            dvAppointments.Invalidate();
        }

        private void dvAppointments_ResolveAppointments(object sender, Calendar.ResolveAppointmentsEventArgs args)
        {
            if (m_appointments != null)
            {
                args.Appointments = m_appointments;
            }
        }

        /// <summary>
        /// Quick helper function that gets the date differnece. Used when calulating 
        /// what appointments date range need to be grabed
        /// </summary>
        /// <returns></returns>
        private int getDaySpan()
        {
            return dvAppointments.DaysToShow - 1;
        }

        private void dvAppointments_AppointmentMove(object sender, Calendar.AppointmentEventArgs e)
        {
            m_appMgr.changeAppointmentDate(e.Appointment.AppointmentID, e.Appointment.StartDate,
                e.Appointment.EndDate);
        }

        // generate invoice on double click
        private void dvAppointments_DoubleClick(object sender, EventArgs e)
        {
            if (dvAppointments.SelectedAppointment != null)
            {
                cmiCreateBill_Click(sender, e);
            }
        }

        private void contextMenuStripNew_Opening(object sender, CancelEventArgs e)
        {
            bool enableMenuItems = dvAppointments.SelectedAppointment != null;
            
            cmiEditApp.Enabled = enableMenuItems;
            cmiDeleteApp.Enabled = enableMenuItems;
            cmiCreateBill.Enabled = enableMenuItems;
            cmiMarkAs.Enabled = enableMenuItems;
            cmiBookNext.Enabled = enableMenuItems;
            cmiOpenPaitent.Enabled = enableMenuItems;

        }

        private void cmiEditApp_Click(object sender, EventArgs e)
        {
            AppointmentForm frmApp = new AppointmentForm(dvAppointments.SelectedAppointment.AppointmentID, m_appMgr);
            frmApp.ShowDialog(this);
            fillAppointments();
        }

        private void dvAppointments_SelectionChanged(object sender, EventArgs e)
        {
            if (dvAppointments.SelectedAppointment != null)
            {
                tsbDelete.Enabled = true;
                try
                {
                    lblAccBalance.Text = "$" + m_appMgr.getAppointment(dvAppointments.SelectedAppointment.AppointmentID)
                        .patient.AccountBalance.ToString();
                }
                catch(Exception ex)
                {
                }
            }
            else
            {
                tsbDelete.Enabled = false;
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you want to delete this appointment?", "PatientManager", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (dvAppointments.SelectedAppointment != null)
                {
                    m_appMgr.deleteAppointment(dvAppointments.SelectedAppointment.AppointmentID);
                }
                fillAppointments();
            }
        }

        private void cmiCreateBill_Click(object sender, EventArgs e)
        {
            Database.appointment app = m_appMgr.getAppointment(dvAppointments.SelectedAppointment.AppointmentID);
            int patID = (int)app.patID;
            int itryID = (int)app.itryID;
            InvoiceForm invFrm = new InvoiceForm(patID, itryID);
            DialogResult r = invFrm.ShowDialog();
            if (r == DialogResult.OK)
            {
                changeAppStatus(2);
            }
            m_appMgr.updateAppointment();
            updateFormData();
        }

        private void cbDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDoctors.SelectedValue != null)
            {
                fillAppointments((int)cbDoctors.SelectedValue);
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            cbDoctors.SelectedIndex = -1;
            fillAppointments();
        }

        private void AppointmentViewForm_Activated(object sender, EventArgs e)
        {
            updateFormData();
        }

        private void updateFormData()
        {
            if (m_appMgr.DataChanged)
            {
                fillAppointments();
            }
        }

        private void notArrivedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeAppStatus(0);
        }

        private void arrivedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeAppStatus(1);
        }

        private void billedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeAppStatus(2);
        }

        private void canceledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeAppStatus(3);
        }

        private void changeAppStatus(int statusID)
        {
            m_appMgr.changeAppointmentStatus(dvAppointments.SelectedAppointment.AppointmentID, statusID);
            updateFormData();
            if (statusID == 2)
            {
                promptToBookNextAppointment();
            }
        }

        private void promptToBookNextAppointment()
        {
            if (dvAppointments.SelectedAppointment != null)
            {
                promptToBookNextAppointment(dvAppointments.SelectedAppointment.AppointmentID, dvAppointments.SelectedAppointment.StartDate);
            }
        }

        private void promptToBookNextAppointment(int appID, DateTime startDate)
        {
            DialogResult r = MessageBox.Show("Would you like to book this patients next appointments?", "PatientManager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                bookNextAppointment(appID, startDate);
            }
        }

        private void bookNextAppointment()
        {
            bookNextAppointment(dvAppointments.SelectedAppointment.AppointmentID, dvAppointments.SelectedAppointment.StartDate);
        }

        private void bookNextAppointment(int appID, DateTime startDate)
        {
            BookNextAppDialog bookDlg = new BookNextAppDialog(startDate, appID);
            DialogResult res = bookDlg.ShowDialog();
            if (res == DialogResult.OK)
            {
                if (!m_appMgr.bookNextAppointments(appID, bookDlg.WeekOffset, bookDlg.DaysSelected, bookDlg.Times, bookDlg.AppTypes))
                {
                    MessageBox.Show("There was a problem saving the appointments", "PatientManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmiBookNext_Click(object sender, EventArgs e)
        {
            bookNextAppointment();
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            fillAppointments();
        }

        private void openPatientRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database.patient pat = m_appMgr.getAppointment(dvAppointments.SelectedAppointment.AppointmentID).patient;
            NewPatientForm patFrm = new NewPatientForm(pat);
            patFrm.MdiParent = MainParent.MainMDIParent;
            patFrm.Show();
        }
    }
}
