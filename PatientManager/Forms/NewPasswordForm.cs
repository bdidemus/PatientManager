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
    public partial class NewPasswordForm : Form
    {
        public NewPasswordForm(String username)
        {
            m_strUsername = username;
            InitializeComponent();
        }

        private void btnChangePwd_Click(object sender, EventArgs e)
        {        
            if (txtNewPassword.Text == "" || txtConfirmPassword.Text == "" || txtOldPassword.Text == "")
            {
                return;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("New passwords don't match");
                txtNewPassword.Text = "";
                txtConfirmPassword.Text = "";
                txtNewPassword.Focus();
                return;
            }

            bool result = LoginMgr.Instance.changePassword(m_strUsername, txtOldPassword.Text, txtNewPassword.Text);
            if (!result)
            {
                MessageBox.Show("Failed to update password\nIncorrect password?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Password Successfuly update", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }

        }

        private void NewPassword_Shown(object sender, EventArgs e)
        {
            txtOldPassword.Focus();
        }

        private String m_strUsername;
        
    }
}
