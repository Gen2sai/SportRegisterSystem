using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymnasticRegister.Enum;

namespace GymnasticRegister.Helper
{
    class Authenticate
    {
        public static bool Authentication(int StaffId, int permission)
        {
            return permission == (int)PermissionEnum.Admin || permission == (int)PermissionEnum.Staff && StaffId != null;
        }
    }
}
