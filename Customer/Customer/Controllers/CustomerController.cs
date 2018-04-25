using Customer.BusinessLayer.Interface.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Customer.Controllers
{
    public class CustomerController : ApiController
    {
        private ICustomerBL _customerBL;
        public CustomerController(ICustomerBL customerBL)
        {
            this._customerBL = customerBL;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                var result = this._customerBL.GetCustomerList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                //If any exception occurs Internal Server Error i.e. Status Code 500 will be returned  
                return InternalServerError();
            }
        }

    }
}