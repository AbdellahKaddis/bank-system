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

namespace BANK
{
    public partial class frmAdd_Update_User : Form
    {
        public frmAdd_Update_User()
        {
            InitializeComponent();
        }

        private int _UserId=-1;
        public frmAdd_Update_User(int UserId)
        {
            InitializeComponent();
            _UserId = UserId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {   
            this.Close();
        }
        private void ctrFindPerson1_OnPersonSelected(int obj)
        {
            if(obj == -1)
            {
                pnlLoginInfo.Enabled = false;
                pnlPermissions.Enabled = false;
                chkFullAccess.Enabled = false;
            }
            else
            {
                if (clsUser.IsUserExistByPersonId(obj) && _UserId==-1)
                {
                    MessageBox.Show("This person is already a user,choose another person.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                pnlLoginInfo.Enabled = true;
                pnlPermissions.Enabled = true;
                chkFullAccess.Enabled = true;
            }
        }
        private clsUser _user;

        private void _LoadUserInfo()
        {
            _user = clsUser.FindUser(_UserId);
            txtUserName.Text = _user.UserName;
            txtPassword.Text = _user.Password;
            txtConfirmPassword.Text = _user.Password;
            lblUserId.Text = _user.UserId.ToString();

            if (_user.Status == "Active")
                chkIsActive.Checked = true;
            else
                chkIsActive.Checked = false;

            if (_user.Role == "Manager")
            {
                chkFullAccess.Checked = true;
            }
            else if (_user.Role == "Teller")
            {
                chkAccessToManageCustomers.Checked = true;
                chkAccessToManageAccounts.Checked = true;
                chkAccessToPerformTransactions.Checked = true;
            }
            else if (_user.Role == "Customer Service Representative")
            {
                chkAccessToManageCustomers.Checked = true;
            }
         

            ctrFindPerson1.LoadUserInfo(this, _user.PersonId);
        }
        private void frmAdd_Update_User_Load(object sender, EventArgs e)
        {
           
            if(_UserId== -1)
            {
                lblTitle.Text = "Add New User";
                this.Text = "Add New User Screen";
              _user = new clsUser();
                pnlLoginInfo.Enabled = false;
                pnlPermissions.Enabled = false;
                chkFullAccess.Enabled = false;
            }
            else
            {
                lblTitle.Text = "Update User";
                this.Text = "Update User Screen";
                ctrFindPerson1.EnabledFilterBox = false;

                _LoadUserInfo();
                pnlLoginInfo.Enabled = true;
                pnlPermissions.Enabled = true;
                chkFullAccess.Enabled = true ;
            }
        }
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "Password must not be empty.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword,"");
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                e.Cancel = true;
                txtUserName.Focus();
                errorProvider1.SetError(txtUserName, "UserName must not be empty.");
            }
            else if (clsUser.IsExist(txtUserName.Text.Trim()) && _UserId==-1)
            {
                e.Cancel = true;
                txtUserName.Focus();
                errorProvider1.SetError(txtUserName, $"this {txtUserName.Text} already exist.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUserName, "");
            }
        }
        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                txtConfirmPassword.Focus();
                errorProvider1.SetError(txtConfirmPassword, "Password does not mtach.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPassword, "");
            }
        }

       
        private int _GetPermission()
        {
            
            int Permissions = 0;
            if (chkFullAccess.Checked)
                return (int)clsUser.enPermissions.FullAccess;

            if (chkAccessToMangePeople.Checked)
                Permissions += (int)clsUser.enPermissions.ManagePeople;

            if (chkAccessToMangeUsers.Checked)
                Permissions += (int)clsUser.enPermissions.MangeUsers;

            if (chkAccessToManageCustomers.Checked)
                Permissions += (int)clsUser.enPermissions.ManageCustomers;

            if (chkAccessToManageAccounts.Checked)
                Permissions += (int)clsUser.enPermissions.ManageAccounts;

            if (chkAccessToPerformTransactions.Checked)
                Permissions += (int)clsUser.enPermissions.PerformTransactions;

            return Permissions;
        }

        private string GetRole()
        {
            if (chkFullAccess.Checked ||(chkAccessToMangePeople.Checked&& chkAccessToMangeUsers.Checked && chkAccessToManageCustomers.Checked && chkAccessToManageCustomers.Checked && chkAccessToManageAccounts.Checked && chkAccessToPerformTransactions.Checked))
                return "Manager";
            else if (chkAccessToManageCustomers.Checked && chkAccessToManageAccounts.Checked && chkAccessToPerformTransactions.Checked)
                return "Teller";
            else if (chkAccessToManageCustomers.Checked)
                return "Customer Service Representative";
            else
                return "Undefined Role";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if(this.ValidateChildren())
            {
                _user.UserName = txtUserName.Text;
                _user.Password = txtPassword.Text;
                _user.PersonId = int.Parse(ctrFindPerson1.SerchField);
                _user.Status = chkIsActive.Checked ? "Active" : "Closed";

                if (chkAccessToMangePeople.Checked || chkAccessToMangeUsers.Checked || chkFullAccess.Checked || chkAccessToManageCustomers.Checked || chkAccessToManageAccounts.Checked || chkAccessToPerformTransactions.Checked)
                 {
                    _user.Permissions = _GetPermission();
                    _user.Role = GetRole();


                    if (_user.Save())
                    {
                        _UserId = _user.UserId;
                        lblUserId.Text = _user.UserId.ToString();
                        tabcontrol1.SelectedIndex = 1;
                        MessageBox.Show("user  Saved Succefully.", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("failed to save user.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                MessageBox.Show("a user should have at least one permiission.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            tabcontrol1.SelectedIndex = 1;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tabcontrol1.SelectedIndex = 0;
        }

        private void btnfront_Click(object sender, EventArgs e)
        {
            tabcontrol1.SelectedIndex = 2;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            tabcontrol1.SelectedIndex = 1;
        }

        private void _UncheckedAllChkInPanel(Panel pnl)
        {
            foreach (Control ctr in pnl.Controls)
            {
                if (ctr.Name.StartsWith("chk"))
                {
                    ((CheckBox)ctr).Checked = false;
                }

            }
        }

        private bool _IsAnyChkInPanelChecked(Panel pnl)
        {
            foreach (Control ctr in pnl.Controls)
            {
                if (ctr.Name.StartsWith("chk") && ((CheckBox)ctr).Checked)
                {
                    return true;
                }

            }
            return false;
        }
        private void chkFullAccess_CheckedChanged(object sender, EventArgs e)
        {
            pnlPermissions.Enabled = !chkFullAccess.Checked;
           if(chkFullAccess.Checked)
            {
                _UncheckedAllChkInPanel(pnlPermissions);
            }
        }
        private void DisabledChkWhenOtherChkIsChecked(object sender, EventArgs e)
        {
            if(_IsAnyChkInPanelChecked(pnlPermissions))
            {
                chkFullAccess.Enabled = false;
            }
            else
            {
                chkFullAccess.Enabled = true;
            }

        }

    }
}
