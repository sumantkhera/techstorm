using Customer.BusinessLayer.Interface.Customer;
using Customer.DataLayer.Interface.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer.BusinessEntities.Customer;
using AutoMapper;
using Customer.BusinessEntities.ClientType;
using Customer.BusinessLayer.Mapping;
using Customer.BusinessEntities.Common;
using Database.Models;

namespace Customer.BusinessLayer.Classes.Customer
{
    public class CustomerBL : ICustomerBL
    {
        private ICustomerRepository _customerService;
        public CustomerBL(ICustomerRepository customerService)
        {
            this._customerService = customerService;
        }

        /// <summary>
        /// Get customer Information
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public IEnumerable<CustomerListViewModel> GetCustomerList(CustomerSearchViewModel customerSearchViewModel)
        {
            return _customerService.GetCustomerList(customerSearchViewModel);
        }

        /// <summary>
        /// Save customer Information
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public AddUpdateResultViewModel AddCustomer(CustomerDetailViewModel customerDetailView, int userId)
        {
            var customer = AutoMapperHelper<CustomerDetailViewModel, Database.Models.Customer>.Map(customerDetailView);
            var customerDetail = AutoMapperHelper<CustomerDetailViewModel, Database.Models.CustomerDetail>.Map(customerDetailView);
            customer.CustomDetail = new List<CustomerDetail>();
            customer.CustomDetail.Add(customerDetail);
            return _customerService.Add(customer, userId);
        }
        /// <summary>
        /// Update customer Information
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public AddUpdateResultViewModel UpdateCustomer(CustomerDetailViewModel customerDetailView, int userId)
        {
            var customer = AutoMapperHelper<CustomerDetailViewModel, Database.Models.Customer>.Map(customerDetailView);
            var customerDetail = AutoMapperHelper<CustomerDetailViewModel, Database.Models.CustomerDetail>.Map(customerDetailView);
            customer.CustomDetail = new List<CustomerDetail>();
            customer.CustomDetail.Add(customerDetail);
            return _customerService.UpdateCustomer(customer, userId);
        }

        #region PRIVATE

        #endregion
    }
}
