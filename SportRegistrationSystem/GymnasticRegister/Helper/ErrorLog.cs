using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using System.Diagnostics;

namespace GymnasticRegister.Helper
{
    class ErrorLog
    {
        private static Logger ExceptionLogger = LogManager.GetLogger("ExceptionLog");

        public static void LogError(Exception ex)
        {
            MappedDiagnosticsContext.Set("date", DateTime.Now.ToString());
            MappedDiagnosticsContext.Set("exception", ex.ToString());

            ExceptionLogger.Error("");
        }
    }
}
