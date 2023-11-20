using System;
using System.Data.SqlClient;

namespace YourProjectName
{
    public class DataAccess : IDisposable
    {
        private string connectionString;
        private SqlConnection connection;

        public DataAccess(string connectionString)
        {
            this.connectionString = connectionString;
            this.connection = new SqlConnection(connectionString);

            // Open the connection in the constructor if you want to establish it immediately.
            connection.Open();
        }

        // Other data access methods can be defined here

        public void Dispose()
        {
            // Dispose of the SqlConnection and release any resources
            if (connection != null)
            {
                connection.Dispose();
            }
        }
    }
}
