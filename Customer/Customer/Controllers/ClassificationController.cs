using Customer.BusinessLayer.Interface.Classification;
using Customer.Filters;
using Customer.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Customer.Controllers
{
    //[CustomAuthorizeAttribute]
    public class ClassificationController : BaseController
    {
        #region Constructor

        private readonly IClassificationBL _classificationBL;
        public ClassificationController(IClassificationBL classificationBL)
        {
            this._classificationBL = classificationBL;
        }

        #endregion


        #region Get

        [HttpGet]
        public IHttpActionResult GetClassificationList()
        {
            try
            {
                //_lLogger.Start(LogLevel.INFO, null, () => "GetClassificationList");
                var result = this._classificationBL.GetClassificationList();
                //_lLogger.End();
                return Ok(result);
            }
            catch (Exception ex)
            {
                //If any exception occurs Internal Server Error i.e. Status Code 500 will be returned  
                return InternalServerError();
            }
        }

        #endregion

    }
}
