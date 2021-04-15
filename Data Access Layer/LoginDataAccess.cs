using Digital_Photo_Diary.Data_Access_Layer.Entities;
using Inventory_Management_System.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Photo_Diary.Data_Access_Layer
{
    class LoginDataAccess : DataAccess
    {
        public int UserLoginValidation(User user)
        {
            string sql = "SELECT * FROM Users WHERE Username='" + user.Username + "' AND Password='" + user.Password + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return Convert.ToInt32(reader["UserType"]); ;
            }
            return -1;
        }
    }
}
