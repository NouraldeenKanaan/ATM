using ATM.Login;
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
    public partial class frmMain : Form
    {
        private frmLogin _frmLogin;
        public frmMain(frmLogin frmLogin)
        {
            InitializeComponent();

            _frmLogin = frmLogin;
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            frmBalance frm = new frmBalance(this);
            frm.Show();
            _frmLogin.Hide();
            this.Hide();
        }
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            frmWithdraw frm = new frmWithdraw(this);
            frm.Show();
            _frmLogin.Hide();
            this.Hide();
        }
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            frmDeposit frm = new frmDeposit(this);
            frm.Show();
            _frmLogin.Hide();
            this.Hide();
        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            frmTransfer frm = new frmTransfer(this);
            frm.Show();
            _frmLogin.Hide();
            this.Hide();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            _frmLogin.Show();
        }
    }
}
