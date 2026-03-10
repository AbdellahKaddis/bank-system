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
    public partial class frmPeopleManagement : Form
    {
        public frmPeopleManagement()
        {
            InitializeComponent();
        }

        private DataTable _People;
        private void _FillDgv()
        {
            _People = clsPerson.GetAllPeople();
            dgvPeople.DataSource= _People;

            dgvPeople.Columns[0].HeaderText = "Person ID";
            dgvPeople.Columns[0].Width = 80;

            dgvPeople.Columns[1].HeaderText = "National Number";
            dgvPeople.Columns[1].Width = 100;

            dgvPeople.Columns[2].HeaderText = "First Name";
            dgvPeople.Columns[2].Width = 80;

            dgvPeople.Columns[3].HeaderText = "Last Name";
            dgvPeople.Columns[3].Width = 80;

            dgvPeople.Columns[4].HeaderText = "Gender";
            dgvPeople.Columns[4].Width = 80;

            dgvPeople.Columns[5].HeaderText = "Date Of Birth";
            dgvPeople.Columns[5].Width = 80;

            dgvPeople.Columns[6].HeaderText = "Address";
            dgvPeople.Columns[6].Width = 140;

            dgvPeople.Columns[7].HeaderText = "Phone";
            dgvPeople.Columns[7].Width = 80;

            dgvPeople.Columns[8].HeaderText = "Email";
            dgvPeople.Columns[8].Width = 180;

            lblNumberOfPeople.Text = dgvPeople.Rows.Count.ToString();
        }

        private void FillCmb()
        {
            cmbFilter.Items.Clear();
            cmbFilter.Items.Add("---Filter By---");
            cmbFilter.Items.Add("Person ID");
            cmbFilter.Items.Add("National Number");
            cmbFilter.Items.Add("First Name");
            cmbFilter.Items.Add("Last Name");
            cmbFilter.Items.Add("Gender");
            cmbFilter.Items.Add("Date Of Birth");
            cmbFilter.SelectedIndex = 0;
        }
        private void frmPeopleManagement_Load(object sender, EventArgs e)
        {
            _FillDgv();
            FillCmb();
            
        }

        private void updatePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd_Update_Person frm = new frmAdd_Update_Person((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.DataBack += RefreshDgv;
            frm.ShowDialog();
        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person [" + dgvPeople.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {
                if (clsPerson.DeletePerson((int)dgvPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Succeffully.", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _FillDgv();
                }
                else
                    MessageBox.Show("failed to delete.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDgv(object sender,int PersonId)
        {
            _People = clsPerson.GetAllPeople();
            dgvPeople.DataSource = _People;
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAdd_Update_Person frm = new frmAdd_Update_Person(-1);
            frm.DataBack += RefreshDgv;
            frm.ShowDialog();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbFilter.Text == "---Filter By---")
            {
                txtFilterValue.Visible= false;
            }
            else
            {
                txtFilterValue.Visible= true;    
            }
            txtFilterValue.Focus();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cmbFilter.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonId";
                    break;
                case "National Number":
                    FilterColumn = "NationalNumber";
                    break;
                case "First Name":
                    FilterColumn = "FirstName";
                    break;
                case "Last Name":
                    FilterColumn = "LastName";
                    break;
                case "Gender":
                    FilterColumn = "Gender";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if(string.IsNullOrWhiteSpace(txtFilterValue.Text) || txtFilterValue.Text=="None")
            {
                _People.DefaultView.RowFilter = "";
                lblNumberOfPeople.Text=dgvPeople.Rows.Count.ToString();
                return;
            }

            if(FilterColumn == "PersonId")
                _People.DefaultView.RowFilter = $"[{FilterColumn}] = {txtFilterValue.Text.Trim()}";
            else
                _People.DefaultView.RowFilter = $"[{FilterColumn}] LIKE '{txtFilterValue.Text.Trim()}%'";
            lblNumberOfPeople.Text = dgvPeople.Rows.Count.ToString();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd_Update_Person frm = new frmAdd_Update_Person(-1);
            frm.DataBack += RefreshDgv;
            frm.ShowDialog();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showPersonInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonInformation frm = new frmShowPersonInformation((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilter.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void lblNumberOfPeople_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
