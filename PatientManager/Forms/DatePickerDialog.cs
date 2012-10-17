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
    public partial class DatePickerDialog : Form
    {
        public DatePickerDialog()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            m_dtSelectedDate = mcDate.SelectionStart;
            Close();
        }

        public DateTime MaxDate { set { mcDate.MaxDate = value; } }
        public DateTime MinDate { set { mcDate.MinDate = value; } }

        public DateTime SelectedDate
        {
            get
            {
                return m_dtSelectedDate;
            }
        }

        private DateTime m_dtSelectedDate;
    }
}
