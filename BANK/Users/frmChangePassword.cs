using BANK_Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK.Users
{
    public partial class frmChangePassword : Form
    {
        private clsUser _User;
        public frmChangePassword(int UserId)
        {
            InitializeComponent();
            _User = clsUser.FindUser(UserId);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            ctrPersonCard1.LoadPersonInfo(_User.PersonId);
            lblUserId.Text = _User.UserId.ToString();
            lblUserName.Text = _User.UserName;
            lblStatus.Text = _User.Status;
            lblRole.Text = _User.Role;
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if( _User.Password !=txtCurrentPassword.Text)
            {
                e.Cancel = true;
                txtCurrentPassword.Focus();
                errorProvider1.SetError(txtCurrentPassword, "Wrong Password.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCurrentPassword, "");
            }
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                e.Cancel = true;
                txtNewPassword.Focus();
                errorProvider1.SetError(txtNewPassword, "Password must not be empty.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNewPassword, "");
            }
        }

        private void txtConfirmNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtNewPassword.Text != txtConfirmNewPassword.Text)
            {
                e.Cancel = true;
                txtConfirmNewPassword.Focus();
                errorProvider1.SetError(txtConfirmNewPassword, "Password does not match.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmNewPassword, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_User.ChangePassword(txtNewPassword.Text))
            {
                MessageBox.Show("Password changed successfully.","success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to change password.", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
