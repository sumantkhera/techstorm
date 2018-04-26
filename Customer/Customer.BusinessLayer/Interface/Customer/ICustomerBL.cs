using Customer.BusinessEntities.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.BusinessLayer.Interface.Customer
{
    public interface ICustomerBL
    {
		/// <summary>
		/// Get customer Information
		/// </summary>
		/// <param name="customer"></param>
		/// <returns></returns>
		IEnumerable<CustomerListViewModel> GetCustomerList(CustomerSearchViewModel customerfilter);

        /// <summary>
        /// Save customer Information
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        object AddCustomer(CustomerDetailViewModel customer);

		/// <summary>
		/// Update customer Information
		/// </summary>
		/// <param name="customer"></param>
		/// <returns></returns>
		object UpdateCustomer(CustomerDetailViewModel customer);
    }
}
