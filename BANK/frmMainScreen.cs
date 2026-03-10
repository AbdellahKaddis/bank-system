using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using BANK_Bussiness;
using BANK.Login;
using BANK.Users;
using BANK.Accounts;
using BANK.Customers;
using BANK.Transactions;
using BANK.Currency;

namespace BANK
{
    public partial class frmMainScreen : Form
    {
        public static clsUser CurrentUser;
        private frmLogin _frmLoginScreen;
        public frmMainScreen(frmLogin loginScreen,clsUser user)
        {
            InitializeComponent();
            CurrentUser = user;
            _frmLoginScreen= loginScreen;
          
        }
        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsUser.IsAllowed(CurrentUser.Permissions, clsUser.enPermissions.ManagePeople))
            {
                MessageBox.Show("You don't have permissions to access this screen.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmPeopleManagement frm = new frmPeopleManagement();
            frm.ShowDialog();
        }

        private void addNewPersonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!clsUser.IsAllowed(CurrentUser.Permissions, clsUser.enPermissions.ManagePeople))
            {
                MessageBox.Show("You don't have permissions to access this screen.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmAdd_Update_Person frm = new frmAdd_Update_Person(-1);
            frm.ShowDialog();
        }

        private void findPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsUser.IsAllowed(CurrentUser.Permissions, clsUser.enPermissions.ManagePeople))
            {
                MessageBox.Show("You don't have permissions to access this screen.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmFindPerson frmFind= new frmFindPerson();
            frmFind.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmLoginScreen.Show();
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(CurrentUser.UserId);
            frm.ShowDialog();
        }

        private void cuurrentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frm=new frmShowUserInfo(CurrentUser);
            frm.ShowDialog();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsUser.IsAllowed(CurrentUser.Permissions, clsUser.enPermissions.ManageCustomers))
            {
                MessageBox.Show("You don't have permissions to access this screen.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmCustomersList frm = new frmCustomersList();
            frm.ShowDialog();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!clsUser.IsAllowed(CurrentUser.Permissions, clsUser.enPermissions.PerformTransactions))
            {
                MessageBox.Show("You don't have permissions to access this screen.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmDeposit_Withdraw frm = new frmDeposit_Withdraw(frmDeposit_Withdraw.enMode.Deposit);
            frm.ShowDialog();   
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsUser.IsAllowed(CurrentUser.Permissions, clsUser.enPermissions.PerformTransactions))
            {
                MessageBox.Show("You don't have permissions to access this screen.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmDeposit_Withdraw frm = new frmDeposit_Withdraw(frmDeposit_Withdraw.enMode.Withdraw);
            frm.ShowDialog();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsUser.IsAllowed(CurrentUser.Permissions, clsUser.enPermissions.PerformTransactions))
            {
                MessageBox.Show("You don't have permissions to access this screen.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmTransfer frm = new frmTransfer();
            frm.ShowDialog();
        }

        private void CurrencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuuencyTransfer frmCuuencyTransfer = new frmCuuencyTransfer();
            frmCuuencyTransfer.ShowDialog();
        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsUser.IsAllowed(CurrentUser.Permissions, clsUser.enPermissions.ManageAccounts))
            {
                MessageBox.Show("You don't have permissions to access this screen.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmAccountManagement frm = new frmAccountManagement();
            frm.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!clsUser.IsAllowed(CurrentUser.Permissions,clsUser.enPermissions.MangeUsers))
            {
                MessageBox.Show("You don't have permissions to access this screen.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmUsersManagement frm = new frmUsersManagement();
            frm.ShowDialog(); 
        }
    }
}
