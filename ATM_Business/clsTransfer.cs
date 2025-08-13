using ATM_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Business
{
    public class clsTransfer
    {
        public int TransferID { get; set; }
        public int SourceAccountID { get; set; }
        public int DestinationAccountID { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }

        public clsTransfer()
        {
            this.TransferID = -1;
            this.SourceAccountID = -1;
            this.DestinationAccountID = -1;
            this.Amount = 0;
            this.Date = DateTime.Now;
        }
       

        private bool AddTransfer()
        {
            return clsTransfersData.AddTransfer(this.SourceAccountID, this.DestinationAccountID, (decimal)this.Amount, this.Date);
        }
        public bool Transfer(clsAccount SourceAccount,clsAccount DestinationAccount)
        {
            this.Date = DateTime.Now;

            if (!SourceAccount.Withdraw(Amount))
                return false;

            if (DestinationAccount.Deposit(Amount))
                return true;

            if (AddTransfer())
                return true;

            return false;
        }
    }
}
