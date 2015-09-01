using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using GymnasticRegister.Helper;
using GymnasticRegister.Model;

namespace GymnasticRegister.DataAccessLayer
{
    class StaffDal
    {
        public static List<StaffClass> LoginStaff(string username, string password)
        {
            List<StaffClass> results = new List<StaffClass>();
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionConfig.GetConnectionString());
                SqlCommand cmd;
                SqlDataReader dr;

                cmd = new SqlCommand("SELECT * FROM Staff WHERE Username = @username AND Password = @password", conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    StaffClass items = new StaffClass
                    {
                        StaffId = dr.GetInt32(0),
                        Username = dr.GetString(1),
                        Password = dr.GetString(2),
                        Fullname = dr.GetString(3),
                        PermissionId = dr.GetInt32(4)
                    };

                    results.Add(items);
                }
                conn.Close();

                return results;
            }
            catch (Exception ex)
            {
                ErrorLog.LogError(ex);
                return results;
            }
        }

        public static int CreateStaff(string username, string password, string fullname, int permission)
        {
            try
            {
                int status;
                SqlConnection conn = new SqlConnection(ConnectionConfig.GetConnectionString());
                SqlCommand cmd;

                cmd =
                    new SqlCommand(
                        "IF(NOT EXISTS(SELECT Username FROM Staff WHERE Username = @Username)) BEGIN INSERT INTO Staff (Username, Password, FullName, PermissionID) VALUES (@Username, @Password, @FullName, @PermissionID) END", conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Fullname", fullname);
                cmd.Parameters.AddWithValue("@PermissionID", permission);

                conn.Open();
                status = cmd.ExecuteNonQuery();
                conn.Close();

                return status;
            }
            catch (Exception ex)
            {
                ErrorLog.LogError(ex);
                return 0;
            }
        }

        public static int DeleteStaff(string username, string password, string fullname, int permission)
        {
            return 0;
        }

        public static int UpdateStaff(string username, string password, string fullname, int permission)
        {
            return 0;
        }
    }
}
