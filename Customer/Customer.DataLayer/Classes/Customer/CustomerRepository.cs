using Customer.DataLayer.Interface.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using Customer.BusinessEntities.Customer;
using Database.Context;
using DataModel = Database.Models;
using System.Data.Entity;
using Customer.BusinessEntities.Common;

namespace Customer.DataLayer.Classes.Customer
{
    public class CustomerRepository : BaseRepository, ICustomerRepository
    {
        DatabaseContext _databaseContext;

        #region CONSTRUCTOR
        public CustomerRepository()
        {
            _databaseContext = new DatabaseContext();
        }
        #endregion

        #region GET
        /// <summary>
        /// Get customer Information
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public IEnumerable<CustomerListViewModel> GetCustomerList(CustomerSearchViewModel customerSearchViewModel)
        {
            //using (var databaseContext = new DatabaseContext())
            //{

            //paging parameter
            var skip = customerSearchViewModel.PageSize * (customerSearchViewModel.PageNumber - 1);

            //Get the basic data
            var resultQuery = from customer in _databaseContext.CustomerDetails
                              join user in _databaseContext.Users on customer.CreatedBy equals user.UserId
                              join userm in _databaseContext.Users on customer.ModifyBy equals userm.UserId
                              select new CustomerListViewModel
                              {
                                  BusinessName = customer.BusinessName,
                                  Eicode = customer.Eicode,
                                  Email = customer.Email,
                                  Phone = customer.Phone,
                                  PrimaryAddress1 = customer.PrimaryAddress1,
                                  PrimaryAddress2 = customer.PrimaryAddress2,
                                  PrimaryCity = customer.PrimaryCity,
                                  PrimaryState = customer.PrimaryState,
                                  PrimaryZipcode = customer.PrimaryZipcode,
                                  ModifyOn = customer.ModifyOn,
                                  CreatedDate = customer.CreatedOn.Value,
                                  ModifyBy = userm.UserName,
                                  CreatedBy = user.UserName
                              };

            //Apply filter criteria
            if (!string.IsNullOrEmpty(customerSearchViewModel.CustomerName))
            {
                resultQuery = resultQuery.Where(w => customerSearchViewModel.CustomerName.Contains(w.BusinessName));
            }

            if (!string.IsNullOrEmpty(customerSearchViewModel.Email))
            {
                resultQuery = resultQuery.Where(w => customerSearchViewModel.Email.Contains(w.Email));
            }

            if (!string.IsNullOrEmpty(customerSearchViewModel.Phone))
            {
                resultQuery = resultQuery.Where(w => w.Phone == customerSearchViewModel.Phone);
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

                    default:
                        resultQuery = resultQuery.OrderByDescending(o => o.BusinessName);
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

                    default:
                        resultQuery = resultQuery.OrderBy(o => o.BusinessName);
                        break;
                }

            //Apply Paging return result
            return resultQuery.Skip(skip).Take(customerSearchViewModel.PageSize).ToList();
            //}
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
                    var customerResult = databaseContext.CustomerDetails.Where(w => w.CustomerId == newCustomer.Id && w.IsDeleted == false).FirstOrDefault();

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
