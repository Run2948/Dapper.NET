using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick.DAL.Base
{
    public class ConnectionFactory
    {
        public static IDbConnection CreateConnection<T>() where T : IDbConnection, new()
        {
            IDbConnection connection = new T();
            connection.ConnectionString = ConnectionConfig.ConnectionString;
            connection.Open();
            return connection;
        }

        public static IDbConnection CreateSqlConnection()
        {
            return CreateConnection<SqlConnection>();
        }
    }
}
