using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymnasticRegister.Helper;

namespace GymnasticRegister.DataAccessLayer
{
    class PaymentDAL
    {
        public static int GetReceiptNumber()
        {
            try
            {
                int count;
                SqlConnection conn = new SqlConnection(ConnectionConfig.GetConnectionString());
                SqlCommand cmd;

                cmd =
                    new SqlCommand("SELECT COUNT (ID) FROM Payment", conn);

                conn.Open();
                count = (int)cmd.ExecuteScalar();
                conn.Close();

                return count;
            }
            catch (Exception ex)
            {
                ErrorLog.LogError(ex);
                return 0;
            }
        }
    }
}
