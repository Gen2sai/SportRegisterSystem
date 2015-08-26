using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using GymnasticRegister.DataAccessLayer;

namespace GymnasticRegister.BusinessLogicLayer
{
    internal class StaffBLL
    {
        public bool Login(string Username, string Password)
        {
            int loginCount = StaffDAL.LoginStaff(Username, Password);

            return loginCount == 1;
        }

        public bool RegisterStaff(string Username, string Password, string Fullname, int Permission)
        {
            int status = StaffDAL.CreateStaff(Username, Password, Fullname, Permission);

            return status != 0;
        }
    }
}
