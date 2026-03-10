using BANK.Users;
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
    public partial class frmUsersManagement : Form
    {
        public frmUsersManagement()
        {
            InitializeComponent();
        }

        private DataTable _Users;
        private void _FillDgv()
        {
            _Users = clsUser.GetAllUsers();
            dgvUsers.DataSource = _Users;

            dgvUsers.Columns[0].HeaderText = "User ID";
            dgvUsers.Columns[0].Width = 80;

            dgvUsers.Columns[1].HeaderText = "Person ID";
            dgvUsers.Columns[1].Width = 80;

            dgvUsers.Columns[2].HeaderText = "Full Name";
            dgvUsers.Columns[2].Width = 80;

            dgvUsers.Columns[3].HeaderText = "Role";
            dgvUsers.Columns[3].Width = 120;

            dgvUsers.Columns[4].HeaderText = "User Name";
            dgvUsers.Columns[4].Width = 80;

            dgvUsers.Columns[5].HeaderText = "Status";
            dgvUsers.Columns[5].Width = 80;

            lblNumberOfUsers.Text = dgvUsers.Rows.Count.ToString();
        }

        private void _FillCmb()
        {
            cmbFilter.Items.Clear();
            cmbFilter.Items.Add("---Filter By---");
        
            cmbFilter.Items.Add("User ID");
            cmbFilter.Items.Add("Person ID");
            cmbFilter.Items.Add("Full Name");
            cmbFilter.Items.Add("Role");
            cmbFilter.Items.Add("User Name");
            cmbFilter.Items.Add("Status");
            cmbFilter.SelectedIndex = 0;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsersManagement_Load(object sender, EventArgs e)
        {
            _FillDgv();
            _FillCmb();
            cbIsActive.Visible = false;
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.Text == "---Filter By---")
            {
                txtFilterValue.Visible = false;
                cbIsActive.Visible = false;
            }
            else
            {
                if(cmbFilter.Text == "Status")
                {
                    cbIsActive.Visible = true;
                    cbIsActive.SelectedIndex = 0;
                    txtFilterValue.Visible = false;
                    cbIsActive.Focus();
                }
                else
                {
                    txtFilterValue.Visible = true;
                    txtFilterValue.Focus();
                    cbIsActive.Visible = false;
                }
              
            }


          
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cmbFilter.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonId";
                    break;
                case "User ID":
                    FilterColumn = "UserId";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                case "Role":
                    FilterColumn = "Role";
                    break;
                case "UserName":
                    FilterColumn = "UserName";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (string.IsNullOrWhiteSpace(txtFilterValue.Text) || txtFilterValue.Text == "None")
            {
                _Users.DefaultView.RowFilter = "";
                lblNumberOfUsers.Text = dgvUsers.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "PersonId" || FilterColumn == "UserId")
                _Users.DefaultView.RowFilter = $"[{FilterColumn}] = {txtFilterValue.Text.Trim()}";
            else
                _Users.DefaultView.RowFilter = $"[{FilterColumn}] LIKE '{txtFilterValue.Text.Trim()}%'";
            lblNumberOfUsers.Text = dgvUsers.Rows.Count.ToString();
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAdd_Update_User frm=new frmAdd_Update_User();
            frm.ShowDialog();
            RefreshDgv();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbIsActive.Text == "All")
                _Users.DefaultView.RowFilter = "";
            else if (cbIsActive.Text == "Active")
                _Users.DefaultView.RowFilter = "[Status] = 1";
            else if(cbIsActive.Text == "Closed")
                _Users.DefaultView.RowFilter = "[Status] = 0";
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd_Update_User frm = new frmAdd_Update_User(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            RefreshDgv();
        }

        private void RefreshDgv()
        {
            _Users = clsUser.GetAllUsers();
            dgvUsers.DataSource= _Users;
        }
        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd_Update_User frm = new frmAdd_Update_User();
            frm.ShowDialog();
            RefreshDgv();

        }

        private void showInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frm = new frmShowUserInfo(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilter.Text == "Person ID" || cmbFilter.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Are you sure do you want to delete user with ID =[]" + (dgvUsers.CurrentRow.Cells[0].Value).ToString() + ".", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (clsUser.DeleteUser(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value)))
                    MessageBox.Show("User deleted successfully.", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("failed to delete user.", "fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RefreshDgv();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }
    }
}
