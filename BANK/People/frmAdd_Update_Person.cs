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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace BANK
{
    public partial class frmAdd_Update_Person : Form
    {

        public delegate void DataBackEventHandler(object sender, int PersonId);
        public event DataBackEventHandler DataBack;
        private int _PersonId;
        private clsPerson _Person;
        public frmAdd_Update_Person(int PersonId)
        {
            InitializeComponent();
            _PersonId=PersonId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadPersonInfo()
        {
            _Person = clsPerson.FindPerson(_PersonId);
            if (_Person != null)
            {
                txtNationalNumber.Text = _Person.NationalNumber;
                txtFirstName.Text = _Person.FirstName;
                txtLastName.Text = _Person.LastName;
                txtAddress.Text = _Person.Address;
                txtEmail.Text = _Person.Email;
                txtPhone.Text = _Person.Phone;

                if (_Person.Gender.ToLower() == "male")
                    rbMale.Checked = true;
                else
                    rbFemale.Checked = true;

                dtpDateOfBirth.Value = _Person.DateOfBirth;
            }
        }
        private void frmAdd_Update_Person_Load(object sender, EventArgs e)
        {
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            rbMale.Checked = true;
            if(_PersonId != -1)
            {
                lblTitle.Text = "Update Person";
                this.Text = "Update Screen";
                LoadPersonInfo();
            }
            else
            {
                lblTitle.Text = "Add New Person";
                this.Text = "Add New Person Screen";
                _Person = new clsPerson();
            }
        }

        private void ValidateTextBox(object sender, CancelEventArgs e)
        {
            
            TextBox textBox = ((TextBox)sender);
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                errorProvider1.SetError(textBox, "this field mustn't be empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, "");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


      
            _Person.NationalNumber = txtNationalNumber.Text;
            _Person.FirstName = txtFirstName.Text;
            _Person.LastName = txtLastName.Text;
            _Person.Gender = rbMale.Checked ? "Male" : "Female";
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                _Person.Email = null;
            else
                _Person.Email = txtEmail.Text;

            _Person.Phone = txtPhone.Text;
            _Person.Address = txtAddress.Text;
            _Person.DateOfBirth = dtpDateOfBirth.Value;


            if (_Person.Save())
            {
                MessageBox.Show("Person Saved Succefully.", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(this, _Person.PersonId);
                this.Close();
            }
            else
                MessageBox.Show("failed to save person.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, "");
            }
            else if(!clsValidation.IsEmailFormatValid(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "Email format is not valid");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, "");
            }
        }
    }
}
