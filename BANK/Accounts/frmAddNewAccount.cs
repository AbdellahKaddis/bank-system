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
    public partial class frmAddNewAccount : Form
    {
        public frmAddNewAccount()
        {
            InitializeComponent();
        }

        private int _PersonId=-1;
        private DataTable _AccountsType;
        private void _FillCb()
        {
            cbAccountTypes.Items.Clear();
            cbAccountTypes.Items.Add("---Choose a type---");
           _AccountsType = clsAccountType.GetAllAccountsType();
            foreach(DataRow dr in _AccountsType.Rows)
            { 
                cbAccountTypes.Items.Add(dr["AccountTypeName"]); 
            }
            cbAccountTypes.SelectedIndex = 0;
        }
        private void frmAddNewAccount_Load(object sender, EventArgs e)
        {
            _FillCb();
            pnlAccountInfo.Enabled = false;
            btnSave.Enabled = false;    
        }

        private void ctrFindPerson1_OnPersonSelected(int obj)
        {
            if (obj == -1)
            {
                pnlAccountInfo.Enabled = false;
                btnSave.Enabled = false;
                _PersonId = -1;
            }
            else
            {
                pnlAccountInfo.Enabled = true;
                btnSave.Enabled = false;
                _PersonId = obj;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            clsCustomer customer=clsCustomer.FindCustomer(_PersonId);

            if(customer == null)
            {
                customer=new clsCustomer();
                customer.PersonId = _PersonId;

                if (!customer.AddCustomer())
                {
                    MessageBox.Show("failed to add customer.", "fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


          

            clsAccount account = new clsAccount();
            account.CustomerId = customer.CustomerId;
            account.Balance=Convert.ToDouble(txtBalance.Text);
            account.AccountType = cbAccountTypes.SelectedIndex;
            account.Status = chkIsActive.Checked ? "Active" : "Closed";
            account.OpenDate = DateTime.Now;
            account.CreatedByUserId = frmMainScreen.CurrentUser.UserId;

            if (account.AddAccount())
            {
                MessageBox.Show($"Account Added Successffuly with AccountNumber [{account.AccountNumber}].", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("fail to add account.", "fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBalance_Validating(object sender, CancelEventArgs e)
        {
          
            if(string.IsNullOrWhiteSpace(txtBalance.Text))
            {
                e.Cancel = true;
                txtBalance.Focus();
                errorProvider1.SetError(txtBalance, "Balance should not be empty.");
                btnSave.Enabled = false;
                return;
            }
            else
            {
                e.Cancel = false ;
                errorProvider1.SetError(txtBalance, "");
            }

            foreach (DataRow dr in _AccountsType.Rows)
            {
                if(cbAccountTypes.Text == dr["AccountTypeName"].ToString())
                {
                    if(Convert.ToDouble(txtBalance.Text) >= Convert.ToDouble(dr["StartBalance"]))
                    {
                        e.Cancel = false;
                        errorProvider1.SetError(txtBalance, "");

                        if(Convert.ToDouble(txtBalance.Text) > Convert.ToDouble(dr["DepositPerDay"]))
                        {
                            e.Cancel = true;
                            txtBalance.Focus();
                            errorProvider1.SetError(txtBalance, $"The most deposit of money you can perform in a day is {dr["DepositPerDay"]} into account of type{dr["AccountTypeName"]}.");
                        }
                        else
                        {
                            btnSave.Enabled = true;
                            e.Cancel = false;
                            errorProvider1.SetError(txtBalance, "");
                        }
                    }
                    else
                    {
                        e.Cancel = true;
                        txtBalance.Focus();
                        btnSave.Enabled = false;
                        errorProvider1.SetError(txtBalance, $"If you want to add account of type{dr["AccountTypeName"]} you must deposit at least {dr["StartBalance"]}.");
                    }
                }
            }
        }

        private void txtBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbAccountTypes_Validating(object sender, CancelEventArgs e)
        {
            if (clsAccount.IsThisPersonHaveAnAccountNumberOfThisType(cbAccountTypes.SelectedIndex, _PersonId))
            {
                e.Cancel = true;
                errorProvider1.SetError(cbAccountTypes, $"This Customer already have an account of type : {cbAccountTypes.Text}, choose another acount type.");
                btnSave.Enabled = false;
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbAccountTypes, "");
            }

            if(cbAccountTypes.Text == "---Choose a type---")
            {
                e.Cancel = true;
                errorProvider1.SetError(cbAccountTypes, "Choose a type.");
                btnSave.Enabled = false;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbAccountTypes, "");
            }
        }
    }
}
