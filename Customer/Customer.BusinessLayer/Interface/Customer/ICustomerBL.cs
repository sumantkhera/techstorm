using Customer.BusinessEntities.Common;
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
        AddUpdateResultViewModel AddCustomer(CustomerDetailViewModel customer, int userId);

        /// <summary>
        /// Update customer Information
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        AddUpdateResultViewModel UpdateCustomer(CustomerDetailViewModel customer, int userId);
    }
}
