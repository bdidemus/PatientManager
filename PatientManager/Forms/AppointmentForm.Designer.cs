namespace PatientManager.Forms
{
    partial class AppointmentForm
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
            System.Windows.Forms.Label appDateLabel;
            System.Windows.Forms.Label appDateCreateLabel;
            System.Windows.Forms.Label appIDLabel;
            System.Windows.Forms.Label appNoteLabel;
            System.Windows.Forms.Label appStatusIDLabel;
            System.Windows.Forms.Label appRenewIntervalIDLabel;
            System.Windows.Forms.Label docIDLabel1;
            System.Windows.Forms.Label appDurationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm));
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.appIDTextBox = new System.Windows.Forms.TextBox();
            this.appNoteTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDateCreated = new System.Windows.Forms.TextBox();
            this.appStatusIDComboBox = new System.Windows.Forms.ComboBox();
            this.appRenewIntervalIDComboBox = new System.Windows.Forms.ComboBox();
            this.docIDComboBox = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            appDateLabel = new System.Windows.Forms.Label();
            appDateCreateLabel = new System.Windows.Forms.Label();
            appIDLabel = new System.Windows.Forms.Label();
            appNoteLabel = new System.Windows.Forms.Label();
            appStatusIDLabel = new System.Windows.Forms.Label();
            appRenewIntervalIDLabel = new System.Windows.Forms.Label();
            docIDLabel1 = new System.Windows.Forms.Label();
            appDurationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // appDateLabel
            // 
            appDateLabel.AutoSize = true;
            appDateLabel.Location = new System.Drawing.Point(41, 53);
            appDateLabel.Name = "appDateLabel";
            appDateLabel.Size = new System.Drawing.Size(58, 13);
            appDateLabel.TabIndex = 3;
            appDateLabel.Text = "Start Date:";
            // 
            // appDateCreateLabel
            // 
            appDateCreateLabel.AutoSize = true;
            appDateCreateLabel.Location = new System.Drawing.Point(326, 26);
            appDateCreateLabel.Name = "appDateCreateLabel";
            appDateCreateLabel.Size = new System.Drawing.Size(73, 13);
            appDateCreateLabel.TabIndex = 5;
            appDateCreateLabel.Text = "Date Created:";
            // 
            // appIDLabel
            // 
            appIDLabel.AutoSize = true;
            appIDLabel.Location = new System.Drawing.Point(57, 26);
            appIDLabel.Name = "appIDLabel";
            appIDLabel.Size = new System.Drawing.Size(42, 13);
            appIDLabel.TabIndex = 7;
            appIDLabel.Text = "app ID:";
            // 
            // appNoteLabel
            // 
            appNoteLabel.AutoSize = true;
            appNoteLabel.Location = new System.Drawing.Point(61, 158);
            appNoteLabel.Name = "appNoteLabel";
            appNoteLabel.Size = new System.Drawing.Size(38, 13);
            appNoteLabel.TabIndex = 9;
            appNoteLabel.Text = "Notes:";
            // 
            // appStatusIDLabel
            // 
            appStatusIDLabel.AutoSize = true;
            appStatusIDLabel.Location = new System.Drawing.Point(59, 104);
            appStatusIDLabel.Name = "appStatusIDLabel";
            appStatusIDLabel.Size = new System.Drawing.Size(40, 13);
            appStatusIDLabel.TabIndex = 13;
            appStatusIDLabel.Text = "Status:";
            // 
            // appRenewIntervalIDLabel
            // 
            appRenewIntervalIDLabel.AutoSize = true;
            appRenewIntervalIDLabel.Location = new System.Drawing.Point(317, 78);
            appRenewIntervalIDLabel.Name = "appRenewIntervalIDLabel";
            appRenewIntervalIDLabel.Size = new System.Drawing.Size(82, 13);
            appRenewIntervalIDLabel.TabIndex = 18;
            appRenewIntervalIDLabel.Text = "Renew Interval:";
            // 
            // docIDLabel1
            // 
            docIDLabel1.AutoSize = true;
            docIDLabel1.Location = new System.Drawing.Point(336, 31);
            docIDLabel1.Name = "docIDLabel1";
            docIDLabel1.Size = new System.Drawing.Size(42, 13);
            docIDLabel1.TabIndex = 20;
            docIDLabel1.Text = "Doctor:";
            // 
            // appDurationLabel
            // 
            appDurationLabel.AutoSize = true;
            appDurationLabel.Location = new System.Drawing.Point(4, 78);
            appDurationLabel.Name = "appDurationLabel";
            appDurationLabel.Size = new System.Drawing.Size(95, 13);
            appDurationLabel.TabIndex = 21;
            appDurationLabel.Text = "Duration (minutes):";
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(PatientManager.Database.appointment);
            // 
            // appDateDateTimePicker
            // 
            this.appDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "appDate", true));
            this.appDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentBindingSource, "appDate", true));
            this.appDateDateTimePicker.Location = new System.Drawing.Point(105, 49);
            this.appDateDateTimePicker.Name = "appDateDateTimePicker";
            this.appDateDateTimePicker.Size = new System.Drawing.Size(206, 20);
            this.appDateDateTimePicker.TabIndex = 4;
            // 
            // appIDTextBox
            // 
            this.appIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "appID", true));
            this.appIDTextBox.Location = new System.Drawing.Point(105, 23);
            this.appIDTextBox.Name = "appIDTextBox";
            this.appIDTextBox.ReadOnly = true;
            this.appIDTextBox.Size = new System.Drawing.Size(114, 20);
            this.appIDTextBox.TabIndex = 8;
            // 
            // appNoteTextBox
            // 
            this.appNoteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "appNote", true));
            this.appNoteTextBox.Location = new System.Drawing.Point(105, 155);
            this.appNoteTextBox.Multiline = true;
            this.appNoteTextBox.Name = "appNoteTextBox";
            this.appNoteTextBox.Size = new System.Drawing.Size(502, 82);
            this.appNoteTextBox.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtColour);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numDuration);
            this.groupBox1.Controls.Add(this.dtTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDateCreated);
            this.groupBox1.Controls.Add(appDurationLabel);
            this.groupBox1.Controls.Add(this.appStatusIDComboBox);
            this.groupBox1.Controls.Add(appRenewIntervalIDLabel);
            this.groupBox1.Controls.Add(this.appRenewIntervalIDComboBox);
            this.groupBox1.Controls.Add(appDateLabel);
            this.groupBox1.Controls.Add(this.appDateDateTimePicker);
            this.groupBox1.Controls.Add(appDateCreateLabel);
            this.groupBox1.Controls.Add(appStatusIDLabel);
            this.groupBox1.Controls.Add(appIDLabel);
            this.groupBox1.Controls.Add(this.appIDTextBox);
            this.groupBox1.Controls.Add(appNoteLabel);
            this.groupBox1.Controls.Add(this.appNoteTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 252);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(105, 128);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(206, 21);
            this.cbType.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Type:";
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(405, 102);
            this.txtColour.Name = "txtColour";
            this.txtColour.ReadOnly = true;
            this.txtColour.Size = new System.Drawing.Size(202, 20);
            this.txtColour.TabIndex = 28;
            this.txtColour.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Colour:";
            // 
            // numDuration
            // 
            this.numDuration.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentBindingSource, "appDuration", true));
            this.numDuration.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numDuration.Location = new System.Drawing.Point(105, 76);
            this.numDuration.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numDuration.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(55, 20);
            this.numDuration.TabIndex = 26;
            this.numDuration.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // dtTime
            // 
            this.dtTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentBindingSource, "appDate", true));
            this.dtTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "appDate", true));
            this.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTime.Location = new System.Drawing.Point(405, 49);
            this.dtTime.Name = "dtTime";
            this.dtTime.ShowUpDown = true;
            this.dtTime.Size = new System.Drawing.Size(88, 20);
            this.dtTime.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Time:";
            // 
            // txtDateCreated
            // 
            this.txtDateCreated.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "appDateCreate", true));
            this.txtDateCreated.Location = new System.Drawing.Point(405, 23);
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.ReadOnly = true;
            this.txtDateCreated.Size = new System.Drawing.Size(202, 20);
            this.txtDateCreated.TabIndex = 23;
            // 
            // appStatusIDComboBox
            // 
            this.appStatusIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.appStatusIDComboBox.FormattingEnabled = true;
            this.appStatusIDComboBox.Items.AddRange(new object[] {
            "Not Arrived",
            "Arrived",
            "Processed",
            "Cancelled"});
            this.appStatusIDComboBox.Location = new System.Drawing.Point(105, 101);
            this.appStatusIDComboBox.Name = "appStatusIDComboBox";
            this.appStatusIDComboBox.Size = new System.Drawing.Size(143, 21);
            this.appStatusIDComboBox.TabIndex = 20;
            // 
            // appRenewIntervalIDComboBox
            // 
            this.appRenewIntervalIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.appRenewIntervalIDComboBox.FormattingEnabled = true;
            this.appRenewIntervalIDComboBox.Items.AddRange(new object[] {
            "Do not Renew",
            "Daily",
            "Weekly",
            "Bi-Weekly",
            "Monthly",
            "Bi-Monthly",
            "Yearly"});
            this.appRenewIntervalIDComboBox.Location = new System.Drawing.Point(405, 75);
            this.appRenewIntervalIDComboBox.Name = "appRenewIntervalIDComboBox";
            this.appRenewIntervalIDComboBox.Size = new System.Drawing.Size(135, 21);
            this.appRenewIntervalIDComboBox.TabIndex = 19;
            // 
            // docIDComboBox
            // 
            this.docIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.appointmentBindingSource, "docID", true));
            this.docIDComboBox.DataSource = this.doctorBindingSource;
            this.docIDComboBox.DisplayMember = "docID";
            this.docIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.docIDComboBox.FormattingEnabled = true;
            this.docIDComboBox.Location = new System.Drawing.Point(384, 28);
            this.docIDComboBox.Name = "docIDComboBox";
            this.docIDComboBox.Size = new System.Drawing.Size(223, 21);
            this.docIDComboBox.TabIndex = 21;
            this.docIDComboBox.ValueMember = "docID";
            this.docIDComboBox.SelectedValueChanged += new System.EventHandler(this.docIDComboBox_SelectedValueChanged);
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(PatientManager.Database.appointment);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(472, 345);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(558, 345);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 23);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtPatientName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(docIDLabel1);
            this.groupBox2.Controls.Add(this.docIDComboBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 69);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Who";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(280, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(25, 24);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPatientName
            // 
            this.txtPatientName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "patient.FullName", true));
            this.txtPatientName.Location = new System.Drawing.Point(98, 28);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(176, 20);
            this.txtPatientName.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Schedule for:";
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(647, 380);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.Appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker appDateDateTimePicker;
        private System.Windows.Forms.TextBox appIDTextBox;
        private System.Windows.Forms.TextBox appNoteTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox appRenewIntervalIDComboBox;
        private System.Windows.Forms.ComboBox appStatusIDComboBox;
        private System.Windows.Forms.ComboBox docIDComboBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.TextBox txtDateCreated;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.DateTimePicker dtTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label4;
    }
}