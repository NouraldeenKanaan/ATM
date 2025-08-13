using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_DataAccess
{
    public class clsTransactionsData
    {
        public static bool AddTransaction(int TransactionTypeID, int AccountID, decimal Amount, DateTime Date)
        {
            bool IsAdded = false;
            int TransactionID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    string query = @"INSERT INTO Transactions (TransactionTypeID, AccountID, Amount, Date)
                                VALUES (@TransactionTypeID, @AccountID, @Amount, @Date);
                                SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TransactionTypeID", TransactionTypeID);
                        command.Parameters.AddWithValue("@AccountID", AccountID);
                        command.Parameters.AddWithValue("@Amount", Amount);
                        command.Parameters.AddWithValue("@Date", Date);

                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            TransactionID = insertedID;
                            IsAdded = true;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return IsAdded;
        }
    }
}
