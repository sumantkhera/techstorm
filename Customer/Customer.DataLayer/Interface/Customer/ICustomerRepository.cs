using Customer.BusinessEntities.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel = Database.Models;

namespace Customer.DataLayer.Interface.Customer
{
    public interface ICustomerRepository
    {
        IEnumerable<CustomerListViewModel> GetCustomerList(CustomerSearchViewModel customerSearchViewModel);

        /// <summary>
        /// Save customer Information
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        DataModel.Customer Add(DataModel.Customer customer);
    }
}
