namespace PatientManager.Forms
{
    partial class AppointmentViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Calendar.DrawTool drawTool2 = new Calendar.DrawTool();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentViewForm));
            this.dvAppointments = new Calendar.DayView();
            this.contextMenuStripNew = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiNewApp = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiEditApp = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiMarkAs = new System.Windows.Forms.ToolStripMenuItem();
            this.notArrivedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrivedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canceledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiDeleteApp = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiCreateBill = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiBookNext = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiOpenPaitent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPatient = new System.Windows.Forms.ToolStrip();
            this.tsbNewApp = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mcCalendar = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.cbDoctors = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAccBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStripNew.SuspendLayout();
            this.tsPatient.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvAppointments
            // 
            drawTool2.DayView = this.dvAppointments;
            this.dvAppointments.ActiveTool = drawTool2;
            this.dvAppointments.AllowInplaceEditing = false;
            this.dvAppointments.AmPmDisplay = true;
            this.dvAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvAppointments.AppHeightMode = Calendar.DayView.AppHeightDrawMode.TrueHeightAll;
            this.dvAppointments.ContextMenuStrip = this.contextMenuStripNew;
            this.dvAppointments.DrawAllAppBorder = true;
            this.dvAppointments.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dvAppointments.Location = new System.Drawing.Point(12, 34);
            this.dvAppointments.MinHalfHourApp = false;
            this.dvAppointments.Name = "dvAppointments";
            this.dvAppointments.SelectionEnd = new System.DateTime(((long)(0)));
            this.dvAppointments.SelectionStart = new System.DateTime(((long)(0)));
            this.dvAppointments.Size = new System.Drawing.Size(712, 466);
            this.dvAppointments.StartDate = new System.DateTime(((long)(0)));
            this.dvAppointments.StartHour = 7;
            this.dvAppointments.TabIndex = 1;
            this.dvAppointments.Text = "Appointments";
            this.dvAppointments.WorkingHourStart = 7;
            this.dvAppointments.WorkingMinuteEnd = 0;
            this.dvAppointments.WorkingMinuteStart = 0;
            this.dvAppointments.SelectionChanged += new System.EventHandler(this.dvAppointments_SelectionChanged);
            this.dvAppointments.ResolveAppointments += new Calendar.ResolveAppointmentsEventHandler(this.dvAppointments_ResolveAppointments);
            this.dvAppointments.AppointmentMove += new System.EventHandler<Calendar.AppointmentEventArgs>(this.dvAppointments_AppointmentMove);
            this.dvAppointments.DoubleClick += new System.EventHandler(this.dvAppointments_DoubleClick);
            // 
            // contextMenuStripNew
            // 
            this.contextMenuStripNew.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiNewApp,
            this.cmiEditApp,
            this.cmiMarkAs,
            this.cmiDeleteApp,
            this.cmiCreateBill,
            this.cmiBookNext,
            this.cmiOpenPaitent});
            this.contextMenuStripNew.Name = "contextMenuStripNew";
            this.contextMenuStripNew.Size = new System.Drawing.Size(203, 158);
            this.contextMenuStripNew.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripNew_Opening);
            // 
            // cmiNewApp
            // 
            this.cmiNewApp.Name = "cmiNewApp";
            this.cmiNewApp.Size = new System.Drawing.Size(202, 22);
            this.cmiNewApp.Text = "New Appointment";
            this.cmiNewApp.Click += new System.EventHandler(this.newAppointmentToolStripMenuItem_Click);
            // 
            // cmiEditApp
            // 
            this.cmiEditApp.Enabled = false;
            this.cmiEditApp.Name = "cmiEditApp";
            this.cmiEditApp.Size = new System.Drawing.Size(202, 22);
            this.cmiEditApp.Text = "Edit Appointment";
            this.cmiEditApp.Click += new System.EventHandler(this.cmiEditApp_Click);
            // 
            // cmiMarkAs
            // 
            this.cmiMarkAs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notArrivedToolStripMenuItem,
            this.arrivedToolStripMenuItem,
            this.billedToolStripMenuItem,
            this.canceledToolStripMenuItem});
            this.cmiMarkAs.Enabled = false;
            this.cmiMarkAs.Name = "cmiMarkAs";
            this.cmiMarkAs.Size = new System.Drawing.Size(202, 22);
            this.cmiMarkAs.Text = "Mark As";
            // 
            // notArrivedToolStripMenuItem
            // 
            this.notArrivedToolStripMenuItem.Name = "notArrivedToolStripMenuItem";
            this.notArrivedToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.notArrivedToolStripMenuItem.Text = "Not Arrived";
            this.notArrivedToolStripMenuItem.Click += new System.EventHandler(this.notArrivedToolStripMenuItem_Click);
            // 
            // arrivedToolStripMenuItem
            // 
            this.arrivedToolStripMenuItem.Name = "arrivedToolStripMenuItem";
            this.arrivedToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.arrivedToolStripMenuItem.Text = "Arrived";
            this.arrivedToolStripMenuItem.Click += new System.EventHandler(this.arrivedToolStripMenuItem_Click);
            // 
            // billedToolStripMenuItem
            // 
            this.billedToolStripMenuItem.Name = "billedToolStripMenuItem";
            this.billedToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.billedToolStripMenuItem.Text = "Processed";
            this.billedToolStripMenuItem.Click += new System.EventHandler(this.billedToolStripMenuItem_Click);
            // 
            // canceledToolStripMenuItem
            // 
            this.canceledToolStripMenuItem.Name = "canceledToolStripMenuItem";
            this.canceledToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.canceledToolStripMenuItem.Text = "Cancelled";
            this.canceledToolStripMenuItem.Click += new System.EventHandler(this.canceledToolStripMenuItem_Click);
            // 
            // cmiDeleteApp
            // 
            this.cmiDeleteApp.Enabled = false;
            this.cmiDeleteApp.Name = "cmiDeleteApp";
            this.cmiDeleteApp.Size = new System.Drawing.Size(202, 22);
            this.cmiDeleteApp.Text = "Delete Appointment";
            this.cmiDeleteApp.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // cmiCreateBill
            // 
            this.cmiCreateBill.Enabled = false;
            this.cmiCreateBill.Name = "cmiCreateBill";
            this.cmiCreateBill.Size = new System.Drawing.Size(202, 22);
            this.cmiCreateBill.Text = "Create Bill";
            this.cmiCreateBill.Click += new System.EventHandler(this.cmiCreateBill_Click);
            // 
            // cmiBookNext
            // 
            this.cmiBookNext.Enabled = false;
            this.cmiBookNext.Name = "cmiBookNext";
            this.cmiBookNext.Size = new System.Drawing.Size(202, 22);
            this.cmiBookNext.Text = "Book Next Appointment";
            this.cmiBookNext.Click += new System.EventHandler(this.cmiBookNext_Click);
            // 
            // cmiOpenPaitent
            // 
            this.cmiOpenPaitent.Enabled = false;
            this.cmiOpenPaitent.Name = "cmiOpenPaitent";
            this.cmiOpenPaitent.Size = new System.Drawing.Size(202, 22);
            this.cmiOpenPaitent.Text = "Open Patient Record";
            this.cmiOpenPaitent.Click += new System.EventHandler(this.openPatientRecordToolStripMenuItem_Click);
            // 
            // tsPatient
            // 
            this.tsPatient.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsPatient.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsPatient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewApp,
            this.tsbDelete,
            this.tsbRefresh});
            this.tsPatient.Location = new System.Drawing.Point(0, 0);
            this.tsPatient.Name = "tsPatient";
            this.tsPatient.Size = new System.Drawing.Size(984, 31);
            this.tsPatient.TabIndex = 3;
            this.tsPatient.Text = "PatientToolStrip";
            // 
            // tsbNewApp
            // 
            this.tsbNewApp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewApp.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewApp.Image")));
            this.tsbNewApp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewApp.Name = "tsbNewApp";
            this.tsbNewApp.Size = new System.Drawing.Size(28, 28);
            this.tsbNewApp.Text = "Create New Appointment";
            this.tsbNewApp.Click += new System.EventHandler(this.newAppointmentToolStripMenuItem_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Enabled = false;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(28, 28);
            this.tsbDelete.Text = "Delete Appointment";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(28, 28);
            this.tsbRefresh.Text = "Refresh";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.mcCalendar);
            this.groupBox1.Location = new System.Drawing.Point(733, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 187);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Range";
            // 
            // mcCalendar
            // 
            this.mcCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcCalendar.Location = new System.Drawing.Point(3, 16);
            this.mcCalendar.MaxSelectionCount = 1;
            this.mcCalendar.Name = "mcCalendar";
            this.mcCalendar.TabIndex = 5;
            this.mcCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcCalendar_DateChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnClearFilter);
            this.groupBox2.Controls.Add(this.cbDoctors);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(733, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 118);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(109, 79);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(112, 23);
            this.btnClearFilter.TabIndex = 2;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // cbDoctors
            // 
            this.cbDoctors.DataSource = this.doctorBindingSource;
            this.cbDoctors.DisplayMember = "docID";
            this.cbDoctors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoctors.FormattingEnabled = true;
            this.cbDoctors.Location = new System.Drawing.Point(9, 43);
            this.cbDoctors.Name = "cbDoctors";
            this.cbDoctors.Size = new System.Drawing.Size(212, 21);
            this.cbDoctors.TabIndex = 1;
            this.cbDoctors.ValueMember = "docID";
            this.cbDoctors.SelectedIndexChanged += new System.EventHandler(this.cbDoctors_SelectedIndexChanged);
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(PatientManager.Database.doctor);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "By Doctor";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lblAccBalance);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(733, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 149);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Patient Details";
            // 
            // lblAccBalance
            // 
            this.lblAccBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccBalance.AutoSize = true;
            this.lblAccBalance.Location = new System.Drawing.Point(170, 25);
            this.lblAccBalance.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblAccBalance.Name = "lblAccBalance";
            this.lblAccBalance.Size = new System.Drawing.Size(60, 13);
            this.lblAccBalance.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Account Balance:";
            // 
            // AppointmentViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 512);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tsPatient);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dvAppointments);
            this.Controls.Add(this.groupBox2);
            this.MinimumSize = new System.Drawing.Size(1000, 550);
            this.Name = "AppointmentViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AppointmentView";
            this.Activated += new System.EventHandler(this.AppointmentViewForm_Activated);
            this.Load += new System.EventHandler(this.AppointmentViewForm_Load);
            this.contextMenuStripNew.ResumeLayout(false);
            this.tsPatient.ResumeLayout(false);
            this.tsPatient.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Calendar.DayView dvAppointments;
        private System.Windows.Forms.ToolStrip tsPatient;
        private System.Windows.Forms.ToolStripButton tsbNewApp;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNew;
        private System.Windows.Forms.ToolStripMenuItem cmiNewApp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar mcCalendar;
        private System.Windows.Forms.ToolStripMenuItem cmiEditApp;
        private System.Windows.Forms.ToolStripMenuItem cmiDeleteApp;
        private System.Windows.Forms.ToolStripMenuItem cmiCreateBill;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbDoctors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.ToolStripMenuItem cmiMarkAs;
        private System.Windows.Forms.ToolStripMenuItem notArrivedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrivedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canceledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmiBookNext;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripMenuItem cmiOpenPaitent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblAccBalance;
        private System.Windows.Forms.Label label2;
    }
}