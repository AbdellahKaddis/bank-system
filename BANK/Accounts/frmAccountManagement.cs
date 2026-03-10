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
    public partial class frmAccountManagement : Form
    {
        public frmAccountManagement()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewAccount_Click(object sender, EventArgs e)
        {
            frmAddNewAccount frm=new frmAddNewAccount();
            frm.ShowDialog();
            _FilDgv();
        }

        private DataTable _Accounts;

        private void _FilDgv()
        {
            _AddColumnsToDgv();
            _Accounts=clsAccount.GetAllAccounts();
            dgvAccounts.DataSource = _Accounts;
            lblNumberOfAccounts.Text=dgvAccounts.Rows.Count.ToString();
        }

        private void _FillCb()
        {
            cbFilter.Items.Clear();
            cbFilter.Items.Add("---Filter By---");
            cbFilter.Items.Add("Account Number");
            cbFilter.Items.Add("Account Type");
            cbFilter.Items.Add("Open Date");
            cbFilter.Items.Add("Status");
            cbFilter.SelectedIndex = 0;
        }

        private void _AddColumnsToDgv()
        {
            if(dgvAccounts.Rows.Count>0)
            {
                dgvAccounts.Columns[0].HeaderText = "Account Number";
                dgvAccounts.Columns[0].Width = 140;

                dgvAccounts.Columns[1].HeaderText = "Account Type";
                dgvAccounts.Columns[1].Width = 130;

                dgvAccounts.Columns[2].HeaderText = "Balance";
                dgvAccounts.Columns[2].Width = 130;

                dgvAccounts.Columns[3].HeaderText = "OpenDate";
                dgvAccounts.Columns[3].Width = 120;

                dgvAccounts.Columns[4].HeaderText = "Status";
                dgvAccounts.Columns[4].Width = 60;

                dgvAccounts.Columns[5].HeaderText = "Customer Name";
                dgvAccounts.Columns[5].Width = 130;


                dgvAccounts.Columns[6].HeaderText = "CreatedByUserId";
                dgvAccounts.Columns[6].Width = 100;
            }
           
        }
        private void frmAccountManagement_Load(object sender, EventArgs e)
        {
           
            _FilDgv();
            _FillCb();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilDgv();
          
            if(cbFilter.Text == "---Filter By---")
            {
                dtpOpenDateFilter.Visible = false;
                txtFilterValue.Visible = false;
                cbIsActive.Visible = false;
            }
            else
            {
                if(cbFilter.Text == "Status")
                {
                    cbIsActive.Visible = true;
                    txtFilterValue.Visible = false;
                    dtpOpenDateFilter.Visible = false;
                    cbIsActive.Focus();
                    cbIsActive.SelectedIndex = 0;
                }
                else if (cbFilter.Text == "Open Date")
                {
                    dtpOpenDateFilter.Visible = true;
                    txtFilterValue.Visible = false;
                    cbIsActive.Visible = false;
                    dtpOpenDateFilter.Focus();
                }
                else
                {
                    dtpOpenDateFilter.Visible = false;
                    cbIsActive.Visible = false;
                    txtFilterValue.Visible = true;
                    txtFilterValue.Focus();
                    txtFilterValue.Text = "";
                }
                
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            if (string.IsNullOrWhiteSpace(txtFilterValue.Text))
            {
                //_Accounts.DefaultView.RowFilter = "";
                //lblNumberOfAccounts.Text = dgvAccounts.Rows.Count.ToString();
                _FilDgv();
                return;
            }

            switch (cbFilter.Text)
            {
                case "Account Number":
                    FilterColumn = "AccountNumber";
                    break;
                case "Account Type":
                    _Accounts=clsAccount.FilterByAccountType(txtFilterValue.Text);
                    dgvAccounts.DataSource = _Accounts;
                    lblNumberOfAccounts.Text = dgvAccounts.Rows.Count.ToString();
                    return;
                default:
                    FilterColumn = "None";
                    break;
            }

           
            if(cbFilter.Text == "Account Number")
                _Accounts.DefaultView.RowFilter = $"[{FilterColumn}] = {txtFilterValue.Text}";

            lblNumberOfAccounts.Text = dgvAccounts.Rows.Count.ToString();

        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Account Number")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbIsActive.Text == "All")
            {
                _Accounts.DefaultView.RowFilter = "";
                lblNumberOfAccounts.Text = dgvAccounts.Rows.Count.ToString();
                return;
            }

            if(cbIsActive.Text == "Active")
                _Accounts.DefaultView.RowFilter = $"[Status] =1";
            else
                _Accounts.DefaultView.RowFilter = $"[Status] = 0";

            lblNumberOfAccounts.Text = dgvAccounts.Rows.Count.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _Accounts = clsAccount.FilterByOpenDate(dtpOpenDateFilter.Value);
            dgvAccounts.DataSource = _Accounts;
            lblNumberOfAccounts.Text = dgvAccounts.Rows.Count.ToString();
        }

        private void fToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddNewAccount frm=new frmAddNewAccount();
            frm.ShowDialog();
        }

        private void deleteAccountStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AccountNumber = (int)dgvAccounts.CurrentRow.Cells[0].Value;
            clsAccount account = clsAccount.FindAccount(AccountNumber);
            if (MessageBox.Show("Are you sure you want to delete Account [" + dgvAccounts.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsAccount.DeleteAccount(AccountNumber))
                {
                    if (!clsAccount.IsCustomerHaveAnotherAccount(account.CustomerId))
                        clsCustomer.DeleteCustomer(account.CustomerId);
                    _FilDgv();
                    MessageBox.Show("Account Deleted Succeffully.", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                    MessageBox.Show("failed to delete.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeAccuntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close Account [" + dgvAccounts.CurrentRow.Cells[0].Value + "]", "Confirm Close", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {
                if (clsAccount.ChangeAccountStatus((int)dgvAccounts.CurrentRow.Cells[0].Value,0))
                {
                    MessageBox.Show("Account Closed Succeffully.", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _FilDgv();
                }
                else
                    MessageBox.Show("failed to Close.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void activeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to active Account [" + dgvAccounts.CurrentRow.Cells[0].Value + "]", "Confirm Active", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {
                if (clsAccount.ChangeAccountStatus((int)dgvAccounts.CurrentRow.Cells[0].Value, 1))
                {
                    MessageBox.Show("Account Actived Succeffully.", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _FilDgv();
                }
                else
                    MessageBox.Show("failed to Close.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowAccountInformation frm = new frmShowAccountInformation(Convert.ToInt32(dgvAccounts.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }
    }
}
