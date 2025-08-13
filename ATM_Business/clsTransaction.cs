using ATM_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Business
{
    public class clsTransaction
    {
        public enum enTransactionTypes { Deposit = 1 , Withdraw = 2};
        
        public int TransactionID { get; set; }
        public enTransactionTypes TransacionTypeID { get; set; }
        public int AccountID { get; set; }

        public clsAccount AccountInfo;
        public double Amount { get; set; }
        public DateTime Date { get; set; }


        public clsTransaction()
        {
            this.TransactionID = -1;
            this.TransacionTypeID = enTransactionTypes.Deposit;
            this.AccountID = -1;
            this.Amount = -1;
            this.Date = DateTime.Now;
        }
        private clsTransaction(int TransactionID, enTransactionTypes TransactionTypeID, int AccountID, double Amount, DateTime Date)
        {
            this.TransactionID = TransactionID;
            this.TransacionTypeID = TransactionTypeID;
            this.AccountID = AccountID;
            this.Amount = Amount;
            this.Date = Date;
        }

        public bool AddTransaction()
        {
            return clsTransactionsData.AddTransaction((int)this.TransacionTypeID, this.AccountID, (decimal)this.Amount, this.Date);
        }

        public static bool WithdrawTransaction(int AccountID,double Amount)
        {
            clsTransaction NewTransaction = new clsTransaction();

            NewTransaction.TransacionTypeID = clsTransaction.enTransactionTypes.Withdraw;
            NewTransaction.AccountID = AccountID;
            NewTransaction.Amount = Amount;
            NewTransaction.Date = DateTime.Now;

            return NewTransaction.AddTransaction();
        }
        public static bool DepositTransaction(int AccountID, double Amount)
        {
            clsTransaction NewTransaction = new clsTransaction();

            NewTransaction.TransacionTypeID = clsTransaction.enTransactionTypes.Deposit;
            NewTransaction.AccountID = AccountID;
            NewTransaction.Amount = Amount;
            NewTransaction.Date = DateTime.Now;

            return NewTransaction.AddTransaction();
        }
    }
}
