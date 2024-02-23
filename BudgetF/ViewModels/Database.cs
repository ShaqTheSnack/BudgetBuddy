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
        internal bool CreateUser(string Firstname, string Lastname, string Username, string Password, double Salary)
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
                        command.Parameters.AddWithValue("@Salary", Salary);

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


        #region UPDATE
        internal void UpdateSalary(string Username, double NewSalary)
        {
            string procedureName = "UpdateSalary";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(procedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@NewSalary", NewSalary);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Salary updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("No rows affected. User might not exist or salary remains unchanged.");
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    string errorDetails = $"SQL Error: {sqlEx.Message}";
                    Console.WriteLine(errorDetails);
                }
                catch (Exception ex)
                {
                    string errorDetails = $"Error: {ex.Message}";
                    Console.WriteLine(errorDetails);
                }
            }
        }
        #endregion


        #region RETRIEVE
        internal double GetSalaryByUsername(string Username)
        {
            string procedureName = "GetSalaryByUsername";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(procedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Username", Username);

                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToDouble(result);
                        }
                        else
                        {
                            Console.WriteLine($"Salary for user '{Username}' not found.");
                            return -1;
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    string errorDetails = $"SQL Error: {sqlEx.Message}";
                    Console.WriteLine(errorDetails);
                    return -1;
                }
                catch (Exception ex)
                {
                    string errorDetails = $"Error: {ex.Message}";
                    Console.WriteLine(errorDetails);
                    return -1;
                }
            }
        }
        #endregion

    }
}
