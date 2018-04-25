using Customer.BusinessLayer.Interface.Customer;
using Customer.DataLayer.Interface.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer.BusinessEntities.Customer;

namespace Customer.BusinessLayer.Classes.Customer
{
    public class CustomerBL : ICustomerBL
    {
        private ICustomerRepository _customerService;
        public CustomerBL(ICustomerRepository customerService)
        {
            this._customerService = customerService;
        }

        public IEnumerable<CustomerListViewModel> GetCustomerList()
        {
            return _customerService.GetCustomerList();
        }
    }
}
