using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Data_Access_Layer
{
    class DataAccess
    {
        protected SqlConnection connection;
        protected SqlCommand command;

        public DataAccess()
        {
            try
            {
                this.connection = new SqlConnection(@"Data Source=(local);Initial Catalog=DigitalPhotoDiaryDb;Integrated Security=True");
                this.connection.Open();
            }
            catch (Exception exp)
            {

            }
        }
        public SqlDataReader GetData(string sql)
        {
            this.command = new SqlCommand(sql, connection);
            return this.command.ExecuteReader();
        }

        public int ExecuteQuery(string sql)
        {
            this.command = new SqlCommand(sql, connection);
            return this.command.ExecuteNonQuery();
        }

    }
}
