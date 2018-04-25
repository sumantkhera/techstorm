using Customer.DataLayer.Interface.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer.BusinessEntities.Customer;
using Database.Context;

namespace Customer.DataLayer.Classes.Customer
{
    public class CustomerRepository : ICustomerRepository
    {
        public IEnumerable<CustomerListViewModel> GetCustomerList()
        {
            DatabaseContext databaseContext = new DatabaseContext();
            var result = from customer in databaseContext.Customers
                         select (new CustomerListViewModel
                         {

                         });
            return result;
        }
    }
}
