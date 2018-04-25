namespace Customer.Controllers
{
    using Customer.BusinessEntities.Customer;
    using Customer.BusinessLayer.Interface.Customer;
    using System;
    using System.Web.Http;

    [RoutePrefix("api/customer")]
    public class CustomerController : ApiController
    {
        #region Constructor

        private readonly ICustomerBL _customerBL;
        public CustomerController(ICustomerBL customerBL)
        {
            this._customerBL = customerBL;
        }

        #endregion

        #region Get

        [HttpGet]
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
        [HttpPost]
        public IHttpActionResult AddCustomer(CustomerDetailViewModel customer)
        {
            try
            {
                var result = this._customerBL.AddCustomer(customer);
                return Ok(result);
            }
            catch (Exception ex)
            {
                //If any exception occurs Internal Server Error i.e. Status Code 500 will be returned  
                return InternalServerError();
            }
        }

        #endregion

        #region Put
        [HttpPut]
        public IHttpActionResult UpdateCustomer(CustomerDetailViewModel customer)
        {
            try
            {
                var result = this._customerBL.UpdateCustomer(customer);
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