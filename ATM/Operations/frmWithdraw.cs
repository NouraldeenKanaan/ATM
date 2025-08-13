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
    public partial class frmWithdraw : Form
    {
        private frmMain _frmMain;
        public frmWithdraw(frmMain frmMain)
        {
            InitializeComponent();
           
            _frmMain = frmMain;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            double Amount = Convert.ToDouble(txtAmount.Text);

            if (clsGlobal.CurrentAccount.Balance < Amount)
            {
                MessageBox.Show("You can't withdraw more than your balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsGlobal.CurrentAccount.Withdraw(Amount))
                MessageBox.Show("Operation success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Operation Fail", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            _frmMain.Show();
        }


        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
