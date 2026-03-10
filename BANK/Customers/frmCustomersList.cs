using BANK.Accounts;
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

namespace BANK.Customers
{
    public partial class frmCustomersList : Form
    {
        public frmCustomersList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DataTable _Customers;

        private void _FillDgv()
        {
            _Customers=clsCustomer.GetAllCustomers();
            dgvCustomers.DataSource = _Customers;
            lblNumberOfCustomers.Text=dgvCustomers.RowCount.ToString();
        }

        private void CreateDgvColumns()
        {
            if(dgvCustomers.Rows.Count>0)
            {
                dgvCustomers.Columns[0].HeaderText = "Customer Id";
                dgvCustomers.Columns[0].Width = 50;

                dgvCustomers.Columns[1].HeaderText = "Person Id";
                dgvCustomers.Columns[1].Width = 50;

                dgvCustomers.Columns[2].HeaderText = "National Number";
                dgvCustomers.Columns[2].Width = 50;

                dgvCustomers.Columns[3].HeaderText = "FullName";
                dgvCustomers.Columns[3].Width = 50;

                dgvCustomers.Columns[4].HeaderText = "Gender";
                dgvCustomers.Columns[4].Width = 50;

                dgvCustomers.Columns[5].HeaderText = "Date Of Birth";
                dgvCustomers.Columns[5].Width = 50;

                dgvCustomers.Columns[6].HeaderText = "Phone";
                dgvCustomers.Columns[6].Width = 50;

                dgvCustomers.Columns[7].HeaderText = "Account Number";
                dgvCustomers.Columns[7].Width = 50;

                dgvCustomers.Columns[8].HeaderText = "Account TypeName";
                dgvCustomers.Columns[8].Width = 50;

                dgvCustomers.Columns[9].HeaderText = "Balance";
                dgvCustomers.Columns[9].Width = 50;

                dgvCustomers.Columns[10].HeaderText = "OpenDate";
                dgvCustomers.Columns[10].Width = 50;

                dgvCustomers.Columns[11].HeaderText = "Status";
                dgvCustomers.Columns[11].Width = 50;
            }
        }

        private void _FillCb()
        {
           cbFilter.Items.Clear();
            cbFilter.Items.Add("---Filter By---");
            cbFilter.Items.Add("Customer Id");
            cbFilter.Items.Add("Person Id");
            cbFilter.Items.Add("National Number");
            cbFilter.Items.Add("FullName");
            cbFilter.Items.Add("Account Number");
            cbFilter.Items.Add("Account Type");
            cbFilter.Items.Add("Open Date");
            cbFilter.Items.Add("Status");
            cbFilter.SelectedIndex = 0;
        }
        private void frmCustomersList_Load(object sender, EventArgs e)
        {
            _FillDgv();
            _FillCb();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            if (string.IsNullOrWhiteSpace(txtFilterValue.Text))
            {
                _FillDgv();
                return;
            }

            switch (cbFilter.Text)
            {
                case "Customer Id":
                    FilterColumn = "CustomerId";
                    break;
                case "Person Id":
                    FilterColumn = "PersonId";
                    break;
                case "National Number":
                    FilterColumn = "NationalNumber";
                    break;
                case "FullName":
                    FilterColumn = "FullName";
                    break;
                case "Account Number":
                    FilterColumn = "AccountNumber";
                    break;
                case "Account Type":
                    _Customers = clsAccount.FilterByAccountType(txtFilterValue.Text);
                    dgvCustomers.DataSource = _Customers;
                    lblNumberOfCustomers.Text = dgvCustomers.Rows.Count.ToString();
                    return;
                default:
                    FilterColumn = "None";
                    break;
            }


            if (FilterColumn == "PersonId" || FilterColumn == "CustomerId" || FilterColumn == "AccountNumber")
                _Customers.DefaultView.RowFilter = $"[{FilterColumn}] = {txtFilterValue.Text}";
            else
                _Customers.DefaultView.RowFilter = $"[{FilterColumn}] LIKE '{txtFilterValue.Text}%'";

            lblNumberOfCustomers.Text=dgvCustomers.Rows.Count.ToString();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FillDgv();

            if (cbFilter.Text == "---Filter By---")
            {
                dtpOpenDateFilter.Visible = false;
                txtFilterValue.Visible = false;
                cbIsActive.Visible = false;
            }
            else
            {
                if (cbFilter.Text == "Status")
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

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIsActive.Text == "All")
            {
                _Customers.DefaultView.RowFilter = "";
                lblNumberOfCustomers.Text = dgvCustomers.Rows.Count.ToString();
                return;
            }

            if (cbIsActive.Text == "Active")
                _Customers.DefaultView.RowFilter = $"[Status] =1";
            else
                _Customers.DefaultView.RowFilter = $"[Status] = 0";
            lblNumberOfCustomers.Text = dgvCustomers.Rows.Count.ToString();
        }

        private void dtpOpenDateFilter_ValueChanged(object sender, EventArgs e)
        {
            _Customers = clsAccount.FilterByOpenDate(dtpOpenDateFilter.Value);
            dgvCustomers.DataSource = _Customers;
            lblNumberOfCustomers.Text = dgvCustomers.Rows.Count.ToString();
        }

        private void editCustomerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd_Update_Person frm = new frmAdd_Update_Person(Convert.ToInt32(dgvCustomers.CurrentRow.Cells["PersonId"].Value));
            frm.ShowDialog();
        }

        private void showAccountInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowAccountInformation frm = new frmShowAccountInformation(Convert.ToInt32(dgvCustomers.CurrentRow.Cells["AccountNumber"].Value));
            frm.Show();
        }

        private void showCustomerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonInformation frm = new frmShowPersonInformation(Convert.ToInt32(dgvCustomers.CurrentRow.Cells["PersonId"].Value));
            frm.ShowDialog();
        }
    }
}
