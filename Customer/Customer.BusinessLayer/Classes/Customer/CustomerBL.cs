using Customer.BusinessLayer.Interface.Customer;
using Customer.DataLayer.Interface.Customer;
using System.Collections.Generic;
using Customer.BusinessEntities.Customer;
using Customer.BusinessLayer.Mapping;
using Customer.BusinessEntities.Common;
using Database.Models;
using Customer.Logging;

namespace Customer.BusinessLayer.Classes.Customer
{
    /// <summary>
    /// This class contain the declaration method of customer class
    /// </summary>
    public class CustomerBL : ICustomerBL
    {
        #region Constructor
        private ICustomerRepository _customerService;
        private readonly ILogger _lLogger;
        public CustomerBL(ICustomerRepository customerService)
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
            var result  =  _customerService.GetCustomerList(customerSearchViewModel);
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
            var customer = AutoMapperHelper<CustomerDetailViewModel, Database.Models.Customer>.Map(customerDetailView);
            var customerDetail = AutoMapperHelper<CustomerDetailViewModel, Database.Models.CustomerDetail>.Map(customerDetailView);
            customer.CustomDetail = new List<CustomerDetail>();
            customer.CustomDetail.Add(customerDetail);
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
            var customer = AutoMapperHelper<CustomerDetailViewModel, Database.Models.Customer>.Map(customerDetailView);
            var customerDetail = AutoMapperHelper<CustomerDetailViewModel, Database.Models.CustomerDetail>.Map(customerDetailView);
            customer.CustomDetail = new List<CustomerDetail>();
            customer.CustomDetail.Add(customerDetail);
            var result= _customerService.UpdateCustomer(customer, userId);
            _lLogger.End();
            return result;
        }
        #endregion
    }
}
