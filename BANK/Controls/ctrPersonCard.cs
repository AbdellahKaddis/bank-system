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
    public partial class ctrPersonCard : UserControl
    {
        public ctrPersonCard()
        {
            InitializeComponent();
        }

        private int _PersonId = -1;
        public int PersonId { get { return _PersonId; } }
        public clsPerson PersonInfo { get { return _person; } }
        private clsPerson _person;
        private void llEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdd_Update_Person frm = new frmAdd_Update_Person(_person.PersonId);
            frm.ShowDialog();
            LoadPersonInfo(_person.PersonId);
        }

        public void LoadPersonInfo(int PersonId)
        {
             _person= clsPerson.FindPerson(PersonId);
            if (_person != null)
                _FillPersonInfo();
            else
            {
                ResetData();
                MessageBox.Show("Person does not exist.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _FillPersonInfo()
        {
              llEdit.Enabled= true;
            _PersonId = _person.PersonId;
                lblPersonId.Text = _person.PersonId.ToString();
                lblNationalNumber.Text = _person.NationalNumber;
                lblFullName.Text = _person.FullName;
                lblGender.Text = _person.Gender;
                lblDateOfBirth.Text = _person.DateOfBirth.ToString();
                lblPhone.Text = _person.Phone;
                lblEmail.Text = _person.Email == null?"Does Not Exist.":_person.Email;
                lblAddress.Text = _person.Address;
        }

        public void ResetData()
        {
            _PersonId = -1;
            llEdit.Enabled = false;
            lblPersonId.Text = "???";
            lblNationalNumber.Text = "???";
            lblFullName.Text = "???";
            lblGender.Text = "???";
            lblDateOfBirth.Text = "???";
            lblPhone.Text = "???";
            lblEmail.Text = "???";
            lblAddress.Text = "???";
        }
        public void LoadPersonInfo(string NationalNumber)
        {
            _person = clsPerson.FindPerson(NationalNumber);

            if (_person != null)
                _FillPersonInfo();
            else
            {
                ResetData();
                MessageBox.Show("Person does not exist.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctrPersonCard_Load(object sender, EventArgs e)
        {
            llEdit.Enabled=false;
        }
    }
}
