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
    public partial class frmShowPersonInformation : Form
    {
        private string _NationalNumber = "";
        public frmShowPersonInformation(string NationalNumber)
        {
            InitializeComponent();
           _NationalNumber = NationalNumber;
        }
        private int _PersonId=-1;
        public frmShowPersonInformation(int PersonId)
        {
            InitializeComponent();
             _PersonId= PersonId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowPersonInformation_Load(object sender, EventArgs e)
        {
            if(_PersonId != -1)
                ctrPersonCard1.LoadPersonInfo(_PersonId);
            else
                ctrPersonCard1.LoadPersonInfo(_NationalNumber);


        }
    }
}
