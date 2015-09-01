using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using GymnasticRegister.Helper;
using GymnasticRegister.Model;

namespace GymnasticRegister.DataAccessLayer
{
    class StaffDAL
    {
        public static List<StaffClass> LoginStaff(string Username, string Password)
        {
            List<StaffClass> results = new List<StaffClass>();
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionConfig.GetConnectionString());
                SqlCommand cmd;
                SqlDataReader dr;
                
                cmd = new SqlCommand("SELECT * FROM  User WHERE Username = @username AND Password = @password", conn);
                cmd.Parameters.AddWithValue("@username", Username);
                cmd.Parameters.AddWithValue("@password", Password);

                conn.Open();
                //int x = (int)cmd.ExecuteScalar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        StaffClass items = new StaffClass();

                        items.StaffID = dr.GetInt32(0);
                        items.Username = dr.GetString(1);
                        items.Password = dr.GetString(2);
                        items.Fullname = dr.GetString(3);
                        items.PermissionID = dr.GetInt32(4);

                        results.Add(items);
                    }
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

        public static int CreateStaff(string Username, string Password, string Fullname, int Permission)
        {
            try
            {
                int status;
                SqlConnection conn = new SqlConnection(ConnectionConfig.GetConnectionString());
                SqlCommand cmd;

                cmd =
                    new SqlCommand(
                        "IF(NOT EXISTS(SELECT Username FROM Staff WHERE Username = @Username)) BEGIN INSERT INTO Staff (Username, Password, FullName, PermissionID) VALUES (@Username, @Password, @FullName, @PermissionID) END", conn);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@Fullname", Fullname);
                cmd.Parameters.AddWithValue("@PermissionID", Permission);

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

        public static int DeleteStaff(string Username, string Password, string Fullname, int Permission)
        {
            return 0;
        }

        public static int UpdateStaff(string Username, string Password, string Fullname, int Permission)
        {
            return 0;
        }
    }
}
