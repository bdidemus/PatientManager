namespace PatientManager.Forms
{
    partial class InventoryForm
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
            System.Windows.Forms.Label itryIDLabel;
            System.Windows.Forms.Label itryMarkupLabel;
            System.Windows.Forms.Label itryDescLabel;
            System.Windows.Forms.Label itryNameLabel;
            System.Windows.Forms.Label itryCostLabel;
            System.Windows.Forms.Label itrySellingPriveLabel;
            System.Windows.Forms.Label itryActiveLabel;
            System.Windows.Forms.Label itryStockLabel;
            System.Windows.Forms.Label catIDLabel;
            System.Windows.Forms.Label catDescLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.tsPatient = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.llRemoveCat = new System.Windows.Forms.LinkLabel();
            this.catDescComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itryStockTextBox = new System.Windows.Forms.TextBox();
            this.catIDTextBox = new System.Windows.Forms.TextBox();
            this.itrySellingPriveTextBox = new System.Windows.Forms.TextBox();
            this.itryNameTextBox = new System.Windows.Forms.TextBox();
            this.itryCostTextBox = new System.Windows.Forms.TextBox();
            this.itryMarkupTextBox = new System.Windows.Forms.TextBox();
            this.itryDescTextBox = new System.Windows.Forms.TextBox();
            this.itryIDTextBox = new System.Windows.Forms.TextBox();
            this.itryActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            itryIDLabel = new System.Windows.Forms.Label();
            itryMarkupLabel = new System.Windows.Forms.Label();
            itryDescLabel = new System.Windows.Forms.Label();
            itryNameLabel = new System.Windows.Forms.Label();
            itryCostLabel = new System.Windows.Forms.Label();
            itrySellingPriveLabel = new System.Windows.Forms.Label();
            itryActiveLabel = new System.Windows.Forms.Label();
            itryStockLabel = new System.Windows.Forms.Label();
            catIDLabel = new System.Windows.Forms.Label();
            catDescLabel = new System.Windows.Forms.Label();
            this.tsPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // itryIDLabel
            // 
            itryIDLabel.AutoSize = true;
            itryIDLabel.Location = new System.Drawing.Point(20, 29);
            itryIDLabel.Name = "itryIDLabel";
            itryIDLabel.Size = new System.Drawing.Size(21, 13);
            itryIDLabel.TabIndex = 10;
            itryIDLabel.Text = "ID:";
            // 
            // itryMarkupLabel
            // 
            itryMarkupLabel.AutoSize = true;
            itryMarkupLabel.Location = new System.Drawing.Point(20, 133);
            itryMarkupLabel.Name = "itryMarkupLabel";
            itryMarkupLabel.Size = new System.Drawing.Size(63, 13);
            itryMarkupLabel.TabIndex = 12;
            itryMarkupLabel.Text = "Markup (%):";
            // 
            // itryDescLabel
            // 
            itryDescLabel.AutoSize = true;
            itryDescLabel.Location = new System.Drawing.Point(20, 81);
            itryDescLabel.Name = "itryDescLabel";
            itryDescLabel.Size = new System.Drawing.Size(35, 13);
            itryDescLabel.TabIndex = 8;
            itryDescLabel.Text = "Desc:";
            // 
            // itryNameLabel
            // 
            itryNameLabel.AutoSize = true;
            itryNameLabel.Location = new System.Drawing.Point(20, 55);
            itryNameLabel.Name = "itryNameLabel";
            itryNameLabel.Size = new System.Drawing.Size(38, 13);
            itryNameLabel.TabIndex = 14;
            itryNameLabel.Text = "Name:";
            // 
            // itryCostLabel
            // 
            itryCostLabel.AutoSize = true;
            itryCostLabel.Location = new System.Drawing.Point(20, 107);
            itryCostLabel.Name = "itryCostLabel";
            itryCostLabel.Size = new System.Drawing.Size(31, 13);
            itryCostLabel.TabIndex = 6;
            itryCostLabel.Text = "Cost:";
            // 
            // itrySellingPriveLabel
            // 
            itrySellingPriveLabel.AutoSize = true;
            itrySellingPriveLabel.Location = new System.Drawing.Point(20, 159);
            itrySellingPriveLabel.Name = "itrySellingPriveLabel";
            itrySellingPriveLabel.Size = new System.Drawing.Size(68, 13);
            itrySellingPriveLabel.TabIndex = 16;
            itrySellingPriveLabel.Text = "Selling Prive:";
            // 
            // itryActiveLabel
            // 
            itryActiveLabel.AutoSize = true;
            itryActiveLabel.Location = new System.Drawing.Point(20, -13);
            itryActiveLabel.Name = "itryActiveLabel";
            itryActiveLabel.Size = new System.Drawing.Size(56, 13);
            itryActiveLabel.TabIndex = 4;
            itryActiveLabel.Text = "itry Active:";
            // 
            // itryStockLabel
            // 
            itryStockLabel.AutoSize = true;
            itryStockLabel.Location = new System.Drawing.Point(20, 185);
            itryStockLabel.Name = "itryStockLabel";
            itryStockLabel.Size = new System.Drawing.Size(38, 13);
            itryStockLabel.TabIndex = 18;
            itryStockLabel.Text = "Stock:";
            // 
            // catIDLabel
            // 
            catIDLabel.AutoSize = true;
            catIDLabel.Location = new System.Drawing.Point(20, -41);
            catIDLabel.Name = "catIDLabel";
            catIDLabel.Size = new System.Drawing.Size(39, 13);
            catIDLabel.TabIndex = 2;
            catIDLabel.Text = "cat ID:";
            // 
            // catDescLabel
            // 
            catDescLabel.AutoSize = true;
            catDescLabel.Location = new System.Drawing.Point(20, 211);
            catDescLabel.Name = "catDescLabel";
            catDescLabel.Size = new System.Drawing.Size(52, 13);
            catDescLabel.TabIndex = 19;
            catDescLabel.Text = "Category:";
            // 
            // tsPatient
            // 
            this.tsPatient.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsPatient.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsPatient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbDelete,
            this.toolStripSeparator1});
            this.tsPatient.Location = new System.Drawing.Point(0, 0);
            this.tsPatient.Name = "tsPatient";
            this.tsPatient.Size = new System.Drawing.Size(447, 31);
            this.tsPatient.TabIndex = 1;
            this.tsPatient.Text = "InventoryToolStrip";
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(28, 28);
            this.tsbSave.Text = "Save Item";
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
            this.tsbDelete.Text = "Delete Item";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataSource = typeof(PatientManager.Database.inventory);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.llRemoveCat);
            this.tabPage1.Controls.Add(catDescLabel);
            this.tabPage1.Controls.Add(this.catDescComboBox);
            this.tabPage1.Controls.Add(this.itryStockTextBox);
            this.tabPage1.Controls.Add(this.catIDTextBox);
            this.tabPage1.Controls.Add(this.itrySellingPriveTextBox);
            this.tabPage1.Controls.Add(this.itryNameTextBox);
            this.tabPage1.Controls.Add(this.itryCostTextBox);
            this.tabPage1.Controls.Add(this.itryMarkupTextBox);
            this.tabPage1.Controls.Add(this.itryDescTextBox);
            this.tabPage1.Controls.Add(this.itryIDTextBox);
            this.tabPage1.Controls.Add(catIDLabel);
            this.tabPage1.Controls.Add(itryStockLabel);
            this.tabPage1.Controls.Add(itryActiveLabel);
            this.tabPage1.Controls.Add(itrySellingPriveLabel);
            this.tabPage1.Controls.Add(this.itryActiveCheckBox);
            this.tabPage1.Controls.Add(itryCostLabel);
            this.tabPage1.Controls.Add(itryNameLabel);
            this.tabPage1.Controls.Add(itryDescLabel);
            this.tabPage1.Controls.Add(itryMarkupLabel);
            this.tabPage1.Controls.Add(itryIDLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(439, 255);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Item";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // llRemoveCat
            // 
            this.llRemoveCat.AutoSize = true;
            this.llRemoveCat.Location = new System.Drawing.Point(312, 211);
            this.llRemoveCat.Name = "llRemoveCat";
            this.llRemoveCat.Size = new System.Drawing.Size(92, 13);
            this.llRemoveCat.TabIndex = 8;
            this.llRemoveCat.TabStop = true;
            this.llRemoveCat.Text = "Remove Category";
            this.llRemoveCat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemoveCat_LinkClicked);
            // 
            // catDescComboBox
            // 
            this.catDescComboBox.DataSource = this.categoryBindingSource;
            this.catDescComboBox.DisplayMember = "catDesc";
            this.catDescComboBox.FormattingEnabled = true;
            this.catDescComboBox.Location = new System.Drawing.Point(110, 208);
            this.catDescComboBox.Name = "catDescComboBox";
            this.catDescComboBox.Size = new System.Drawing.Size(196, 21);
            this.catDescComboBox.TabIndex = 7;
            this.catDescComboBox.ValueMember = "catID";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(PatientManager.Database.category);
            // 
            // itryStockTextBox
            // 
            this.itryStockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "itryStock", true));
            this.itryStockTextBox.Location = new System.Drawing.Point(110, 182);
            this.itryStockTextBox.Name = "itryStockTextBox";
            this.itryStockTextBox.Size = new System.Drawing.Size(58, 20);
            this.itryStockTextBox.TabIndex = 6;
            this.itryStockTextBox.Text = "0";
            this.itryStockTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.itryStockTextBox_Validating);
            // 
            // catIDTextBox
            // 
            this.catIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "catID", true));
            this.catIDTextBox.Location = new System.Drawing.Point(110, -44);
            this.catIDTextBox.Name = "catIDTextBox";
            this.catIDTextBox.Size = new System.Drawing.Size(104, 20);
            this.catIDTextBox.TabIndex = 3;
            // 
            // itrySellingPriveTextBox
            // 
            this.itrySellingPriveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "itrySellingPrive", true));
            this.itrySellingPriveTextBox.Location = new System.Drawing.Point(110, 156);
            this.itrySellingPriveTextBox.Name = "itrySellingPriveTextBox";
            this.itrySellingPriveTextBox.Size = new System.Drawing.Size(58, 20);
            this.itrySellingPriveTextBox.TabIndex = 5;
            this.itrySellingPriveTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.itrySellingPriveTextBox_Validating);
            // 
            // itryNameTextBox
            // 
            this.itryNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "itryName", true));
            this.itryNameTextBox.Location = new System.Drawing.Point(110, 52);
            this.itryNameTextBox.Name = "itryNameTextBox";
            this.itryNameTextBox.Size = new System.Drawing.Size(317, 20);
            this.itryNameTextBox.TabIndex = 1;
            // 
            // itryCostTextBox
            // 
            this.itryCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "itryCost", true));
            this.itryCostTextBox.Location = new System.Drawing.Point(110, 104);
            this.itryCostTextBox.Name = "itryCostTextBox";
            this.itryCostTextBox.Size = new System.Drawing.Size(58, 20);
            this.itryCostTextBox.TabIndex = 3;
            this.itryCostTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.itryCostTextBox_Validating);
            // 
            // itryMarkupTextBox
            // 
            this.itryMarkupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "itryMarkup", true));
            this.itryMarkupTextBox.Location = new System.Drawing.Point(110, 130);
            this.itryMarkupTextBox.Name = "itryMarkupTextBox";
            this.itryMarkupTextBox.Size = new System.Drawing.Size(58, 20);
            this.itryMarkupTextBox.TabIndex = 4;
            this.itryMarkupTextBox.TextChanged += new System.EventHandler(this.itryMarkupTextBox_TextChanged);
            this.itryMarkupTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.itryMarkupTextBox_Validating);
            // 
            // itryDescTextBox
            // 
            this.itryDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "itryDesc", true));
            this.itryDescTextBox.Location = new System.Drawing.Point(110, 78);
            this.itryDescTextBox.Name = "itryDescTextBox";
            this.itryDescTextBox.Size = new System.Drawing.Size(317, 20);
            this.itryDescTextBox.TabIndex = 2;
            // 
            // itryIDTextBox
            // 
            this.itryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "itryID", true));
            this.itryIDTextBox.Location = new System.Drawing.Point(110, 26);
            this.itryIDTextBox.Name = "itryIDTextBox";
            this.itryIDTextBox.ReadOnly = true;
            this.itryIDTextBox.Size = new System.Drawing.Size(104, 20);
            this.itryIDTextBox.TabIndex = 0;
            // 
            // itryActiveCheckBox
            // 
            this.itryActiveCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.inventoryBindingSource, "itryActive", true));
            this.itryActiveCheckBox.Location = new System.Drawing.Point(110, -18);
            this.itryActiveCheckBox.Name = "itryActiveCheckBox";
            this.itryActiveCheckBox.Size = new System.Drawing.Size(104, 24);
            this.itryActiveCheckBox.TabIndex = 5;
            this.itryActiveCheckBox.Text = "checkBox1";
            this.itryActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(447, 281);
            this.tabControl1.TabIndex = 20;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(447, 312);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tsPatient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InventoryForm";
            this.tsPatient.ResumeLayout(false);
            this.tsPatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsPatient;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.LinkLabel llRemoveCat;
        private System.Windows.Forms.ComboBox catDescComboBox;
        private System.Windows.Forms.TextBox itryStockTextBox;
        private System.Windows.Forms.TextBox catIDTextBox;
        private System.Windows.Forms.TextBox itrySellingPriveTextBox;
        private System.Windows.Forms.TextBox itryNameTextBox;
        private System.Windows.Forms.TextBox itryCostTextBox;
        private System.Windows.Forms.TextBox itryMarkupTextBox;
        private System.Windows.Forms.TextBox itryDescTextBox;
        private System.Windows.Forms.TextBox itryIDTextBox;
        private System.Windows.Forms.CheckBox itryActiveCheckBox;
        private System.Windows.Forms.BindingSource categoryBindingSource;
    }
}