using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PatientManager.Forms.Reporting
{
    public partial class IntervalPickerDialog : Form
    {
        public IntervalPickerDialog(Form mdiParent)
        {
            InitializeComponent();
            dtStart.Value = DateTime.Now.AddMonths(-1);
            dtEnd.Value = DateTime.Now;

            mdi = mdiParent;
        }

        protected Form mdi;

        protected virtual void btnGenerate_Click(object sender, EventArgs e) { }
    }
}
