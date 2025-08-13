using ATM.GlobalClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class frmBalance : Form
    {
        private frmMain _frmMain;
        public frmBalance(frmMain frmMain)
        {
            InitializeComponent();

            _frmMain = frmMain;
        }


        private void frmBalance_Load(object sender, EventArgs e)
        {
            lblAccountIdValue.Text = clsGlobal.CurrentAccount.AccountNumber;
            lblBalanceValue.Text = clsGlobal.CurrentAccount.Balance.ToString();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            _frmMain.Show();
        }
    }
}
