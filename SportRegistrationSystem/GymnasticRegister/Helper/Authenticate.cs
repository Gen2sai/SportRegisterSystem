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
