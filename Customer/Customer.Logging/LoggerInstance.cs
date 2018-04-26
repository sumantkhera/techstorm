using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Logging
{
    public sealed class LoggerInstance
    {
        private static Log4NetLogger _iLogger = null;
        private LoggerInstance()
        {

        }

        public static ILogger Logger
        {
            get
            {
                return Log4NetLogger.Instance;
            }
        }
    }
}
