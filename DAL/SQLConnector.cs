using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SQLConnector
    {
        private static readonly string server = @"ADMIN\SQLEXPRESS";
        private static readonly string databaseName = "EMPLOYEE_MANAGEMENT";

        public static SqlConnection GetConnection(int type)
        {
            SqlConnection connection = new SqlConnection();

            if (type == 0)
            {
                //connect by authen window
                connection.ConnectionString = $@"Data Source={server}; Initial Catalog={databaseName}; Integrated Security=True";
                
            } else if(type == 1)
            {
                //connect by authen sql account
                connection.ConnectionString = GetConnectionStringBySqlAccount();
            }

            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                connection = null;
            }

            return connection;
        }

        public static string GetConnectionStringBySqlAccount()
        {
            string sqlUsername = EmployeeDAL.employeeSession.SqlUsername;
            string sqlPassword = EmployeeDAL.employeeSession.SqlPassword;
            string connectionString = $@"Server={server}; Database={databaseName}; User Id={sqlUsername}; Password={sqlPassword};";

            return connectionString;
        }

        //public static string ReadLoginFile()
        //{
        //    string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
        //    string parentDirectoryPath = Directory.GetParent(directoryPath).Parent?.Parent?.Parent?.FullName;

        //    // Xây dựng đường dẫn tương đối của tệp tin
        //    string relativeFilePath = Path.Combine(parentDirectoryPath, @"LoginSQL\nv_nhansu.txt");

        //    // Mở tệp tin để đọc
        //    using (StreamReader reader = new StreamReader(relativeFilePath))
        //    {
        //        // Đọc dòng 1
        //        string username = reader.ReadLine();

        //        // Đọc dòng 2
        //        string password = reader.ReadLine();
   
        //        return $@"Server={server}; Database={databaseName}; User Id={username}; Password={password};";
        //    }
        //}
    }
}
