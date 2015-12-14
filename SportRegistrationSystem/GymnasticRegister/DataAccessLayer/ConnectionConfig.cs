using System.Configuration;

namespace GymnasticRegister.DataAccessLayer
{
    class ConnectionConfig
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
        }
    }
}
