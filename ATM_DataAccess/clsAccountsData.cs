using System;
using System.Data.SqlClient;

namespace ATM_DataAccess
{
    public class clsAccountsData
    {
        public static bool GetAccountByPINCode(string PINCode,ref string AccountNumber,ref int AccountID,ref decimal Balance,ref bool IsLocked)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    string query = @"Select * from Accounts Where PINCode = @PINCode";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PINCode", PINCode);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                AccountID = (int)reader["AccountID"];
                                AccountNumber = (string)reader["AccountNumber"];
                                Balance = (decimal)reader["Balance"];
                                IsLocked = (bool)reader["IsLocked"];
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return IsFound;
        }
        public static bool GetAccountByAccountNumber(string AccountNumber, ref string PINCode, ref int AccountID, ref decimal Balance, ref bool IsLocked)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    string query = @"Select * from Accounts Where AccountNumber = @AccountNumber";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                AccountID = (int)reader["AccountID"];
                                PINCode = (string)reader["PINCode"];
                                Balance = (decimal)reader["Balance"];
                                IsLocked = (bool)reader["IsLocked"];
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return IsFound;
        }
        public static bool UpdateAccount(int AccountID,string AccountNumber , string PINCode, decimal Balance, bool IsLocked)
        {
            bool IsUpdated = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    string query = @"UPDATE Accounts 
                                    SET AccountNumber = @AccountNumber,
                                        PINCode = @PINCode,   
                                        Balance = @Balance, 
                                        IsLocked = @IsLocked 
                                    WHERE AccountID = @AccountID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AccountID", AccountID);
                        command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                        command.Parameters.AddWithValue("@PINCode", PINCode);
                        command.Parameters.AddWithValue("@Balance", Balance);
                        command.Parameters.AddWithValue("@IsLocked", IsLocked);

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();
                        IsUpdated = rowsAffected > 0;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return IsUpdated;
        }
    }
}
