using Customer.DataLayer.Interface.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer.BusinessEntities.Customer;
using Database.Context;
using DataModel = Database.Models;
using System.Data.Entity;
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
                //paging parameter
                var skip = customerSearchViewModel.PageSize * (customerSearchViewModel.PageNumber - 1);

                //Get the basic data
                var resultQuery = databaseContext.CustomerDetails.Where(w => !w.IsDeleted && !w.Customer.IsDeleted)
                    .Select(s => new CustomerListViewModel
                    {
                        BusinessName = s.BusinessName,
                        Eicode = s.Eicode,
                        Email = s.Email,
                        Phone = s.Phone,
                        PrimaryAddress1 = s.PrimaryAddress1,
                        PrimaryAddress2 = s.PrimaryAddress2,
                        PrimaryCity = s.PrimaryCity,
                        PrimaryState = s.PrimaryState,
                        PrimaryZipcode = s.PrimaryZipcode,
                        ModifyOn = s.ModifyOn

                    });

                //Apply filter criteria
                if (!string.IsNullOrEmpty(customerSearchViewModel.CustomerName))
                {
                    resultQuery = resultQuery.Where(w => w.BusinessName == customerSearchViewModel.CustomerName);
                }

                if (!string.IsNullOrEmpty(customerSearchViewModel.Email))
                {
                    resultQuery = resultQuery.Where(w => w.Email == customerSearchViewModel.Email);
                }

                if (!string.IsNullOrEmpty(customerSearchViewModel.Phone))
                {
                    resultQuery = resultQuery.Where(w => w.Phone == customerSearchViewModel.Phone);
                }

                if (customerSearchViewModel.DateAddedFrom != null)
                {
                    resultQuery = resultQuery.Where(w => w.ModifyOn >= customerSearchViewModel.DateAddedFrom);
                }

                if (customerSearchViewModel.DateAddedFrom != null)
                {
                    resultQuery = resultQuery.Where(w => w.ModifyOn >= customerSearchViewModel.DateAddedFrom);
                }

                if (customerSearchViewModel.DateAddedTo != null)
                {
                    resultQuery = resultQuery.Where(w => w.ModifyOn <= customerSearchViewModel.DateAddedTo);
                }

                //Apply Sorting
                if (customerSearchViewModel.SortOrder == "desc")
                {
                    switch (customerSearchViewModel.SortColumn)
                    {
                        case "name":
                            resultQuery = resultQuery.OrderByDescending(o => o.BusinessName);
                            break;

                        case "date":
                            resultQuery = resultQuery.OrderByDescending(o => o.ModifyOn);
                            break;
                    }
                }
                else
                    switch (customerSearchViewModel.SortColumn)
                    {
                        case "name":
                            resultQuery = resultQuery.OrderBy(o => o.BusinessName);
                            break;

                        case "date":
                            resultQuery = resultQuery.OrderBy(o => o.ModifyOn);
                            break;
                    }

                //Apply Paging return result
                return resultQuery.Skip(skip).Take(customerSearchViewModel.PageSize).ToList();
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
