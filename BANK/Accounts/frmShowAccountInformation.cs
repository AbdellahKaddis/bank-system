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

namespace BANK.Accounts
{
    public partial class frmShowAccountInformation : Form
    {
        private clsAccount _Account;
        public frmShowAccountInformation(int AccountNumber)
        {
            InitializeComponent();
            _Account=clsAccount.FindAccount(AccountNumber);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowAccountInformation_Load(object sender, EventArgs e)
        {
            if(_Account!=null)
            {
                lblAccountNumber.Text = _Account.AccountNumber.ToString();
                lblAccountType.Text= _Account.AccountType.ToString();
                lblOpenDate.Text = _Account.OpenDate.ToString();
                lblStatus.Text = _Account.Status.ToString();
                lblCustomerFullName.Text = _Account.CustomerInfo.PersonInfo.FullName;
                lblBalance.Text = _Account.Balance.ToString() +"  MAD";
            }
            else
            {
                MessageBox.Show($"This Account dos not exist.","fail",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
