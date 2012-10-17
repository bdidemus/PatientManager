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
    public partial class BookNextAppDialog : Form
    {
        public BookNextAppDialog(DateTime prevTime, int appID)
        {
            InitializeComponent();
            foreach(Control ctrl in gbMain.Controls)
            {
                if (ctrl is DateTimePicker)
                {
                    ((DateTimePicker)ctrl).Value = prevTime;
                }
            }

            m_prevTypeID = (int)m_appMgr.getAppointment(appID).itryID; // inventory item of last appoinment
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            
            generateAppTypeArray();

            Close();
        }

        private void generateAppTypeArray()
        {
            m_appTypes[0] = (int)cbAppTypeMon.SelectedValue;

            m_appTypes[1] = (int)cbAppTypeTue.SelectedValue;
 
            m_appTypes[2] = (int)cbAppTypeWed.SelectedValue;
        
            m_appTypes[3] = (int)cbAppTypeThu.SelectedValue;

            m_appTypes[4] = (int)cbAppTypeFri.SelectedValue;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public bool[] DaysSelected { get { return m_bDaysSelected; } }
        public DateTime[] Times { get { return m_times; } }
        public int[] AppTypes { get { return m_appTypes; } }
        public int WeekOffset { get { return (int)this.weekOffset.Value; } }

        private bool[] m_bDaysSelected = new bool[5];
        private DateTime[] m_times = new DateTime[5];
        private int[] m_appTypes = new int[5];

        private Database.AppointmentMgr m_appMgr = new Database.AppointmentMgr();
        private int m_prevTypeID;

        private void cbMonday_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cbSender = (CheckBox)sender;
            if(cbSender == cbMonday)
            {
                m_bDaysSelected[0] = cbSender.Checked;
                m_times[0] = dtMonday.Value;
            }
            else if(cbSender == cbTuesday)
            {
                m_bDaysSelected[1] = cbSender.Checked;
                m_times[1] = dtTuesday.Value;
            }
            else if(cbSender == cbWednesday)
            {
                m_bDaysSelected[2] = cbSender.Checked;
                m_times[2] = dtWednesday.Value;
            }
            else if(cbSender == cbThursday)
            {
                m_bDaysSelected[3] = cbSender.Checked;
                m_times[3] = dtThursday.Value;
            }
            else if(cbSender == cbFriday)
            {
                m_bDaysSelected[4] = cbSender.Checked;
                m_times[4] = dtFriday.Value;
            }
        }

        private void dtMonday_ValueChanged(object sender, EventArgs e)
        {
            if (cbLinkTimes.Checked)
            {
                foreach (Control ctrl in gbMain.Controls)
                {
                    if (ctrl is DateTimePicker)
                    {
                        ((DateTimePicker)ctrl).Value = ((DateTimePicker)sender).Value;
                    }
                }
            }
        }

        private void BookNextAppDialog_Load(object sender, EventArgs e)
        {
            foreach (Control c in gbMain.Controls)
            {
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;

                    var types = m_appMgr.getAppointmentTypes();

                    cb.DataSource = types;
                    cb.ValueMember = "itryID";
                    cb.DisplayMember = "itryName";

                    cb.SelectedValue = m_prevTypeID;
                }
            }
        }

        private void cbAppTypeMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbSender = (ComboBox)sender;
            if (cbSender == cbAppTypeMon)
            {
                m_appTypes[0] = (int)cbAppTypeMon.SelectedValue;
            }
            else if (cbSender == cbAppTypeTue)
            {
                m_appTypes[1] = (int)cbAppTypeTue.SelectedValue;
            }
            else if (cbSender == cbAppTypeWed)
            {
                m_appTypes[2] = (int)cbAppTypeWed.SelectedValue;
            }
            else if (cbSender == cbAppTypeThu)
            {
                m_appTypes[3] = (int)cbAppTypeThu.SelectedValue;
            }
            else if (cbSender == cbAppTypeFri)
            {
                m_appTypes[4] = (int)cbAppTypeFri.SelectedValue;
            }
        }
    }
}
