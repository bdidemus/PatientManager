namespace PatientManager.Forms
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblActualBalance = new System.Windows.Forms.Label();
            this.lblAccBal = new System.Windows.Forms.Label();
            this.cbDoctor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPaymentType = new System.Windows.Forms.ComboBox();
            this.paymenttypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCommit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsDateGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletePaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateRecieptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mcDate = new System.Windows.Forms.MonthCalendar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymenttypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.cmsDateGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblActualBalance);
            this.groupBox1.Controls.Add(this.lblAccBal);
            this.groupBox1.Controls.Add(this.cbDoctor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbPaymentType);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCommit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtPatientName);
            this.groupBox1.Location = new System.Drawing.Point(15, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Payment";
            // 
            // lblActualBalance
            // 
            this.lblActualBalance.AutoSize = true;
            this.lblActualBalance.Location = new System.Drawing.Point(483, 98);
            this.lblActualBalance.Name = "lblActualBalance";
            this.lblActualBalance.Size = new System.Drawing.Size(0, 13);
            this.lblActualBalance.TabIndex = 36;
            this.lblActualBalance.Visible = false;
            // 
            // lblAccBal
            // 
            this.lblAccBal.AutoSize = true;
            this.lblAccBal.Location = new System.Drawing.Point(344, 98);
            this.lblAccBal.Name = "lblAccBal";
            this.lblAccBal.Size = new System.Drawing.Size(133, 13);
            this.lblAccBal.TabIndex = 35;
            this.lblAccBal.Text = "Patients Account Balance:";
            this.lblAccBal.Visible = false;
            // 
            // cbDoctor
            // 
            this.cbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoctor.FormattingEnabled = true;
            this.cbDoctor.Location = new System.Drawing.Point(392, 38);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(201, 21);
            this.cbDoctor.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Doctor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Type:";
            // 
            // cbPaymentType
            // 
            this.cbPaymentType.DataSource = this.paymenttypeBindingSource;
            this.cbPaymentType.DisplayMember = "ptName";
            this.cbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentType.FormattingEnabled = true;
            this.cbPaymentType.Location = new System.Drawing.Point(102, 90);
            this.cbPaymentType.Name = "cbPaymentType";
            this.cbPaymentType.Size = new System.Drawing.Size(176, 21);
            this.cbPaymentType.TabIndex = 31;
            this.cbPaymentType.ValueMember = "ptID";
            // 
            // paymenttypeBindingSource
            // 
            this.paymenttypeBindingSource.DataSource = typeof(PatientManager.Database.payment_type);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(102, 64);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(108, 20);
            this.txtAmount.TabIndex = 30;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Amount:";
            // 
            // btnCommit
            // 
            this.btnCommit.Enabled = false;
            this.btnCommit.Location = new System.Drawing.Point(201, 129);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(108, 23);
            this.btnCommit.TabIndex = 28;
            this.btnCommit.Text = "Commit Payment";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Payment from:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(284, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(25, 24);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(102, 38);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(176, 20);
            this.txtPatientName.TabIndex = 25;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(PatientManager.Database.invoice);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvPayments);
            this.groupBox2.Location = new System.Drawing.Point(12, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(844, 353);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Todays Payments";
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.AllowUserToResizeColumns = false;
            this.dgvPayments.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvPayments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPayments.AutoGenerateColumns = false;
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayments.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientNameDataGridViewTextBoxColumn,
            this.payAmountDataGridViewTextBoxColumn,
            this.DoctorName,
            this.payTypeDataGridViewTextBoxColumn,
            this.payDateDataGridViewTextBoxColumn,
            this.PayID});
            this.dgvPayments.ContextMenuStrip = this.cmsDateGrid;
            this.dgvPayments.DataSource = this.paymentsViewModelBindingSource;
            this.dgvPayments.Location = new System.Drawing.Point(3, 0);
            this.dgvPayments.MultiSelect = false;
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersVisible = false;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(838, 350);
            this.dgvPayments.TabIndex = 0;
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            this.patientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName";
            this.patientNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            this.patientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payAmountDataGridViewTextBoxColumn
            // 
            this.payAmountDataGridViewTextBoxColumn.DataPropertyName = "PayAmount";
            this.payAmountDataGridViewTextBoxColumn.FillWeight = 50F;
            this.payAmountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.payAmountDataGridViewTextBoxColumn.Name = "payAmountDataGridViewTextBoxColumn";
            this.payAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DoctorName
            // 
            this.DoctorName.DataPropertyName = "DoctorName";
            this.DoctorName.HeaderText = "Doctor";
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.ReadOnly = true;
            // 
            // payTypeDataGridViewTextBoxColumn
            // 
            this.payTypeDataGridViewTextBoxColumn.DataPropertyName = "PayType";
            this.payTypeDataGridViewTextBoxColumn.FillWeight = 50F;
            this.payTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.payTypeDataGridViewTextBoxColumn.Name = "payTypeDataGridViewTextBoxColumn";
            this.payTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payDateDataGridViewTextBoxColumn
            // 
            this.payDateDataGridViewTextBoxColumn.DataPropertyName = "PayDate";
            this.payDateDataGridViewTextBoxColumn.FillWeight = 50F;
            this.payDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.payDateDataGridViewTextBoxColumn.Name = "payDateDataGridViewTextBoxColumn";
            this.payDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PayID
            // 
            this.PayID.DataPropertyName = "PayID";
            this.PayID.HeaderText = "PayID";
            this.PayID.Name = "PayID";
            this.PayID.ReadOnly = true;
            this.PayID.Visible = false;
            // 
            // cmsDateGrid
            // 
            this.cmsDateGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletePaymentToolStripMenuItem,
            this.changePaymentToolStripMenuItem,
            this.generateRecieptToolStripMenuItem});
            this.cmsDateGrid.Name = "cmsDateGrid";
            this.cmsDateGrid.Size = new System.Drawing.Size(166, 70);
            this.cmsDateGrid.Opening += new System.ComponentModel.CancelEventHandler(this.cmsDateGrid_Opening);
            // 
            // deletePaymentToolStripMenuItem
            // 
            this.deletePaymentToolStripMenuItem.Name = "deletePaymentToolStripMenuItem";
            this.deletePaymentToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.deletePaymentToolStripMenuItem.Text = "Delete Payment";
            this.deletePaymentToolStripMenuItem.Click += new System.EventHandler(this.deletePaymentToolStripMenuItem_Click);
            // 
            // changePaymentToolStripMenuItem
            // 
            this.changePaymentToolStripMenuItem.Name = "changePaymentToolStripMenuItem";
            this.changePaymentToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.changePaymentToolStripMenuItem.Text = "Change Payment";
            this.changePaymentToolStripMenuItem.Click += new System.EventHandler(this.changePaymentToolStripMenuItem_Click);
            // 
            // generateRecieptToolStripMenuItem
            // 
            this.generateRecieptToolStripMenuItem.Name = "generateRecieptToolStripMenuItem";
            this.generateRecieptToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.generateRecieptToolStripMenuItem.Text = "Generate Reciept";
            this.generateRecieptToolStripMenuItem.Click += new System.EventHandler(this.generateRecieptToolStripMenuItem_Click);
            // 
            // paymentsViewModelBindingSource
            // 
            this.paymentsViewModelBindingSource.DataSource = typeof(PatientManager.Database.PaymentsViewModel);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.mcDate);
            this.groupBox3.Location = new System.Drawing.Point(626, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 184);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Show payments for";
            // 
            // mcDate
            // 
            this.mcDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcDate.Location = new System.Drawing.Point(3, 16);
            this.mcDate.MaxSelectionCount = 1;
            this.mcDate.Name = "mcDate";
            this.mcDate.TabIndex = 0;
            this.mcDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcDate_DateSelected);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 577);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymenttypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.cmsDateGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paymentsViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPaymentType;
        private System.Windows.Forms.BindingSource paymenttypeBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource paymentsViewModelBindingSource;
        private System.Windows.Forms.ComboBox cbDoctor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MonthCalendar mcDate;
        private System.Windows.Forms.ContextMenuStrip cmsDateGrid;
        private System.Windows.Forms.ToolStripMenuItem deletePaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePaymentToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn payTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayID;
        private System.Windows.Forms.ToolStripMenuItem generateRecieptToolStripMenuItem;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.Label lblActualBalance;
        private System.Windows.Forms.Label lblAccBal;
    }
}