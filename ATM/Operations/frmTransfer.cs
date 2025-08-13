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

namespace ATM
{
    public partial class frmTransfer : Form
    {
        private frmMain _frmMain;
        public frmTransfer(frmMain frmMain)
        {
            InitializeComponent();

            _frmMain = frmMain;
        }



        private void btnSend_Click(object sender, EventArgs e)
        {
            double Amount = Convert.ToDouble(txtAmount.Text.Trim());

            if (clsGlobal.CurrentAccount.Balance < Amount)
            {
                MessageBox.Show("You can't transfer money more than your balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            clsAccount DestinationAccount = clsAccount.FindByAccountNumber(txtSendTo.Text.Trim());

            if (DestinationAccount == null)
            {
                MessageBox.Show($"No account with account number {txtSendTo.Text.Trim()} in the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            clsTransfer transfer = new clsTransfer();

            transfer.SourceAccountID = clsGlobal.CurrentAccount.AccountID;
            transfer.DestinationAccountID = DestinationAccount.AccountID;
            transfer.Amount = Amount;

            if (transfer.Transfer(clsGlobal.CurrentAccount,DestinationAccount))
                MessageBox.Show("Transfer Done Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Transfer Failed", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            _frmMain.Show();
        }
    }
}
