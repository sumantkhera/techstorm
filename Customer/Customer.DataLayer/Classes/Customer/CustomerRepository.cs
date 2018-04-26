using Customer.DataLayer.Interface.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer.BusinessEntities.Customer;
using Database.Context;
using DataModel = Database.Models;

namespace Customer.DataLayer.Classes.Customer
{
    public class CustomerRepository : ICustomerRepository
    {
        #region GET
        public IEnumerable<CustomerListViewModel> GetCustomerList(CustomerSearchViewModel customerSearchViewModel)
        {
            using (var databaseContext = new DatabaseContext())
            {
                var result = from customer in databaseContext.Customers
                             select (new CustomerListViewModel
                             {
                                 BusinessName = customer.BusinessName,
                                 Id = customer.Id,
                             });
                return result.ToList();
            }
        }
        #endregion


        #region SAVE
        /// <summary>
        /// Save customer Information
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public DataModel.Customer Add(DataModel.Customer customer)
        {
            try
            {
                DataModel.Customer newCustomer = new DataModel.Customer();
                newCustomer = customer;

                using (var databaseContext = new DatabaseContext())
                {
                    databaseContext.Customers.Add(newCustomer);
                    databaseContext.SaveChanges();
                }
                return newCustomer;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        #endregion

        #region UPDATE

        #endregion

    }
}
