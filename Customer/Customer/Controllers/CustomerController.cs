namespace Customer.Controllers
{
    using Customer.BusinessEntities.Customer;
    using Customer.BusinessLayer.Interface.Customer;
    using Customer.Filters;
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Web;
    using System.Web.Http;

    [RoutePrefix("api/customer")]
    //[CustomAuthorizeAttribute]
    public class CustomerController : BaseController
    {
        #region Constructor

        private readonly ICustomerBL _customerBL;
        public CustomerController(ICustomerBL customerBL)
        {
            this._customerBL = customerBL;
        }

        #endregion

        #region Get
        /// <summary>
        /// Get customer Information
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>

        [HttpPost, Route("GetCustomerList")]
        public IHttpActionResult GetCustomerList(CustomerSearchViewModel customerfilter)
        {
            try
            {
                var result = this._customerBL.GetCustomerList(customerfilter);
                return Ok(result);
            }
            catch (Exception ex)
            {
                //If any exception occurs Internal Server Error i.e. Status Code 500 will be returned  
                return InternalServerError();
            }
        }

        #endregion

        #region Post
        /// <summary>
        /// Save customer Information
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost, Route("AddCustomer")]
        public HttpResponseMessage AddCustomer(CustomerDetailViewModel customer)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                var result = this._customerBL.AddCustomer(customer, UserId);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        #endregion

        #region Put
        /// <summary>
        /// Update customer Information
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost, Route("UpdateCustomer")]
        public HttpResponseMessage UpdateCustomer(CustomerDetailViewModel customer)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                var result = this._customerBL.UpdateCustomer(customer, UserId);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        #endregion

    }
}