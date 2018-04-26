using Customer.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Customer.Controllers
{
    public class BaseController : ApiController
    {
        public ILogger _lLogger { get; set; }

        public BaseController()
        {
            _lLogger = Log4NetLogger.Instance;
        }

    }
}