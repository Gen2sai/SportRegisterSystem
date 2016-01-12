using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymnasticRegister.DataAccessLayer;

namespace GymnasticRegister.BusinessLogicLayer
{
    class ReportingBLL
    {
        public static DataTable ReportLookup(DateTime startDate)
        {
            return ReportingDAL.ReportLookup(startDate);
        }
    }
}
