using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourProjectName;

namespace empMngSystem
{
    public class CRUD
    {
        private string connectionString;

        public DataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void CreateEmployee(Employee, employee)
        {
            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                connection.Open();

            }
        }
    }
}
