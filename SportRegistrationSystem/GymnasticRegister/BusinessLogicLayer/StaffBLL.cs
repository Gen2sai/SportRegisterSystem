using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using GymnasticRegister.DataAccessLayer;
using GymnasticRegister.Enum;
using GymnasticRegister.Model;

namespace GymnasticRegister.BusinessLogicLayer
{
    internal class StaffBLL
    {
        public bool Login(string Username, string Password)
        {
            List<StaffClass> results = StaffDAL.LoginStaff(Username, Password);

            return results.Count > 0;
        }

        public static bool RegisterStaff(string Username, string Password, string Fullname, int Permission)
        {
            int status = StaffDAL.CreateStaff(Username, Password, Fullname, Permission);

            return status == 1;
        }
    }
}
