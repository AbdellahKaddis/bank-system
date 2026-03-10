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
    public partial class frmTransfer : Form
    {
        public frmTransfer()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTransfer_Load(object sender, EventArgs e)
        {
            gbSearch.Enabled = false;
            pnlTransaction.Enabled = false;
        }

        private clsAccount _Account1;
        private clsAccount _Account2;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            _Account1 = clsAccount.FindAccount(Convert.ToInt32(txtFilterValue.Text));
            if (_Account1 != null)
            {
                lblAccountNumber.Text = _Account1.AccountNumber.ToString();
                lblAccountType.Text = _Account1.AccountType.ToString();
                lblOpenDate.Text = _Account1.OpenDate.ToString();
                lblStatus.Text = _Account1.Status.ToString();
                lblCustomerFullName.Text = _Account1.CustomerInfo.PersonInfo.FullName;
                lblBalance.Text = _Account1.Balance.ToString();
                gbSearch.Enabled = true ;
            }
            else
            {
                gbSearch.Enabled = false;
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

        private void btnSerachForAccount2_Click(object sender, EventArgs e)
        {
            _Account2 = clsAccount.FindAccount(Convert.ToInt32(txtSearchField.Text));
            if (_Account2 != null)
            {
                lblAccountN.Text = _Account2.AccountNumber.ToString();
                lblAccountT.Text = _Account2.AccountType.ToString();
                lblODate.Text = _Account2.OpenDate.ToString();
                lblSts.Text = _Account2.Status.ToString();
                lblCfullname.Text = _Account2.CustomerInfo.PersonInfo.FullName;
                lblAmount.Text = _Account2.Balance.ToString();
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

        private void txtBalance_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBalance.Text))
            {
                e.Cancel = true;
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

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(_Account1.Status == "Closed")
            {
                MessageBox.Show($"Account : {_Account1.AccountNumber} is closed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_Account2.Status == "Closed")
            {
                MessageBox.Show($"Account : {_Account2.AccountNumber} is closed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double Amount = Convert.ToDouble(txtBalance.Text);
            if (Amount < 0)
            {
                MessageBox.Show("Amount must not be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(_Account1.Balance < Amount)
            {
                MessageBox.Show("you can't transfer more than you have.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Account1.Withdraw(Amount) && _Account2.Deposit(Amount))
            {

                _Account1.Balance = _Account1.Balance - Amount;
                _Account2.Balance = _Account2.Balance + Amount;
                lblBalance.Text = _Account1.Balance.ToString();
                lblAmount.Text = _Account2.Balance.ToString();
                tabControl1.SelectedIndex = 0;
                MessageBox.Show("Transaction performed successffully.", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show($"Transaction failed. ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
