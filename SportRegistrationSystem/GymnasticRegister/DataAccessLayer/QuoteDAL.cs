using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymnasticRegister.Helper;

namespace GymnasticRegister.DataAccessLayer
{
    class QuoteDAL
    {
        public static DataTable LoadQuotes()
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionConfig.GetConnectionString());
                SqlCommand cmd;
                SqlDataAdapter da;
                DataTable dt = new DataTable();

                cmd = new SqlCommand("SELECT * FROM Quote", conn);

                conn.Open();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                ErrorLog.LogError(ex);
                return null;
            }
        }

        public static void AddQuotes(string Quote)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionConfig.GetConnectionString());
                SqlCommand cmd;

                cmd = new SqlCommand("INSERT INTO Quote (Quote) VALUES (@Quote)", conn);
                cmd.Parameters.AddWithValue("@Quote", Quote);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                ErrorLog.LogError(ex);
            }
        }

        public static string GetRandomQuote()
        {
            try
            {
                string quote;
                SqlConnection conn = new SqlConnection(ConnectionConfig.GetConnectionString());
                SqlCommand cmd;

                cmd = new SqlCommand("SELECT TOP 1 Quote FROM Quote ORDER BY NEWID()", conn);

                conn.Open();
                quote = (string)cmd.ExecuteScalar();
                conn.Close();

                return quote;
            }
            catch (Exception ex)
            {
                ErrorLog.LogError(ex);
                return null;
            }
        }
    }
}
