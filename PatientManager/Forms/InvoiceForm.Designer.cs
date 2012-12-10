namespace PatientManager.Forms
{
    partial class InvoiceForm
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
            System.Windows.Forms.Label patFirstNameLabel;
            System.Windows.Forms.Label invIDLabel;
            System.Windows.Forms.Label invDateLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.cbWriteOff = new System.Windows.Forms.CheckBox();
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.cbDoctor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.invIDTextBox = new System.Windows.Forms.TextBox();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbSavePDF = new System.Windows.Forms.ToolStripButton();
            this.tsbStatement = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAddItem = new System.Windows.Forms.ToolStripButton();
            this.tsbRemoveRow = new System.Windows.Forms.ToolStripButton();
            this.lblTotal = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.colLineNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            patFirstNameLabel = new System.Windows.Forms.Label();
            invIDLabel = new System.Windows.Forms.Label();
            invDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // patFirstNameLabel
            // 
            patFirstNameLabel.AutoSize = true;
            patFirstNameLabel.Location = new System.Drawing.Point(60, 58);
            patFirstNameLabel.Name = "patFirstNameLabel";
            patFirstNameLabel.Size = new System.Drawing.Size(39, 13);
            patFirstNameLabel.TabIndex = 0;
            patFirstNameLabel.Text = "Bill To:";
            // 
            // invIDLabel
            // 
            invIDLabel.AutoSize = true;
            invIDLabel.Location = new System.Drawing.Point(36, 34);
            invIDLabel.Name = "invIDLabel";
            invIDLabel.Size = new System.Drawing.Size(63, 13);
            invIDLabel.TabIndex = 2;
            invIDLabel.Text = "Bill Number:";
            // 
            // invDateLabel
            // 
            invDateLabel.AutoSize = true;
            invDateLabel.Location = new System.Drawing.Point(402, 32);
            invDateLabel.Name = "invDateLabel";
            invDateLabel.Size = new System.Drawing.Size(49, 13);
            invDateLabel.TabIndex = 26;
            invDateLabel.Text = "Bill Date:";
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToDeleteRows = false;
            this.dgvInvoice.AllowUserToResizeColumns = false;
            this.dgvInvoice.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dgvInvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoice.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLineNo,
            this.colItryName,
            this.colDesc,
            this.colPrice,
            this.colDiscount,
            this.colQrt});
            this.dgvInvoice.Location = new System.Drawing.Point(12, 169);
            this.dgvInvoice.MultiSelect = false;
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInvoice.Size = new System.Drawing.Size(720, 238);
            this.dgvInvoice.TabIndex = 0;
            this.dgvInvoice.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvInvoice_CellBeginEdit);
            this.dgvInvoice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellDoubleClick);
            this.dgvInvoice.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellEndEdit);
            this.dgvInvoice.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvInvoice_RowsAdded);
            this.dgvInvoice.SelectionChanged += new System.EventHandler(this.dgvInvoice_SelectionChanged);
            this.dgvInvoice.Validating += new System.ComponentModel.CancelEventHandler(this.dgvInvoice_Validating);
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.cbWriteOff);
            this.gbDetails.Controls.Add(this.dtpBillDate);
            this.gbDetails.Controls.Add(this.cbDoctor);
            this.gbDetails.Controls.Add(this.label2);
            this.gbDetails.Controls.Add(this.cbStatus);
            this.gbDetails.Controls.Add(this.label1);
            this.gbDetails.Controls.Add(invDateLabel);
            this.gbDetails.Controls.Add(this.btnSearch);
            this.gbDetails.Controls.Add(this.txtPatientName);
            this.gbDetails.Controls.Add(invIDLabel);
            this.gbDetails.Controls.Add(this.invIDTextBox);
            this.gbDetails.Controls.Add(patFirstNameLabel);
            this.gbDetails.Location = new System.Drawing.Point(12, 34);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(719, 126);
            this.gbDetails.TabIndex = 1;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // cbWriteOff
            // 
            this.cbWriteOff.AutoSize = true;
            this.cbWriteOff.Location = new System.Drawing.Point(215, 31);
            this.cbWriteOff.Name = "cbWriteOff";
            this.cbWriteOff.Size = new System.Drawing.Size(66, 17);
            this.cbWriteOff.TabIndex = 34;
            this.cbWriteOff.Text = "Write off";
            this.cbWriteOff.UseVisualStyleBackColor = true;
            this.cbWriteOff.CheckedChanged += new System.EventHandler(this.cbWriteOff_CheckedChanged);
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.Location = new System.Drawing.Point(457, 29);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBillDate.TabIndex = 32;
            // 
            // cbDoctor
            // 
            this.cbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoctor.FormattingEnabled = true;
            this.cbDoctor.Location = new System.Drawing.Point(105, 81);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(176, 21);
            this.cbDoctor.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Doctor:";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Unpaid",
            "Paid",
            "Void"});
            this.cbStatus.Location = new System.Drawing.Point(457, 81);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(200, 21);
            this.cbStatus.TabIndex = 29;
            this.cbStatus.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Status";
            this.label1.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(287, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(25, 24);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(105, 55);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(176, 20);
            this.txtPatientName.TabIndex = 25;
            this.txtPatientName.Validating += new System.ComponentModel.CancelEventHandler(this.txtPatientName_Validating);
            // 
            // invIDTextBox
            // 
            this.invIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "invID", true));
            this.invIDTextBox.Location = new System.Drawing.Point(105, 29);
            this.invIDTextBox.Name = "invIDTextBox";
            this.invIDTextBox.ReadOnly = true;
            this.invIDTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.invIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.invIDTextBox.TabIndex = 3;
            this.invIDTextBox.Text = "0";
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(PatientManager.Database.invoice);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbDelete,
            this.tsbSavePDF,
            this.tsbStatement,
            this.toolStripSeparator1,
            this.tsbAddItem,
            this.tsbRemoveRow,
            this.lblTotal,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(743, 31);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(28, 28);
            this.tsbSave.Text = "Save Invoice";
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
            this.tsbDelete.Text = "Delete";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbSavePDF
            // 
            this.tsbSavePDF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSavePDF.Enabled = false;
            this.tsbSavePDF.Image = ((System.Drawing.Image)(resources.GetObject("tsbSavePDF.Image")));
            this.tsbSavePDF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSavePDF.Name = "tsbSavePDF";
            this.tsbSavePDF.Size = new System.Drawing.Size(28, 28);
            this.tsbSavePDF.Text = "Print Invoice";
            this.tsbSavePDF.Click += new System.EventHandler(this.tsbSavePDF_Click);
            // 
            // tsbStatement
            // 
            this.tsbStatement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStatement.Enabled = false;
            this.tsbStatement.Image = ((System.Drawing.Image)(resources.GetObject("tsbStatement.Image")));
            this.tsbStatement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStatement.Name = "tsbStatement";
            this.tsbStatement.Size = new System.Drawing.Size(28, 28);
            this.tsbStatement.Text = "Generate Account Statement";
            this.tsbStatement.Click += new System.EventHandler(this.tsbStatement_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbAddItem
            // 
            this.tsbAddItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddItem.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddItem.Image")));
            this.tsbAddItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddItem.Name = "tsbAddItem";
            this.tsbAddItem.Size = new System.Drawing.Size(28, 28);
            this.tsbAddItem.Text = "Add Item";
            this.tsbAddItem.Click += new System.EventHandler(this.tsbAddItem_Click);
            // 
            // tsbRemoveRow
            // 
            this.tsbRemoveRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemoveRow.Enabled = false;
            this.tsbRemoveRow.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemoveRow.Image")));
            this.tsbRemoveRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveRow.Name = "tsbRemoveRow";
            this.tsbRemoveRow.Size = new System.Drawing.Size(28, 28);
            this.tsbRemoveRow.Text = "Remove Item";
            this.tsbRemoveRow.Click += new System.EventHandler(this.tsbRemoveRow_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(19, 28);
            this.lblTotal.Text = "$0";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 28);
            this.toolStripLabel1.Text = "Total:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // colLineNo
            // 
            this.colLineNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colLineNo.FillWeight = 1F;
            this.colLineNo.HeaderText = "";
            this.colLineNo.Name = "colLineNo";
            this.colLineNo.ReadOnly = true;
            this.colLineNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colLineNo.Width = 30;
            // 
            // colItryName
            // 
            this.colItryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colItryName.FillWeight = 5F;
            this.colItryName.HeaderText = "Item";
            this.colItryName.Name = "colItryName";
            this.colItryName.ReadOnly = true;
            this.colItryName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colItryName.Width = 240;
            // 
            // colDesc
            // 
            this.colDesc.FillWeight = 4F;
            this.colDesc.HeaderText = "Description";
            this.colDesc.Name = "colDesc";
            this.colDesc.ReadOnly = true;
            this.colDesc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDesc.Width = 250;
            // 
            // colPrice
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.colPrice.FillWeight = 2F;
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPrice.Width = 50;
            // 
            // colDiscount
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.NullValue = "0";
            this.colDiscount.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDiscount.FillWeight = 3F;
            this.colDiscount.HeaderText = "Discount($)";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDiscount.Width = 65;
            // 
            // colQrt
            // 
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.colQrt.DefaultCellStyle = dataGridViewCellStyle4;
            this.colQrt.FillWeight = 1F;
            this.colQrt.HeaderText = "Qty";
            this.colQrt.Name = "colQrt";
            this.colQrt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colQrt.Width = 42;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(743, 419);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.dgvInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.TextBox invIDTextBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbAddItem;
        private System.Windows.Forms.ToolStripButton tsbRemoveRow;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolStripButton tsbSavePDF;
        private System.Windows.Forms.ComboBox cbDoctor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpBillDate;
        private System.Windows.Forms.ToolStripButton tsbStatement;
        private System.Windows.Forms.CheckBox cbWriteOff;
        private System.Windows.Forms.ToolStripLabel lblTotal;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLineNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQrt;
    }
}