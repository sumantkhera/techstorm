using Customer.BusinessLayer.Interface.Classification;
using Customer.BusinessLayer.Interface.ClientType;
using Customer.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Customer.Logging;

namespace Customer.Controllers
{
    //[CustomAuthorizeAttribute]
    public class ClientTypeController : BaseController
    {
        #region Constructor

        private readonly IClientTypeBL _clientTypeBL;
        public ClientTypeController(IClientTypeBL clientTypeBL)
        {
			try
			{
				this._clientTypeBL = clientTypeBL;
			}
			catch (Exception ex)
			{
				Logger.Error(ex);
				throw;
			}
		}

        #endregion


        #region Get

        [HttpGet]
        public IHttpActionResult GetClientTypeList()
        {
            try
            {
				Logger.Info("customer execution;");
				var result = this._clientTypeBL.GetClientTypeList();
                return Ok(result);
            }
            catch (Exception ex)
            {
				//If any exception occurs Internal Server Error i.e. Status Code 500 will be returned  
				// return InternalServerError();
				Logger.Error(ex);
				throw;
			}
        }

        #endregion
    }
}
