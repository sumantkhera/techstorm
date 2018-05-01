using System.Collections.Generic;
using Customer.Entities;
using DataModel =Customer.Entities;
using Customer.Logging;
using Customer.DataLayer.IRepository.Customer;
using Customer.BusinessLayer.IService.Customer;
using Customer.ViewModel.Customer;
using Customer.ViewModel.Common;
using Customer.BusinessLayer.Mapping;

namespace Customer.BusinessLayer.Service.Customer
{
    /// <summary>
    /// This class contain the declaration method of customer class
    /// </summary>
    public class CustomerService : ICustomerService
    {
        #region Constructor
        private ICustomerRepository _customerService;
        private readonly ILogger _lLogger;
        public CustomerService(ICustomerRepository customerService)
        {
            _lLogger = Log4NetLogger.Instance;
            this._customerService = customerService;
        }
        #endregion

        #region Public method

        /// <summary>
        /// Get customer Information
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>List of Customer detail</returns>
        public IEnumerable<CustomerListViewModel> GetCustomerList(CustomerSearchViewModel customerSearchViewModel)
        {
            _lLogger.Start(LogLevel.INFO, null, () => "GetCustomerList BL");
            var result = _customerService.GetCustomerList(customerSearchViewModel);
            _lLogger.End();
            return result;
        }

        public int GetCustomerListCount(CustomerSearchViewModel customerFilter)
        {
            _lLogger.Start(LogLevel.INFO, null, () => "GetCustomerList BL");
            var result = _customerService.GetCustomerListCount(customerFilter);
            _lLogger.End();
            return result;
        }

        /// <summary>
        /// Save customer Information
        /// </summary>
        /// <param name="customer">Customer detail</param>
        /// <returns>Return Object of status and message</returns>
        public AddUpdateResultViewModel AddCustomer(CustomerDetailViewModel customerDetailView, int userId)
        {
            _lLogger.Start(LogLevel.INFO, null, () => "AddCustomer BL");
            var customer = AutoMapperHelper<CustomerDetailViewModel, DataModel.Customer>.Map(customerDetailView);
            var customerDetail = AutoMapperHelper<CustomerDetailViewModel, CustomerDetail>.Map(customerDetailView);
            customer.CustomDetail = new List<CustomerDetail>();
            customer.CustomDetail.Add(customerDetail);
            if (customerDetailView.Image != null)
            {
                var customerImage = AutoMapperHelper<CustomerDetailViewModel, CustomerImage>.Map(customerDetailView);
                customer.CustomImage = new List<CustomerImage>();
                customer.CustomImage.Add(customerImage);
            }
            var result = _customerService.Add(customer, userId);
            _lLogger.End();
            return result;
        }
        /// <summary>
        /// Update customer Information
        /// </summary>
        /// <param name="customer">Customer detail.</param>
        /// <returns>Return Object of status and message</returns>
        public AddUpdateResultViewModel UpdateCustomer(CustomerDetailViewModel customerDetailView, int userId)
        {
            _lLogger.Start(LogLevel.INFO, null, () => "UpdateCustomer BL");
            var customer = AutoMapperHelper<CustomerDetailViewModel, DataModel.Customer>.Map(customerDetailView);
            var customerDetail = AutoMapperHelper<CustomerDetailViewModel, DataModel.CustomerDetail>.Map(customerDetailView);
            customer.CustomDetail = new List<CustomerDetail>();
            customer.CustomDetail.Add(customerDetail);
            var result = _customerService.UpdateCustomer(customer, customerDetailView.Image, userId);
            _lLogger.End();
            return result;
        }

        /// <summary>
        /// Get Customer Image.
        /// </summary>
        /// <param name="customerId">CustomerId</param>
        /// <returns>Image Byte</returns>
        public byte[] GetCustomerImage(int customerId)
        {
            _lLogger.Start(LogLevel.INFO, null, () => "GetCustomerImage BL");
            var result = _customerService.GetCustomerImage(customerId);
            _lLogger.End();
            return result;
        }


        #endregion
    }
}
