using ATM.GlobalClasses;
using ATM_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;

            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSubmit.PerformClick();
                e.Handled = true;
            }
        }


        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            clsAccount Account = clsAccount.FindByPINCode(txtPin.Text);

            if (Account == null)
            {
                MessageBox.Show("Wrong PIN Code, Try a right one", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmMain frm = new frmMain(this);
            clsGlobal.CurrentAccount = Account;
            frm.Show();
            this.Hide();
            
        }
    }
}
