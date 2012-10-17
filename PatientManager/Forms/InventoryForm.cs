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
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
            categoryBindingSource.DataSource = m_itryMgr.getCategories();
        }

        public InventoryForm(int itryID)
        {
            InitializeComponent();
            m_itryItem = m_itryMgr.getItemByID(itryID);
            inventoryBindingSource.DataSource = m_itryItem;
            categoryBindingSource.DataSource = m_itryMgr.getCategories();

            if (m_itryItem.catID != null)
            {
                try
                {
                    catDescComboBox.SelectedValue = m_itryItem.catID;
                }
                catch (Exception) { /* meh */ }
            }
            tsbDelete.Enabled = true;
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }
            int catID;
            if (catDescComboBox.SelectedIndex == -1 && catDescComboBox.Text != String.Empty)
            {
                catID = m_itryMgr.insertNewCategory(catDescComboBox.Text);
            }
            else
            {
                catID = Convert.ToInt32(catDescComboBox.SelectedValue);
            }
            if (m_itryItem == null)
            {
                m_itryMgr.insertNewItem(itryNameTextBox.Text, itryDescTextBox.Text, Convert.ToDecimal(itryCostTextBox.Text),
                    Convert.ToInt32(itryMarkupTextBox.Text), Convert.ToDecimal(itrySellingPriveTextBox.Text), Convert.ToInt32(itryStockTextBox.Text),
                    catID);
            }
            else
            {
                m_itryMgr.updateItem(itryNameTextBox.Text, itryDescTextBox.Text, Convert.ToDecimal(itryCostTextBox.Text),
                    Convert.ToInt32(itryMarkupTextBox.Text), Convert.ToDecimal(itrySellingPriveTextBox.Text), Convert.ToInt32(itryStockTextBox.Text),
                    catID, m_itryItem);
            }

            if(m_frmManageItry != null) {
                m_frmManageItry.refreshDataGrid();
            }

            if (MessageBox.Show("Saved!\nClose window?", "Patient Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                == DialogResult.Yes)
            {
                Close();
            }

            tsbDelete.Enabled = true;
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you want to delete this item?", "PatientManager", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                m_itryMgr.softDeleteItem(m_itryItem);
            }   
        }

        private void llRemoveCat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (catDescComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Cannot remove this category. It's used by the system");
                return;
            }
            if (catDescComboBox.SelectedIndex != -1)
            {
                DialogResult r = MessageBox.Show("Are you sure you want to delete this category?", "PatientManager", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    m_itryMgr.removeCategory((int)catDescComboBox.SelectedValue);
                }
            }
        }

        public ManageInventoryForm ManageInventoryCallBack
        {
            set
            {
                m_frmManageItry = value;
            }
        }

        private Database.inventory m_itryItem = null;
        private Database.InventoryMgr m_itryMgr = new Database.InventoryMgr();
        private ManageInventoryForm m_frmManageItry;

        private void itryCostTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(!Utility.IsNumeric(itryCostTextBox.Text))
            {
                errorProvider.SetError(itryCostTextBox, "Enter a number");
                e.Cancel = true;
            }
        }

        private void itryMarkupTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!Utility.IsNumeric(itryMarkupTextBox.Text))
            {
                errorProvider.SetError(itryMarkupTextBox, "Enter a number");
                e.Cancel = true;
            }
        }

        private void itrySellingPriveTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!Utility.IsNumeric(itrySellingPriveTextBox.Text))
            {
                errorProvider.SetError(itrySellingPriveTextBox, "Enter a number");
                e.Cancel = true;
            }
        }

        private void itryStockTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!Utility.IsNumeric(itryStockTextBox.Text))
            {
                errorProvider.SetError(itryStockTextBox, "Enter a number");
                e.Cancel = true;
            }
        }

        private void itryMarkupTextBox_TextChanged(object sender, EventArgs e)
        {
            if(Utility.IsNumeric(itryMarkupTextBox.Text) && Utility.IsNumeric(itryCostTextBox.Text))
            {
                decimal markup = Convert.ToDecimal(itryMarkupTextBox.Text);
                decimal cost = Convert.ToDecimal(itryCostTextBox.Text);
                decimal sellingPrice = Math.Round(((markup / 100) + 1) * cost, 2);
                itrySellingPriveTextBox.Text = sellingPrice.ToString();
            }
        }
    }
}
