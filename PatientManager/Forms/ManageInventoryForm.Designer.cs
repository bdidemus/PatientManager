namespace PatientManager.Forms
{
    partial class ManageInventoryForm
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
            System.Windows.Forms.Label catDescLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageInventoryForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tscbFilterBy = new System.Windows.Forms.ToolStripComboBox();
            this.txtFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbSelect = new System.Windows.Forms.ToolStripButton();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.itryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itryDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itryCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itryMarkupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itrySellingPriveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itryActiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itryStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCatDesc = new System.Windows.Forms.ComboBox();
            this.btnRemoveCatFilter = new System.Windows.Forms.Button();
            this.catBindingSource = new System.Windows.Forms.BindingSource(this.components);
            catDescLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // catDescLabel
            // 
            catDescLabel.AutoSize = true;
            catDescLabel.Location = new System.Drawing.Point(26, 36);
            catDescLabel.Name = "catDescLabel";
            catDescLabel.Size = new System.Drawing.Size(131, 13);
            catDescLabel.TabIndex = 0;
            catDescLabel.Text = "Show items from category:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsbAdd,
            this.tsbRefresh,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.tscbFilterBy,
            this.txtFilter,
            this.toolStripSeparator3,
            this.tsbDelete,
            this.tsbSelect});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(860, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Main Toolstrip";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 28);
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(28, 28);
            this.tsbAdd.Text = "toolStripButton2";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(52, 28);
            this.toolStripLabel2.Text = "Filter By:";
            // 
            // tscbFilterBy
            // 
            this.tscbFilterBy.AutoSize = false;
            this.tscbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbFilterBy.DropDownWidth = 90;
            this.tscbFilterBy.Items.AddRange(new object[] {
            "Item ID",
            "Name",
            "Description"});
            this.tscbFilterBy.Name = "tscbFilterBy";
            this.tscbFilterBy.Size = new System.Drawing.Size(105, 23);
            this.tscbFilterBy.SelectedIndexChanged += new System.EventHandler(this.tscbFilterBy_SelectedIndexChanged);
            // 
            // txtFilter
            // 
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(120, 31);
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Enabled = false;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(28, 28);
            this.tsbDelete.Text = "tsbDelete";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbSelect
            // 
            this.tsbSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSelect.Image = ((System.Drawing.Image)(resources.GetObject("tsbSelect.Image")));
            this.tsbSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSelect.Name = "tsbSelect";
            this.tsbSelect.Size = new System.Drawing.Size(28, 28);
            this.tsbSelect.Text = "tsbSelect";
            this.tsbSelect.ToolTipText = "Select";
            this.tsbSelect.Visible = false;
            this.tsbSelect.Click += new System.EventHandler(this.tsbSelect_Click);
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventory.AutoGenerateColumns = false;
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itryIDDataGridViewTextBoxColumn,
            this.itryNameDataGridViewTextBoxColumn,
            this.itryDescDataGridViewTextBoxColumn,
            this.itryCostDataGridViewTextBoxColumn,
            this.itryMarkupDataGridViewTextBoxColumn,
            this.itrySellingPriveDataGridViewTextBoxColumn,
            this.itryActiveDataGridViewTextBoxColumn,
            this.itryStockDataGridViewTextBoxColumn});
            this.dgvInventory.DataSource = this.inventoryBindingSource;
            this.dgvInventory.Location = new System.Drawing.Point(0, 102);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInventory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(860, 343);
            this.dgvInventory.TabIndex = 1;
            this.dgvInventory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellDoubleClick);
            this.dgvInventory.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvInventory_RowStateChanged);
            // 
            // itryIDDataGridViewTextBoxColumn
            // 
            this.itryIDDataGridViewTextBoxColumn.DataPropertyName = "itryID";
            this.itryIDDataGridViewTextBoxColumn.FillWeight = 30F;
            this.itryIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.itryIDDataGridViewTextBoxColumn.Name = "itryIDDataGridViewTextBoxColumn";
            this.itryIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itryNameDataGridViewTextBoxColumn
            // 
            this.itryNameDataGridViewTextBoxColumn.DataPropertyName = "itryName";
            this.itryNameDataGridViewTextBoxColumn.FillWeight = 125F;
            this.itryNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.itryNameDataGridViewTextBoxColumn.Name = "itryNameDataGridViewTextBoxColumn";
            this.itryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itryDescDataGridViewTextBoxColumn
            // 
            this.itryDescDataGridViewTextBoxColumn.DataPropertyName = "itryDesc";
            this.itryDescDataGridViewTextBoxColumn.FillWeight = 150F;
            this.itryDescDataGridViewTextBoxColumn.HeaderText = "Description";
            this.itryDescDataGridViewTextBoxColumn.Name = "itryDescDataGridViewTextBoxColumn";
            this.itryDescDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itryCostDataGridViewTextBoxColumn
            // 
            this.itryCostDataGridViewTextBoxColumn.DataPropertyName = "itryCost";
            this.itryCostDataGridViewTextBoxColumn.FillWeight = 50F;
            this.itryCostDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.itryCostDataGridViewTextBoxColumn.Name = "itryCostDataGridViewTextBoxColumn";
            this.itryCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itryMarkupDataGridViewTextBoxColumn
            // 
            this.itryMarkupDataGridViewTextBoxColumn.DataPropertyName = "itryMarkup";
            this.itryMarkupDataGridViewTextBoxColumn.FillWeight = 50F;
            this.itryMarkupDataGridViewTextBoxColumn.HeaderText = "Markup";
            this.itryMarkupDataGridViewTextBoxColumn.Name = "itryMarkupDataGridViewTextBoxColumn";
            this.itryMarkupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itrySellingPriveDataGridViewTextBoxColumn
            // 
            this.itrySellingPriveDataGridViewTextBoxColumn.DataPropertyName = "itrySellingPrive";
            this.itrySellingPriveDataGridViewTextBoxColumn.FillWeight = 50F;
            this.itrySellingPriveDataGridViewTextBoxColumn.HeaderText = "Selling Price";
            this.itrySellingPriveDataGridViewTextBoxColumn.Name = "itrySellingPriveDataGridViewTextBoxColumn";
            this.itrySellingPriveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itryActiveDataGridViewTextBoxColumn
            // 
            this.itryActiveDataGridViewTextBoxColumn.DataPropertyName = "itryActive";
            this.itryActiveDataGridViewTextBoxColumn.HeaderText = "itryActive";
            this.itryActiveDataGridViewTextBoxColumn.Name = "itryActiveDataGridViewTextBoxColumn";
            this.itryActiveDataGridViewTextBoxColumn.ReadOnly = true;
            this.itryActiveDataGridViewTextBoxColumn.Visible = false;
            // 
            // itryStockDataGridViewTextBoxColumn
            // 
            this.itryStockDataGridViewTextBoxColumn.DataPropertyName = "itryStock";
            this.itryStockDataGridViewTextBoxColumn.FillWeight = 50F;
            this.itryStockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.itryStockDataGridViewTextBoxColumn.Name = "itryStockDataGridViewTextBoxColumn";
            this.itryStockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataSource = typeof(PatientManager.Database.inventory);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.dgvInventory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 445);
            this.panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCatDesc);
            this.groupBox1.Controls.Add(this.btnRemoveCatFilter);
            this.groupBox1.Controls.Add(catDescLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 93);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category Filter";
            // 
            // cbCatDesc
            // 
            this.cbCatDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCatDesc.FormattingEnabled = true;
            this.cbCatDesc.Location = new System.Drawing.Point(163, 33);
            this.cbCatDesc.Name = "cbCatDesc";
            this.cbCatDesc.Size = new System.Drawing.Size(301, 21);
            this.cbCatDesc.TabIndex = 3;
            this.cbCatDesc.SelectedIndexChanged += new System.EventHandler(this.catDescComboBox_SelectedIndexChanged);
            // 
            // btnRemoveCatFilter
            // 
            this.btnRemoveCatFilter.Location = new System.Drawing.Point(372, 60);
            this.btnRemoveCatFilter.Name = "btnRemoveCatFilter";
            this.btnRemoveCatFilter.Size = new System.Drawing.Size(92, 23);
            this.btnRemoveCatFilter.TabIndex = 2;
            this.btnRemoveCatFilter.Text = "Clear";
            this.btnRemoveCatFilter.UseVisualStyleBackColor = true;
            this.btnRemoveCatFilter.Click += new System.EventHandler(this.btnRemoveCatFilter_Click);
            // 
            // ManageInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 476);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(876, 514);
            this.Name = "ManageInventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inventory";
            this.Activated += new System.EventHandler(this.ManageInventoryForm_Activated);
            this.Load += new System.EventHandler(this.InventorySelectorForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox tscbFilterBy;
        private System.Windows.Forms.ToolStripTextBox txtFilter;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripButton tsbSelect;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoveCatFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itryDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itryCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itryMarkupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itrySellingPriveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itryActiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itryStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbCatDesc;
        private System.Windows.Forms.BindingSource catBindingSource;
    }
}