using Customer.BusinessEntities.Common;
using Customer.BusinessEntities.Customer;
using System.Collections.Generic;

namespace Customer.BusinessLayer.Interface.Customer
{
    /// <summary>
    /// This interface contain the declaration method of customer class
    /// </summary>
    public interface ICustomerBL
    {
        /// <summary>
        /// Get customer Information
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>List of customer detail.</returns>
        IEnumerable<CustomerListViewModel> GetCustomerList(CustomerSearchViewModel customerFilter);

        int GetCustomerListCount(CustomerSearchViewModel customerFilter);

        

        /// <summary>
        /// Save customer Information
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>Return json of status and message</returns>
        AddUpdateResultViewModel AddCustomer(CustomerDetailViewModel customer, int userId);

        /// <summary>
        /// Update customer Information
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>Return json of status and message</returns>
        AddUpdateResultViewModel UpdateCustomer(CustomerDetailViewModel customer, int userId);
        
        /// <summary>
        /// Get Customer Image.
        /// </summary>
        /// <param name="customerId">CustomerId</param>
        /// <returns>Image Byte</returns>
        byte[] GetCustomerImage(int customerId);
    }
}
