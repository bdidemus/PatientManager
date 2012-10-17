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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length == 0 || txtPassword.Text.Length == 0)
            {
                return;
            }
            // Submit the username and password to the login manager to determin if 
            // the pair is valid
            LoginMgr.Instance.submitLogin(txtUsername.Text, txtPassword.Text);
            if (!LoginMgr.Instance.isLoggedIn)
            {
                txtUsername.Text = "";
                txtPassword.Text = "";              
                MessageBox.Show("Invalid username and/or password",
                    "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnNewPasswrd_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 0)
            {
                NewPasswordForm frmNewPassword = new NewPasswordForm(txtUsername.Text);
                frmNewPassword.ShowDialog();
            }
            else
            {
                MessageBox.Show("Missing username", "Username required", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

    }
}
