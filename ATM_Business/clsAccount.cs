using ATM_DataAccess;
using System;
using System.Text;

namespace ATM_Business
{
    public class clsAccount
    {
        public int AccountID { get; set; }
        public string AccountNumber { get; set; }
        public string PINCode { get; set; }
        public double Balance { get; set; }
        public bool IsLocked { get; set; }

        public clsAccount()
        {
            this.AccountID = -1;
            this.AccountNumber = "";
            this.PINCode = "";
            this.Balance = 0;
            this.IsLocked = false;
        }
        private clsAccount(int AccountID,string AccountNumber,string PINCode,double Balance,bool IsLocked)
        {
            this.AccountID = AccountID;
            this.AccountNumber = AccountNumber;
            this.PINCode = PINCode;
            this.Balance = Balance;
            this.IsLocked = IsLocked;
        }


        public static clsAccount FindByPINCode(string PINCode)
        {
            int AccountID = -1;
            string AccountNumber = "";
            decimal Balance = 0;
            bool IsLocked = false;

            if (clsAccountsData.GetAccountByPINCode(PINCode, ref AccountNumber, ref AccountID, ref Balance, ref IsLocked))
                return new clsAccount(AccountID, AccountNumber, PINCode, (double)Balance, IsLocked);
            else
                return null;
        }
        public static clsAccount FindByAccountNumber(string AccountNumber)
        {
            int AccountID = -1;
            string PINCode = "";
            decimal Balance = 0;
            bool IsLocked = false;

            if (clsAccountsData.GetAccountByAccountNumber(AccountNumber, ref PINCode, ref AccountID, ref Balance, ref IsLocked))
                return new clsAccount(AccountID, AccountNumber, PINCode, (double)Balance, IsLocked);
            else
                return null;
        }


        private bool _UpdateAccount()
        {
            return clsAccountsData.UpdateAccount(this.AccountID, this.AccountNumber, this.PINCode, (decimal)this.Balance, this.IsLocked);
        }
        public bool Withdraw(double Amount)
        {
            if (!clsTransaction.WithdrawTransaction(this.AccountID, Amount))
                return false ;

            Balance -= Amount;

            return _UpdateAccount();
        }
        public bool Deposit(double Amount)
        {
            if (!clsTransaction.DepositTransaction(this.AccountID, Amount))
                return false;

            Balance += Amount;

            return _UpdateAccount();
        }
    }
}
