using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;
using System.Data.Objects.DataClasses;

namespace PatientManager.Forms
{
    public partial class ManageInventoryForm : Form
    {
        private bool m_bSearchMode;
        private int m_nSelectedID;
        private Database.InventoryMgr m_itryMgr = new Database.InventoryMgr();

        public ManageInventoryForm(bool searchMode = false)
        {
            InitializeComponent();
            m_bSearchMode = searchMode;
            // If in search mode then turn off some buttons that arn't used
            if (m_bSearchMode)
            {
                tsbSelect.Visible = true;
                tsbAdd.Visible = false;
                tsbDelete.Visible = false;
                dgvInventory.CellDoubleClick += new DataGridViewCellEventHandler(tsbSelect_Click);
            }
            inventoryBindingSource.DataSource = m_itryMgr.getInventoryItems();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            InventoryForm frmInventory = new InventoryForm();
            frmInventory.MdiParent = MdiParent;
            frmInventory.ManageInventoryCallBack = this;
            frmInventory.Show();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (m_nSelectedID == 1)
            {
                MessageBox.Show("Cannot delete appointment fee. It is used by the system");
                return;
            }

            DialogResult r = MessageBox.Show("Really delete inventory item?", "Inventory", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (m_nSelectedID > -1)
                {
                    m_itryMgr.softDeleteItem(m_nSelectedID);
                    refreshDataGrid();
                }
            }
        }

        private void tsbSelect_Click(object sender, EventArgs e)
        {
            confirmSelection();
        }

        private void dgvInventory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            confirmSelection();
        }

        private void confirmSelection()
        {
            if (m_bSearchMode)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else if(m_nSelectedID != 1)
            {
                InventoryForm frmInventory = new InventoryForm(m_nSelectedID);
                frmInventory.MdiParent = MdiParent;
                frmInventory.ManageInventoryCallBack = this;
                frmInventory.Show();
            }      
            // else do nothing, this means to user tried to selected the appointment inventory item
            // which is disallowed.
        }

        private void InventorySelectorForm_Load(object sender, EventArgs e)
        {
            tscbFilterBy.SelectedIndex = 0;

            catBindingSource.DataSource = m_itryMgr.getCategories();

            cbCatDesc.ValueMember = "catID";
            cbCatDesc.DisplayMember = "catDesc";
            cbCatDesc.DataSource = catBindingSource;
            cbCatDesc.SelectedIndex = -1;
        }

        public int SelectedID
        {
            get
            {
                return m_nSelectedID;
            }
        }

        private void dgvInventory_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvInventory.SelectedRows.Count == 1 && dgvInventory.SelectedRows[0].Cells[0].Value != null)
            {
                tsbDelete.Enabled = true;
                m_nSelectedID = (int)dgvInventory.SelectedRows[0].Cells[0].Value;
            }
            else
            {
                tsbDelete.Enabled = false;
            }      
        }

        public void refreshDataGrid()
        {
            if (txtFilter.Text.Length > 0 || cbCatDesc.SelectedIndex != -1)
            {
                filter();
            }
            else
            {
                inventoryBindingSource.DataSource = m_itryMgr.getInventoryItems();
            }
        }

        public void filter()
        {
            String filterText = txtFilter.Text;
            int catID = (cbCatDesc.SelectedIndex == -1) ? -1 : (int)cbCatDesc.SelectedValue;
            if (filterText.Length != 0)
            {
                switch (tscbFilterBy.SelectedIndex)
                {
                    case 0:
                        try
                        {
                            if (catID == -1)
                            {
                                inventoryBindingSource.DataSource = m_itryMgr.getItemByID(Convert.ToInt32(filterText));
                            }
                            else
                            {
                                inventoryBindingSource.DataSource = m_itryMgr.getItemByID(Convert.ToInt32(filterText), catID);
                            }
                        }
                        catch (Exception) { /* dont care */ }
                        break;
                    case 1:
                        if (catID == -1)
                        {
                            inventoryBindingSource.DataSource = m_itryMgr.getItemWithNameLike(filterText);
                        }
                        else
                        {
                            inventoryBindingSource.DataSource = m_itryMgr.getItemWithNameLike(filterText, catID);
                        }
                        break;
                    case 2:
                        if (catID == -1)
                        {
                            inventoryBindingSource.DataSource = m_itryMgr.getItemWithDescLike(filterText);
                        }
                        else
                        {
                            inventoryBindingSource.DataSource = m_itryMgr.getItemWithDescLike(filterText, catID);
                        }
                        break;
                    default:
                        break;
                }
            }
            else if (catID != -1)
            {
                inventoryBindingSource.DataSource = m_itryMgr.getInventoryItems(catID);
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            refreshDataGrid();
        }

        private void tscbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshDataGrid();
        }

        private void ManageInventoryForm_Activated(object sender, EventArgs e)
        {
            txtFilter.Focus();
        }

        private void catDescComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshDataGrid();
        }

        private void btnRemoveCatFilter_Click(object sender, EventArgs e)
        {
           cbCatDesc.SelectedIndex = -1;
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            refreshDataGrid();
        }
    }
}
