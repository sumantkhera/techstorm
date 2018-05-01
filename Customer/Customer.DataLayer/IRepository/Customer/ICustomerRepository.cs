using Customer.ViewModel.Common;
using Customer.ViewModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel = Customer.Entities;

namespace Customer.DataLayer.IRepository.Customer
{
    /// <summary>
    /// This interface contain the declaration method of customer class
    /// </summary>
    public interface ICustomerRepository
    {
        /// <summary>
        /// Get customer Information
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        IEnumerable<CustomerListViewModel> GetCustomerList(CustomerSearchViewModel customerSearchViewModel);

        int GetCustomerListCount(CustomerSearchViewModel customerSearchViewModel);

        /// <summary>
        /// Save customer Information
        /// </summary>
        /// <param name="customer">Customer detail</param>
        /// <returns>Return Object of status and message</returns>
        AddUpdateResultViewModel Add(DataModel.Customer customer, int userId);

        /// <summary>
        /// Update customer Information
        /// </summary>
        /// <param name="customer">Customer detail</param>
        /// <returns>Return Object of status and message</returns>
        AddUpdateResultViewModel UpdateCustomer(DataModel.Customer customer, byte[] image, int userId);
        
        /// <summary>
        /// Get Customer Image.
        /// </summary>
        /// <param name="customerId">CustomerId</param>
        /// <returns>Image Byte</returns>
        byte[] GetCustomerImage(int customerId);
    }
}
