using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymnasticRegister.DataAccessLayer;
using GymnasticRegister.Helper;

namespace GymnasticRegister.DataAccessLayer
{
    class UserDAL
    {
        public static int SelectUser(string Username, string Password)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionConfig.GetConnectionString());
                SqlCommand cmd;
                SqlDataReader dr;

                cmd = new SqlCommand("SELECT * FROM  User WHERE Username = @username AND Password = @password", conn);
                cmd.Parameters.AddWithValue("@username", Username);
                cmd.Parameters.AddWithValue("@password", Password);
                
                conn.Open();
                int x = (int)cmd.ExecuteScalar();
                conn.Close();

                return x;
                }
            catch (Exception ex)
            {
                ErrorLog.LogError(ex);
                return 0;
            }
        }
    }
}
