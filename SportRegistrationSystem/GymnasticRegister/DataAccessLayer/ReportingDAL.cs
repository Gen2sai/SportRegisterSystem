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
    class ReportingDAL
    {
        public static DataTable ReportLookup(DateTime startDate)
        {
            try
            {
                DateTime endDate = startDate.AddMonths(1).AddDays(-1);

                SqlConnection conn = new SqlConnection(ConnectionConfig.GetConnectionString());
                SqlCommand cmd;
                SqlDataAdapter da;
                DataTable dt = new DataTable();

                cmd =
                    new SqlCommand("SELECT * FROM Payment WHERE ReceivedDate >= @startDate AND ReceivedDate <= @endDate", conn);
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);

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
    }
}
