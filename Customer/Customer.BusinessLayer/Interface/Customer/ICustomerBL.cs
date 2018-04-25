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
        IEnumerable<CustomerListViewModel> GetCustomerList();
    }
}
