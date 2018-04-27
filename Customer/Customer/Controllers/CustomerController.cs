namespace Customer.Controllers
{
	using Customer.BusinessEntities.Customer;
	using Customer.BusinessLayer.Interface.Customer;
	using Customer.Filters;
	using System;
	using System.Web;
	using System.Web.Http;
	using Customer.Logging;

	[RoutePrefix("api/customer")]
	//[CustomAuthorizeAttribute]
	public class CustomerController : BaseController
	{
		#region Constructor

		private readonly ICustomerBL _customerBL;
		public CustomerController(ICustomerBL customerBL)
		{
			try
			{
				this._customerBL = customerBL;
			}
			catch (Exception ex)
			{
				Logger.Error(ex);
				throw;
			}
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
				HttpContext.Current.Response.AppendHeader("Allow", "POST,OPTIONS");
				var result = this._customerBL.GetCustomerList(customerfilter);
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

		#region Post
		/// <summary>
		/// Save customer Information
		/// </summary>
		/// <param name="customer"></param>
		/// <returns></returns>
		[HttpPost, Route("AddCustomer")]
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
				//return InternalServerError();
				Logger.Error(ex);
				throw;
			}
		}

		#endregion

		#region Put
		/// <summary>
		/// Update customer Information
		/// </summary>
		/// <param name="customer"></param>
		/// <returns></returns>
		[HttpPut, Route("UpdateCustomer")]
		public IHttpActionResult UpdateCustomer(CustomerDetailViewModel customer)
		{
			try
			{
				var result = this._customerBL.UpdateCustomer(customer);
				return Ok(result);
			}
			catch (Exception ex)
			{
				Logger.Error(ex);
				throw;
			}
		}

		#endregion

	}
}