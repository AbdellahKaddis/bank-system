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
    public partial class frmShowUserInfo : Form
    {
        private clsUser _User;
        public frmShowUserInfo(clsUser user)
        {
            InitializeComponent();
            _User = user;
        }

        public frmShowUserInfo(int userId)
        {
            InitializeComponent();
            _User =clsUser.FindUser(userId);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowUserInfo_Load(object sender, EventArgs e)
        {
            ctrPersonCard1.LoadPersonInfo(_User.PersonId);
            lblUserId.Text = _User.UserId.ToString();
            lblUserName.Text = _User.UserName;  
            lblStatus.Text= _User.Status;
            lblRole.Text = _User.Role;
        }
    }
}
