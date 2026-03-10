using BANK_Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private string _UserName;
        private string _Password;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            _UserName= txtUserName.Text;
            _Password= txtPassword.Text;
            clsUser User=clsUser.FindUser(_UserName, _Password);
            if(User!=null)
            {
                if(User.Status == "Active")
                {
                    if (chkRememberMe.Checked)
                    {
                        SaveDataToTxtFile(_UserName,_Password);
                    }
                    else
                    {
                        File.WriteAllText("C:\\Users\\Electronic Store\\source\\repos\\BANK\\Login\\Login.txt", string.Empty);
                        txtUserName.Text = "";
                        txtPassword.Text = "";
                    }
                    frmMainScreen frm=new frmMainScreen(this,User);
                    this.Hide();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Your account is closed ,please talk to the manager","Error Validation",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Wrong Password or Username.","fail",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void SaveDataToTxtFile(string UserName,string Password)
        {
            using(StreamWriter writer=new StreamWriter("C:\\Users\\Electronic Store\\source\\repos\\BANK\\Login\\Login.txt",false))
            {
                writer.WriteLine(UserName);
                writer.WriteLine(Password);
            }
        }
        private bool ReadDataFromTxtFile(ref string  UserName,ref string  Password)
        {
            using(StreamReader Reader=new StreamReader("C:\\Users\\Electronic Store\\source\\repos\\BANK\\Login\\Login.txt"))
            {

                UserName = Reader.ReadLine();
                if(UserName != null)
                {
                    Password = Reader.ReadLine();
                    return true;
                }
                else
                {
                    UserName=null; 
                    Password=null;
                    return false;
                }
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
            if(ReadDataFromTxtFile(ref _UserName,ref _Password))
            {
                txtUserName.Text = _UserName;
                txtPassword.Text = _Password;
                chkRememberMe.Checked= true;
            }
          
        }
    }
}
