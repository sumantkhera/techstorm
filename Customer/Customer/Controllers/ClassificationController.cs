using Customer.BusinessLayer.Interface.Classification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Customer.Controllers
{
    public class ClassificationController : ApiController
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
                var result = this._classificationBL.GetClassificationList();
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
