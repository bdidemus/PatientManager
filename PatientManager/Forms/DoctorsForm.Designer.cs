namespace PatientManager.Forms
{
    partial class DoctorsForm
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
            System.Windows.Forms.Label docIDLabel;
            System.Windows.Forms.Label docFirstNameLabel;
            System.Windows.Forms.Label docLastNameLabel;
            System.Windows.Forms.Label docAddressLabel;
            System.Windows.Forms.Label docCityLabel;
            System.Windows.Forms.Label dtDecLabel;
            System.Windows.Forms.Label docDateCreatedLabel;
            System.Windows.Forms.Label docPCodeLabel;
            System.Windows.Forms.Label docLicenceLabel;
            System.Windows.Forms.Label docOfficeNumberLabel;
            System.Windows.Forms.Label docMobileNumberLabel;
            System.Windows.Forms.Label dovSecondaryNumberLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorsForm));
            System.Windows.Forms.Label label2;
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tsPatient = new System.Windows.Forms.ToolStrip();
            this.tsbNewDoctor = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAppointments = new System.Windows.Forms.ToolStripButton();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.docSecondaryNumberTextBox = new System.Windows.Forms.TextBox();
            this.docMobileNumberTextBox = new System.Windows.Forms.TextBox();
            this.docOfficeNumberTextBox = new System.Windows.Forms.TextBox();
            this.docLicenceTextBox = new System.Windows.Forms.TextBox();
            this.docPCodeTextBox = new System.Windows.Forms.TextBox();
            this.dtDecComboBox = new System.Windows.Forms.ComboBox();
            this.docCityTextBox = new System.Windows.Forms.TextBox();
            this.docAddressTextBox = new System.Windows.Forms.TextBox();
            this.docLastNameTextBox = new System.Windows.Forms.TextBox();
            this.docFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.docIDTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txtLicence2 = new System.Windows.Forms.TextBox();
            docIDLabel = new System.Windows.Forms.Label();
            docFirstNameLabel = new System.Windows.Forms.Label();
            docLastNameLabel = new System.Windows.Forms.Label();
            docAddressLabel = new System.Windows.Forms.Label();
            docCityLabel = new System.Windows.Forms.Label();
            dtDecLabel = new System.Windows.Forms.Label();
            docDateCreatedLabel = new System.Windows.Forms.Label();
            docPCodeLabel = new System.Windows.Forms.Label();
            docLicenceLabel = new System.Windows.Forms.Label();
            docOfficeNumberLabel = new System.Windows.Forms.Label();
            docMobileNumberLabel = new System.Windows.Forms.Label();
            dovSecondaryNumberLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorGridBindingSource)).BeginInit();
            this.tsPatient.SuspendLayout();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // docIDLabel
            // 
            docIDLabel.AutoSize = true;
            docIDLabel.Location = new System.Drawing.Point(56, 41);
            docIDLabel.Name = "docIDLabel";
            docIDLabel.Size = new System.Drawing.Size(24, 13);
            docIDLabel.TabIndex = 0;
            docIDLabel.Text = " ID:";
            // 
            // docFirstNameLabel
            // 
            docFirstNameLabel.AutoSize = true;
            docFirstNameLabel.Location = new System.Drawing.Point(20, 67);
            docFirstNameLabel.Name = "docFirstNameLabel";
            docFirstNameLabel.Size = new System.Drawing.Size(60, 13);
            docFirstNameLabel.TabIndex = 2;
            docFirstNameLabel.Text = "First Name:";
            // 
            // docLastNameLabel
            // 
            docLastNameLabel.AutoSize = true;
            docLastNameLabel.Location = new System.Drawing.Point(311, 67);
            docLastNameLabel.Name = "docLastNameLabel";
            docLastNameLabel.Size = new System.Drawing.Size(61, 13);
            docLastNameLabel.TabIndex = 4;
            docLastNameLabel.Text = "Last Name:";
            // 
            // docAddressLabel
            // 
            docAddressLabel.AutoSize = true;
            docAddressLabel.Location = new System.Drawing.Point(32, 93);
            docAddressLabel.Name = "docAddressLabel";
            docAddressLabel.Size = new System.Drawing.Size(48, 13);
            docAddressLabel.TabIndex = 6;
            docAddressLabel.Text = "Address:";
            // 
            // docCityLabel
            // 
            docCityLabel.AutoSize = true;
            docCityLabel.Location = new System.Drawing.Point(53, 145);
            docCityLabel.Name = "docCityLabel";
            docCityLabel.Size = new System.Drawing.Size(27, 13);
            docCityLabel.TabIndex = 8;
            docCityLabel.Text = "City:";
            // 
            // dtDecLabel
            // 
            dtDecLabel.AutoSize = true;
            dtDecLabel.Location = new System.Drawing.Point(338, 223);
            dtDecLabel.Name = "dtDecLabel";
            dtDecLabel.Size = new System.Drawing.Size(34, 13);
            dtDecLabel.TabIndex = 10;
            dtDecLabel.Text = "Type:";
            // 
            // docDateCreatedLabel
            // 
            docDateCreatedLabel.AutoSize = true;
            docDateCreatedLabel.Location = new System.Drawing.Point(299, 41);
            docDateCreatedLabel.Name = "docDateCreatedLabel";
            docDateCreatedLabel.Size = new System.Drawing.Size(73, 13);
            docDateCreatedLabel.TabIndex = 12;
            docDateCreatedLabel.Text = "Date Created:";
            // 
            // docPCodeLabel
            // 
            docPCodeLabel.AutoSize = true;
            docPCodeLabel.Location = new System.Drawing.Point(13, 171);
            docPCodeLabel.Name = "docPCodeLabel";
            docPCodeLabel.Size = new System.Drawing.Size(67, 13);
            docPCodeLabel.TabIndex = 14;
            docPCodeLabel.Text = "Postal Code:";
            // 
            // docLicenceLabel
            // 
            docLicenceLabel.AutoSize = true;
            docLicenceLabel.Location = new System.Drawing.Point(324, 93);
            docLicenceLabel.Name = "docLicenceLabel";
            docLicenceLabel.Size = new System.Drawing.Size(48, 13);
            docLicenceLabel.TabIndex = 16;
            docLicenceLabel.Text = "Licence:";
            // 
            // docOfficeNumberLabel
            // 
            docOfficeNumberLabel.AutoSize = true;
            docOfficeNumberLabel.Location = new System.Drawing.Point(294, 145);
            docOfficeNumberLabel.Name = "docOfficeNumberLabel";
            docOfficeNumberLabel.Size = new System.Drawing.Size(78, 13);
            docOfficeNumberLabel.TabIndex = 18;
            docOfficeNumberLabel.Text = "Office Number:";
            // 
            // docMobileNumberLabel
            // 
            docMobileNumberLabel.AutoSize = true;
            docMobileNumberLabel.Location = new System.Drawing.Point(291, 171);
            docMobileNumberLabel.Name = "docMobileNumberLabel";
            docMobileNumberLabel.Size = new System.Drawing.Size(81, 13);
            docMobileNumberLabel.TabIndex = 20;
            docMobileNumberLabel.Text = "Mobile Number:";
            // 
            // dovSecondaryNumberLabel
            // 
            dovSecondaryNumberLabel.AutoSize = true;
            dovSecondaryNumberLabel.Location = new System.Drawing.Point(271, 197);
            dovSecondaryNumberLabel.Name = "dovSecondaryNumberLabel";
            dovSecondaryNumberLabel.Size = new System.Drawing.Size(101, 13);
            dovSecondaryNumberLabel.TabIndex = 22;
            dovSecondaryNumberLabel.Text = "Secondary Number:";
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(PatientManager.Database.doctor);
            // 
            // dgvDoctors
            // 
            this.dgvDoctors.AllowUserToAddRows = false;
            this.dgvDoctors.AllowUserToDeleteRows = false;
            this.dgvDoctors.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dgvDoctors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDoctors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDoctors.AutoGenerateColumns = false;
            this.dgvDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoctors.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn12});
            this.dgvDoctors.DataSource = this.doctorGridBindingSource;
            this.dgvDoctors.Location = new System.Drawing.Point(12, 307);
            this.dgvDoctors.MultiSelect = false;
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.ReadOnly = true;
            this.dgvDoctors.RowHeadersVisible = false;
            this.dgvDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoctors.Size = new System.Drawing.Size(580, 225);
            this.dgvDoctors.TabIndex = 1;
            this.dgvDoctors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctors_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "docID";
            this.dataGridViewTextBoxColumn1.HeaderText = "docID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "docLastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "docFirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "docDateCreated";
            this.dataGridViewTextBoxColumn12.HeaderText = "Date Created";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // doctorGridBindingSource
            // 
            this.doctorGridBindingSource.DataSource = typeof(PatientManager.Database.doctor);
            // 
            // tsPatient
            // 
            this.tsPatient.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsPatient.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsPatient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewDoctor,
            this.tsbSave,
            this.tsbDelete,
            this.toolStripSeparator1,
            this.tsbAppointments});
            this.tsPatient.Location = new System.Drawing.Point(0, 0);
            this.tsPatient.Name = "tsPatient";
            this.tsPatient.Size = new System.Drawing.Size(604, 31);
            this.tsPatient.TabIndex = 2;
            this.tsPatient.Text = "PatientToolStrip";
            // 
            // tsbNewDoctor
            // 
            this.tsbNewDoctor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewDoctor.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewDoctor.Image")));
            this.tsbNewDoctor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewDoctor.Name = "tsbNewDoctor";
            this.tsbNewDoctor.Size = new System.Drawing.Size(28, 28);
            this.tsbNewDoctor.Text = "New Doctor";
            this.tsbNewDoctor.Click += new System.EventHandler(this.tsbNewDoctor_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(28, 28);
            this.tsbSave.Text = "Save Doctor";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Enabled = false;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(28, 28);
            this.tsbDelete.Text = "Delete Doctor";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbAppointments
            // 
            this.tsbAppointments.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAppointments.Image = ((System.Drawing.Image)(resources.GetObject("tsbAppointments.Image")));
            this.tsbAppointments.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAppointments.Name = "tsbAppointments";
            this.tsbAppointments.Size = new System.Drawing.Size(28, 28);
            this.tsbAppointments.Text = "Book Appointment";
            this.tsbAppointments.Visible = false;
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.txtColour);
            this.gbDetails.Controls.Add(this.label1);
            this.gbDetails.Controls.Add(this.textBox1);
            this.gbDetails.Controls.Add(dovSecondaryNumberLabel);
            this.gbDetails.Controls.Add(this.docSecondaryNumberTextBox);
            this.gbDetails.Controls.Add(docMobileNumberLabel);
            this.gbDetails.Controls.Add(this.docMobileNumberTextBox);
            this.gbDetails.Controls.Add(docOfficeNumberLabel);
            this.gbDetails.Controls.Add(this.docOfficeNumberTextBox);
            this.gbDetails.Controls.Add(label2);
            this.gbDetails.Controls.Add(docLicenceLabel);
            this.gbDetails.Controls.Add(this.txtLicence2);
            this.gbDetails.Controls.Add(this.docLicenceTextBox);
            this.gbDetails.Controls.Add(docPCodeLabel);
            this.gbDetails.Controls.Add(this.docPCodeTextBox);
            this.gbDetails.Controls.Add(docDateCreatedLabel);
            this.gbDetails.Controls.Add(dtDecLabel);
            this.gbDetails.Controls.Add(this.dtDecComboBox);
            this.gbDetails.Controls.Add(docCityLabel);
            this.gbDetails.Controls.Add(this.docCityTextBox);
            this.gbDetails.Controls.Add(docAddressLabel);
            this.gbDetails.Controls.Add(this.docAddressTextBox);
            this.gbDetails.Controls.Add(docLastNameLabel);
            this.gbDetails.Controls.Add(this.docLastNameTextBox);
            this.gbDetails.Controls.Add(docFirstNameLabel);
            this.gbDetails.Controls.Add(this.docFirstNameTextBox);
            this.gbDetails.Controls.Add(docIDLabel);
            this.gbDetails.Controls.Add(this.docIDTextBox);
            this.gbDetails.Location = new System.Drawing.Point(12, 34);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(580, 267);
            this.gbDetails.TabIndex = 3;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // txtColour
            // 
            this.txtColour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtColour.Location = new System.Drawing.Point(86, 194);
            this.txtColour.Name = "txtColour";
            this.txtColour.ReadOnly = true;
            this.txtColour.Size = new System.Drawing.Size(162, 20);
            this.txtColour.TabIndex = 26;
            this.txtColour.Click += new System.EventHandler(this.txtColour_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Display Colour:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(378, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 24;
            // 
            // docSecondaryNumberTextBox
            // 
            this.docSecondaryNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "dovSecondaryNumber", true));
            this.docSecondaryNumberTextBox.Location = new System.Drawing.Point(378, 194);
            this.docSecondaryNumberTextBox.MaxLength = 20;
            this.docSecondaryNumberTextBox.Name = "docSecondaryNumberTextBox";
            this.docSecondaryNumberTextBox.Size = new System.Drawing.Size(184, 20);
            this.docSecondaryNumberTextBox.TabIndex = 23;
            // 
            // docMobileNumberTextBox
            // 
            this.docMobileNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "docMobileNumber", true));
            this.docMobileNumberTextBox.Location = new System.Drawing.Point(378, 168);
            this.docMobileNumberTextBox.MaxLength = 20;
            this.docMobileNumberTextBox.Name = "docMobileNumberTextBox";
            this.docMobileNumberTextBox.Size = new System.Drawing.Size(184, 20);
            this.docMobileNumberTextBox.TabIndex = 21;
            // 
            // docOfficeNumberTextBox
            // 
            this.docOfficeNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "docOfficeNumber", true));
            this.docOfficeNumberTextBox.Location = new System.Drawing.Point(378, 142);
            this.docOfficeNumberTextBox.MaxLength = 20;
            this.docOfficeNumberTextBox.Name = "docOfficeNumberTextBox";
            this.docOfficeNumberTextBox.Size = new System.Drawing.Size(184, 20);
            this.docOfficeNumberTextBox.TabIndex = 19;
            // 
            // docLicenceTextBox
            // 
            this.docLicenceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "docLicence", true));
            this.docLicenceTextBox.Location = new System.Drawing.Point(378, 90);
            this.docLicenceTextBox.MaxLength = 20;
            this.docLicenceTextBox.Name = "docLicenceTextBox";
            this.docLicenceTextBox.Size = new System.Drawing.Size(184, 20);
            this.docLicenceTextBox.TabIndex = 17;
            // 
            // docPCodeTextBox
            // 
            this.docPCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "docPCode", true));
            this.docPCodeTextBox.Location = new System.Drawing.Point(86, 168);
            this.docPCodeTextBox.MaxLength = 6;
            this.docPCodeTextBox.Name = "docPCodeTextBox";
            this.docPCodeTextBox.Size = new System.Drawing.Size(162, 20);
            this.docPCodeTextBox.TabIndex = 15;
            // 
            // dtDecComboBox
            // 
            this.dtDecComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "doc_type.dtDec", true));
            this.dtDecComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dtDecComboBox.FormattingEnabled = true;
            this.dtDecComboBox.Location = new System.Drawing.Point(378, 220);
            this.dtDecComboBox.Name = "dtDecComboBox";
            this.dtDecComboBox.Size = new System.Drawing.Size(184, 21);
            this.dtDecComboBox.TabIndex = 11;
            // 
            // docCityTextBox
            // 
            this.docCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "docCity", true));
            this.docCityTextBox.Location = new System.Drawing.Point(86, 142);
            this.docCityTextBox.MaxLength = 30;
            this.docCityTextBox.Name = "docCityTextBox";
            this.docCityTextBox.Size = new System.Drawing.Size(162, 20);
            this.docCityTextBox.TabIndex = 9;
            // 
            // docAddressTextBox
            // 
            this.docAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "docAddress", true));
            this.docAddressTextBox.Location = new System.Drawing.Point(86, 90);
            this.docAddressTextBox.MaxLength = 75;
            this.docAddressTextBox.Multiline = true;
            this.docAddressTextBox.Name = "docAddressTextBox";
            this.docAddressTextBox.Size = new System.Drawing.Size(162, 46);
            this.docAddressTextBox.TabIndex = 7;
            // 
            // docLastNameTextBox
            // 
            this.docLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "docLastName", true));
            this.docLastNameTextBox.Location = new System.Drawing.Point(378, 64);
            this.docLastNameTextBox.MaxLength = 30;
            this.docLastNameTextBox.Name = "docLastNameTextBox";
            this.docLastNameTextBox.Size = new System.Drawing.Size(184, 20);
            this.docLastNameTextBox.TabIndex = 5;
            // 
            // docFirstNameTextBox
            // 
            this.docFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "docFirstName", true));
            this.docFirstNameTextBox.Location = new System.Drawing.Point(86, 64);
            this.docFirstNameTextBox.MaxLength = 25;
            this.docFirstNameTextBox.Name = "docFirstNameTextBox";
            this.docFirstNameTextBox.Size = new System.Drawing.Size(162, 20);
            this.docFirstNameTextBox.TabIndex = 3;
            this.docFirstNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.docFirstNameTextBox_Validating);
            // 
            // docIDTextBox
            // 
            this.docIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "docID", true));
            this.docIDTextBox.Enabled = false;
            this.docIDTextBox.Location = new System.Drawing.Point(86, 38);
            this.docIDTextBox.Name = "docIDTextBox";
            this.docIDTextBox.Size = new System.Drawing.Size(79, 20);
            this.docIDTextBox.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtLicence2
            // 
            this.txtLicence2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "docLicence2", true));
            this.txtLicence2.Location = new System.Drawing.Point(378, 116);
            this.txtLicence2.MaxLength = 20;
            this.txtLicence2.Name = "txtLicence2";
            this.txtLicence2.Size = new System.Drawing.Size(184, 20);
            this.txtLicence2.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(315, 119);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 13);
            label2.TabIndex = 16;
            label2.Text = "Licence 2:";
            // 
            // DoctorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(604, 544);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.tsPatient);
            this.Controls.Add(this.dgvDoctors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DoctorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Doctors";
            this.Load += new System.EventHandler(this.Doctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorGridBindingSource)).EndInit();
            this.tsPatient.ResumeLayout(false);
            this.tsPatient.PerformLayout();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.ToolStrip tsPatient;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbAppointments;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.TextBox docLastNameTextBox;
        private System.Windows.Forms.TextBox docFirstNameTextBox;
        private System.Windows.Forms.TextBox docIDTextBox;
        private System.Windows.Forms.ComboBox dtDecComboBox;
        private System.Windows.Forms.TextBox docCityTextBox;
        private System.Windows.Forms.TextBox docAddressTextBox;
        private System.Windows.Forms.TextBox docPCodeTextBox;
        private System.Windows.Forms.TextBox docLicenceTextBox;
        private System.Windows.Forms.TextBox docOfficeNumberTextBox;
        private System.Windows.Forms.TextBox docMobileNumberTextBox;
        private System.Windows.Forms.TextBox docSecondaryNumberTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripButton tsbNewDoctor;
        private System.Windows.Forms.BindingSource doctorGridBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txtLicence2;
    }
}