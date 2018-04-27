using Customer.DataLayer.Interface.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer.BusinessEntities.Customer;
using Database.Context;
using DataModel = Database.Models;
using Customer.BusinessEntities.Common;

namespace Customer.DataLayer.Classes.Customer
{
    public class CustomerRepository : BaseRepository, ICustomerRepository
    {
        #region GET
        /// <summary>
        /// Get customer Information
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public IEnumerable<CustomerListViewModel> GetCustomerList(CustomerSearchViewModel customerSearchViewModel)
        {
            using (var databaseContext = new DatabaseContext())
            {
                var result = from customer in databaseContext.Customers
                             join cd in databaseContext.CustomerDetails
on customer.Id equals cd.Id
                             select (new CustomerListViewModel
                             {
                                 //BusinessName = customer.BusinessName,
                                 Id = customer.Id,
                                 Phone = cd.Phone,
                                 Email = cd.Email,
                                 Eicode = cd.Eicode,
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
        public AddUpdateResultViewModel Add(DataModel.Customer customer, int userId)
        {
            try
            {
                DataModel.Customer newCustomer = new DataModel.Customer();
                newCustomer = customer;

                using (var databaseContext = new DatabaseContext())
                {
                    databaseContext.Customers.Add(newCustomer);
                    databaseContext.SaveChanges(userId);
                }
                return CreateSuccessStatus(newCustomer.Id);
            }
            catch (Exception ex)
            {
                //log the exception
                throw;
            }
        }


        #endregion

        #region UPDATE
        /// <summary>
        /// Update customer Information
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public AddUpdateResultViewModel UpdateCustomer(DataModel.Customer customer, int userId)
        {
            try
            {
                DataModel.Customer newCustomer = new DataModel.Customer();
                newCustomer = customer;

                using (var databaseContext = new DatabaseContext())
                {
                    var customerResult = databaseContext.CustomerDetails.Where(w => w.Id == newCustomer.Id && w.IsDeleted == false).FirstOrDefault();

                    if (customerResult == null)
                        return CreateFailureNotFoundStatus();
                    customerResult.IsDeleted = true;
                    customer.CustomDetail.ToList().ForEach(p =>
                    {
                        p.Version = customerResult.Version;
                        p.CustomerId = customerResult.CustomerId;
                    });
                    databaseContext.CustomerDetails.AddRange(customer.CustomDetail);
                    databaseContext.SaveChanges(userId);
                    return CreateSuccessStatus(newCustomer.Id);
                }
            }
            catch (Exception ex)
            {
                //log the exception
                throw;
            }
        }
        #endregion

    }
}
