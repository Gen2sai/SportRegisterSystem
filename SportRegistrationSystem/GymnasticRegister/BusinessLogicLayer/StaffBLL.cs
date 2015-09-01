using System.Collections.Generic;
using GymnasticRegister.DataAccessLayer;
using GymnasticRegister.Model;

namespace GymnasticRegister.BusinessLogicLayer
{
    internal class StaffBll
    {
        public static List<StaffClass> Login(string username, string password)
        {
            List<StaffClass> results = StaffDal.LoginStaff(username, password);

            return results;
        }

        public static bool RegisterStaff(string username, string password, string fullname, int permission)
        {
            int status = StaffDal.CreateStaff(username, password, fullname, permission);

            return status == 1;
        }
    }
}
