using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BudgetF.ViewModels
{
    public partial class Database
    {
        public static Database Instance = new Database();

        private readonly string connectionString = "Data Source=DESKTOP-REG0P5N;Initial Catalog=Budget;Integrated Security=true;TrustServerCertificate=True";

        #region LOGIN
        internal bool Login(string Username, string Password)
        {
            string procedureName = "ValidateUser";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(procedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);

                        bool isValid = (bool)command.ExecuteScalar();
                        return isValid;


                    }
                }
                catch (SqlException sqlEx)
                {
                    string errorDetails = $"SQL Error: {sqlEx.Message}";
                    Console.WriteLine(errorDetails);
                    return false;
                }
                catch (Exception ex)
                {
                    string errorDetails = $"Error: {ex.Message}";
                    Console.WriteLine(errorDetails);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        #endregion

        #region CREATE
        internal bool CreateUser(string Firstname, string Lastname, string Username, string Password)
        {
            string procedureName = "CreateUser";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(procedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Firstname", Firstname);
                        command.Parameters.AddWithValue("@Lastname", Lastname);
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
                catch (SqlException sqlEx)
                {
                    string errorDetails = $"SQL Error: {sqlEx.Message}";
                    Console.WriteLine(errorDetails);
                    return false;
                }
                catch (Exception ex)
                {
                    string errorDetails = $"Error: {ex.Message}";
                    Console.WriteLine(errorDetails);
                    return false;
                }
            }
        }
        #endregion
    }
}
