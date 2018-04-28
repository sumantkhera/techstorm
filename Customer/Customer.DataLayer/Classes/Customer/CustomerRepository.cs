using Customer.BusinessEntities.Common;
using Customer.BusinessEntities.Customer;
using Customer.DataLayer.Interface.Customer;
using Customer.Logging;
using Database.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DataModel = Database.Models;

namespace Customer.DataLayer.Classes.Customer
{
    /// <summary>
    /// This class contain the declaration method of customer class
    /// </summary>
    public class CustomerRepository : BaseRepository, ICustomerRepository
    {
        #region Constructor
        private readonly ILogger _lLogger;

        public CustomerRepository()
        {
            _lLogger = Log4NetLogger.Instance;
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
            try
            {
                _lLogger.Start(LogLevel.INFO, null, () => "GetCustomerList DL");
                //paging parameter
                var skip = customerSearchViewModel.PageSize * (customerSearchViewModel.PageNumber - 1);

                //Get the basic data
                var resultQuery = from customer in _databaseContext.CustomerDetails
                                  join user in _databaseContext.Users on customer.CreatedBy equals user.UserId
                                  join userm in _databaseContext.Users on customer.ModifyBy equals userm.UserId
                                  where !customer.IsDeleted && !customer.Customer.IsDeleted
                                  select new CustomerListViewModel
                                  {
                                      Id = customer.Customer.Id,
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
                                      CreatedBy = user.UserName,
                                      PrimaryContact = customer.PrimaryContact,
                                      ClassificationId = customer.ClassificationId,
                                      ClientTypeId = customer.ClientTypeId,
                                      SecondaryAddress1 = customer.SecondaryAddress1,
                                      SecondaryAddress2 = customer.SecondaryAddress2,
                                      SecondaryCity = customer.SecondaryCity,
                                      SecondaryState = customer.SecondaryState,
                                      SecondaryZipcode = customer.SecondaryZipcode,
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
                var result = resultQuery.Skip(skip).Take(customerSearchViewModel.PageSize).ToList();
                _lLogger.End();
                //Apply Paging return result
                return result;
            }
            catch (Exception ex)
            {
                _lLogger.Log(typeof(string), LogLevel.ERROR, "GetCustomerList", ex);
                throw;
            }
        }
        #endregion


        #region SAVE
        /// <summary>
        /// Save customer Information
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>Return Object of status and message</returns>
        public AddUpdateResultViewModel Add(DataModel.Customer customer, int userId)
        {
            try
            {
                _lLogger.Start(LogLevel.INFO, null, () => "AddCustomer DL");
                DataModel.Customer newCustomer = new DataModel.Customer();
                newCustomer = customer;

                using (var databaseContext = new DatabaseContext())
                {
                    databaseContext.Customers.Add(newCustomer);
                    databaseContext.SaveChanges(userId);
                }
                var result= CreateSuccessStatus(newCustomer.Id);
                _lLogger.End();
                return result;
            }
            catch (Exception ex)
            {
                _lLogger.Log(typeof(string), LogLevel.ERROR, "Add Customer", ex);
                throw;
            }
        }


        #endregion

        #region UPDATE
        /// <summary>
        /// Update customer Information
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>Return Object of status and message</returns>
        public AddUpdateResultViewModel UpdateCustomer(DataModel.Customer customer, int userId)
        {
            try
            {
                _lLogger.Start(LogLevel.INFO, null, () => "UpdateCustomer DL");
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
                    var result = CreateSuccessStatus(newCustomer.Id);
                    _lLogger.End();
                    return result;
                }
            }
            catch (Exception ex)
            {
                _lLogger.Log(typeof(string), LogLevel.ERROR, "Add Customer", ex);
                throw;
            }
        }
        #endregion

    }
}
