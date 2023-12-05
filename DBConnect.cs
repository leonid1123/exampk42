using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace exampk42
{
    internal static class DBConnect
    {
        static MySqlConnection conn;
        public static MySqlConnection Connection()
        {
            var connection = new MySqlConnection("Server=localhost;User ID=student;Password=student;Database=exampk42");
            connection.Open();
            return connection;
        }
    }
}
