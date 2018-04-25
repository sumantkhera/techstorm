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

namespace Customer.BusinessLayer.Classes.Customer
{
    public class CustomerBL : ICustomerBL
    {
        private ICustomerRepository _customerService;
        public CustomerBL(ICustomerRepository customerService)
        {
            this._customerService = customerService;
        }

        public IEnumerable<CustomerListViewModel> GetCustomerList(CustomerSearchViewModel customerSearchViewModel)
        {
            return _customerService.GetCustomerList(customerSearchViewModel);
        }

        public object AddCustomer(CustomerDetailViewModel customer)
        {
            var obje = AutoMapperHelper<CustomerDetailViewModel, Database.Models.Customer>.Map(customer);
            return 1;
            //throw new Exception("Duplicate Record.");
        }

        public object UpdateCustomer(CustomerDetailViewModel customer)
        {
            return 1;
        }
    }
}
