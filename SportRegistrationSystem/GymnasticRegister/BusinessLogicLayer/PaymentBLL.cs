using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymnasticRegister.DataAccessLayer;

namespace GymnasticRegister.BusinessLogicLayer
{
    internal class PaymentBLL
    {
        public static int GetReceiptNumber()
        {
            return PaymentDAL.GetReceiptNumber();
        }
    }
}
