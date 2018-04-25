using Customer.BusinessLayer.Interface.Classification;
using Customer.BusinessLayer.Interface.ClientType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Customer.Controllers
{
    public class ClientTypeController : ApiController
    {
        #region Constructor

        private readonly IClientTypeBL _clientTypeBL;
        public ClientTypeController(IClientTypeBL clientTypeBL)
        {
            this._clientTypeBL = clientTypeBL;
        }

        #endregion


        #region Get

        [HttpGet]
        public IHttpActionResult GetClientTypeList()
        {
            try
            {
                var result = this._clientTypeBL.GetClientTypeList();
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
