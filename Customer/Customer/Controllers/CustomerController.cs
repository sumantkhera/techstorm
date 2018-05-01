namespace Customer.Controllers
{
    using Customer.BusinessEntities.Customer;
    using Customer.BusinessLayer.Interface.Customer;
    using Customer.Filters;
    using Customer.Logging;
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Web;
    using System.Web.Http;

    /// <summary>
    /// This class is used to reponse customer list, add and update.
    /// </summary>
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
            _lLogger.Start(LogLevel.INFO, null, () => "GetCustomerList");
            var result = this._customerBL.GetCustomerList(customerfilter);
            _lLogger.End();
            return Ok(result);
        }

        /// <summary>
        /// Get customer Information
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost, Route("GetCustomerListCount")]
        public IHttpActionResult GetCustomerListCount(CustomerSearchViewModel customerfilter)
        {
            _lLogger.Start(LogLevel.INFO, null, () => "GetCustomerList");
            var result = this._customerBL.GetCustomerList(customerfilter);
            _lLogger.End();
            return Ok(result);
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
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            var httpRequest = HttpContext.Current.Request;

            if (httpRequest.Files != null && httpRequest.Files.Count > 0)
            {
                var postedFile = httpRequest.Files[0];
                if (postedFile != null && postedFile.ContentLength > 0)
                {
                    using (var binaryReader = new BinaryReader(postedFile.InputStream))
                    {
                        customer.Image = binaryReader.ReadBytes(postedFile.ContentLength);
                    }
                }
            }
            var result = this._customerBL.AddCustomer(customer, UserId);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        /// <summary>
        /// Update customer Information
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost, Route("UpdateCustomer")]
        public HttpResponseMessage UpdateCustomer(CustomerDetailViewModel customer)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            var httpRequest = HttpContext.Current.Request;

            if (httpRequest.Files != null && httpRequest.Files.Count > 0)
            {
                var postedFile = httpRequest.Files[0];
                if (postedFile != null && postedFile.ContentLength > 0)
                {
                    using (var binaryReader = new BinaryReader(postedFile.InputStream))
                    {
                        customer.Image = binaryReader.ReadBytes(postedFile.ContentLength);
                    }
                }
            }
            var result = this._customerBL.UpdateCustomer(customer, UserId);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        /// <summary>
        /// Get Customer Image.
        /// </summary>
        /// <param name="customerId">CustomerId</param>
        /// <returns>Image Byte</returns>
        public HttpResponseMessage GetCustomImage(int customerId)
        {
            byte[] imgData = this._customerBL.GetCustomerImage(customerId); ;
            MemoryStream ms = new MemoryStream(imgData);
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new StreamContent(ms);
            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/png");
            return response;
        }
        #endregion
    }
}