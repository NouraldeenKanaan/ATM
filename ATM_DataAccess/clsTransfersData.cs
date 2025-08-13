using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ATM_DataAccess
{
    public class clsTransfersData
    {
        public static bool AddTransfer(int SourceAccountID, int DestinationAccountID, decimal Amount, DateTime Date)
        {
            int RowsAffected = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    string query = @"INSERT INTO Transfers (SourceAccountID, DestinationAccountID, Amount, Date)
                                VALUES (@SourceAccountID, @DestinationAccountID, @Amount, @Date);
                                SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SourceAccountID", SourceAccountID);
                        command.Parameters.AddWithValue("@DestinationAccountID", DestinationAccountID);
                        command.Parameters.AddWithValue("@Amount", Amount);
                        command.Parameters.AddWithValue("@Date", Date);

                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            RowsAffected = insertedID;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return (RowsAffected != -1);
        }
    }
}
