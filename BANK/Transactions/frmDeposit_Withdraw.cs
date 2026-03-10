using BANK_Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK.Transactions
{
    public partial class frmDeposit_Withdraw : Form
    {
        public enum enMode { Deposit=1,Withdraw=2}
        private enMode _Mode;
        public frmDeposit_Withdraw(enMode Mode)
        {
            InitializeComponent();
            _Mode = Mode;
        }
        private clsAccount _Account;
        private void frmDeposit_Withdraw_Load(object sender, EventArgs e)
        {
            if(_Mode == enMode.Deposit)
            {
                this.Text = "Deposit Screen";
                lblTitle.Text= "Deposit";
                tpTransaction.Text = "Deposit";
                btnTransaction.Text = "Deposit";
                lblQuestion.Text = "Enter how much do you want to deposit ?";
            }
            else if(_Mode == enMode.Withdraw)
            {
                this.Text = "Withdraw Screen";
                lblTitle.Text = "Withdraw";
                tpTransaction.Text = "Withdraw";
                btnTransaction.Text = "Withdraw";
                lblQuestion.Text = "Enter how much do you want to withdraw ?";
            }
           
            pnlTransaction.Enabled = false;
        }
      
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _Account = clsAccount.FindAccount(Convert.ToInt32(txtFilterValue.Text));
            if (_Account != null)
            {
                lblAccountNumber.Text = _Account.AccountNumber.ToString();
                lblAccountType.Text = _Account.AccountType.ToString();
                lblOpenDate.Text = _Account.OpenDate.ToString();
                lblStatus.Text = _Account.Status.ToString();
                lblCustomerFullName.Text = _Account.CustomerInfo.PersonInfo.FullName;
                lblBalance.Text = _Account.Balance.ToString();
               
                    pnlTransaction.Enabled = true;
            }
            else
            {
                pnlTransaction.Enabled = false;
                lblAccountNumber.Text = "?";
                lblAccountType.Text = "?";
                lblOpenDate.Text = "?";
                lblStatus.Text = "?";
                lblCustomerFullName.Text = "?";
                lblBalance.Text = "?";
                MessageBox.Show($"This Account does not exist.", "fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Withdraw(double Amount)
        {
            if(_Account.Balance <= Amount)
            {
                MessageBox.Show($"you can't withdraw more than your balance.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(_Account.AccountTypeInfo.WithdrawPerDay>=Amount)
            {
               if (_Account.Withdraw(Amount))
                {
                    
                    _Account.Balance = _Account.Balance - Amount;
                    lblBalance.Text = _Account.Balance.ToString();
                    tabControl1.SelectedIndex = 0;
                    MessageBox.Show("Transaction performed successffully.", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               else
                    MessageBox.Show($"Transaction failed. ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"The most amount you can withdraw per day is : {_Account.AccountTypeInfo.WithdrawPerDay}.. ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Deposit(double Amount)
        {
           

            if (_Account.AccountTypeInfo.DepositPerDay >= Amount)
            {
                if (_Account.Deposit(Amount))
                {
                    _Account.Balance = _Account.Balance +Amount;
                    lblBalance.Text = _Account.Balance.ToString();
                    tabControl1.SelectedIndex = 0;
                    MessageBox.Show("Transaction performed successffully.", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show($"Transaction failed. ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"The most amount you can deposit per day is : {_Account.AccountTypeInfo.DepositPerDay}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBalance_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtBalance.Text)) 
            {
                e.Cancel= true;
                txtBalance.Focus();
                errorProvider1.SetError(txtBalance, "Balance must not be empty");
            }
            else
            {
                e.Cancel = false;
                txtBalance.Focus();
                errorProvider1.SetError(txtBalance, "");
            }
        }

        private void btnTransaction_Click_1(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_Account.Status == "Closed")
            {
                MessageBox.Show($"Account : {_Account.AccountNumber} is closed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToDouble(txtBalance.Text) < 0)
            {
                MessageBox.Show("Amount must not be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Mode == enMode.Withdraw)
                Withdraw(Convert.ToDouble(txtBalance.Text));
            else
                Deposit(Convert.ToDouble(txtBalance.Text));
        }

        private void txtBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
