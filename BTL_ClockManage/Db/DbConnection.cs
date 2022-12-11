using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BTL_ClockManage.Db
{
    public abstract class DbConnection
    {
        private readonly string connectionString;
        public DbConnection()
        {
            connectionString = @"Data Source=LAPTOP-0BND2VEU\SQLEXPRESS;Initial Catalog=QUANLYCUAHANGDH;Integrated Security=True";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
