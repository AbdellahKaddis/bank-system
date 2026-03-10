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
    public partial class ctrFindPerson : UserControl
    {
        public ctrFindPerson()
        {
            InitializeComponent();
        }

        public clsPerson PersonInformation { get { return ctrPersonCard1.PersonInfo; } }

        public string SerchField { set { txtFilterValue.Text = value; }get { return txtFilterValue.Text; } }
        public bool EnabledFilterBox { set { gbFilter.Enabled = value; }get { return gbFilter.Enabled; } }

        public event Action<int> OnPersonSelected;
 
        private void _FillCmb()
        {
            cmbFilter.Items.Clear();
          
            cmbFilter.Items.Add("Person ID");
            cmbFilter.Items.Add("National Number");
            
        }
        private void ctrFindPerson_Load(object sender, EventArgs e)
        {
            _FillCmb();
            cmbFilter.SelectedIndex = 0;
            txtFilterValue.Focus();
        }

        public void LoadPersonInfo(object sender,int PersonId)
        {
            txtFilterValue.Text=PersonId.ToString();
            btnSearch.PerformClick();
        }
        public void LoadUserInfo(object sender, int PersonId)
        {
            txtFilterValue.Text = PersonId.ToString();
            btnSearch_Click(null,null);
        }
        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAdd_Update_Person frm = new frmAdd_Update_Person(-1);
            frm.DataBack += LoadPersonInfo;
            frm.ShowDialog();
        }
  
        
        private void btnSearch_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtFilterValue.Text))
            {
                MessageBox.Show($"you did not enter nothing.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbFilter.Text == "Person ID")
                ctrPersonCard1.LoadPersonInfo(Convert.ToInt32(txtFilterValue.Text.Trim()));
            else if (cmbFilter.Text == "National Number")
                ctrPersonCard1.LoadPersonInfo(txtFilterValue.Text.Trim());

            if (OnPersonSelected != null)
                OnPersonSelected(ctrPersonCard1.PersonId);

        }


        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Focus();
        }

        
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
                {
                    if (cmbFilter.Text == "Person ID")
                        e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
                }
    }
}
