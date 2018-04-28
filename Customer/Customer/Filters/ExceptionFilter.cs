using Customer.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace Customer.Filters
{
    /// <summary>
    /// Exception filter is used to handle the exception which is raised on controller.
    /// </summary>
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        public ILogger _lLogger = Log4NetLogger.Instance;

        /// <summary>
        /// OnException: Handle the excption and log exception.
        /// </summary>
        /// <param name="context">Return a internal server responce message</param>
        public override void OnException(HttpActionExecutedContext context)
        {
            string parameters = Newtonsoft.Json.JsonConvert.SerializeObject(context.ActionContext.ActionArguments);
            string message = "Class=" + context.ActionContext.ControllerContext.Controller.ToString() + ", Method=" + context.ActionContext.ActionDescriptor.ActionName + ", Data= " + parameters;

            _lLogger.Log(context.ActionContext.ControllerContext.Controller.GetType(), LogLevel.ERROR, message, context.Exception);
            context.Response = context.Request.CreateResponse(HttpStatusCode.BadRequest, new { code = "", Message = "Please try later or contact admin." });
        }
    }
}