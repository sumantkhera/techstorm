namespace Customer.Controllers
{
    using Customer.BusinessEntities.Customer;
    using Customer.BusinessLayer.Interface.Customer;
    using Customer.Filters;
    using Customer.Logging;
    using System.Web.Http;

    /// <summary>
    /// This class is used to reponse customer list, add and update.
    /// </summary>
    [RoutePrefix("api/customer")]
    [CustomAuthorizeAttribute]
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

        #endregion

        #region Post
        /// <summary>
        /// Save customer Information
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost, Route("AddCustomer")]
        public IHttpActionResult AddCustomer(CustomerDetailViewModel customer)
        {
            _lLogger.Start(LogLevel.INFO, null, () => "AddCustomer");
            var result = this._customerBL.AddCustomer(customer, UserId);
            _lLogger.End();
            return Ok(result);
        }

        /// <summary>
        /// Update customer Information
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost, Route("UpdateCustomer")]
        public IHttpActionResult UpdateCustomer(CustomerDetailViewModel customer)
        {
            _lLogger.Start(LogLevel.INFO, null, () => "UpdateCustomer");
            var result = this._customerBL.UpdateCustomer(customer, UserId);
            _lLogger.End();
            return Ok(result);
        }
        #endregion
    }
}