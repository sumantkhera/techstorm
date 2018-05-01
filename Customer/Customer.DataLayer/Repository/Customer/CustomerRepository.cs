using Customer.DataLayer.IRepository.Customer;
using Customer.Entities;
using Customer.Logging;
using Customer.ViewModel.Common;
using Customer.ViewModel.Customer;
using Database.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DataModel = Customer.Entities;

namespace Customer.DataLayer.Repository.Customer
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
                int skip = customerSearchViewModel.PageSize * (customerSearchViewModel.PageNumber - 1);
                IQueryable<CustomerListViewModel> resultQuery = GetCustomerQuery(customerSearchViewModel);
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


        /// <summary>
        /// Get customer total count.
        /// </summary>
        /// <param name="customerSearchViewModel">Filter object.</param>
        /// <returns>Return total count.</returns>
        public int GetCustomerListCount(CustomerSearchViewModel customerSearchViewModel)
        {
            try
            {
                _lLogger.Start(LogLevel.INFO, null, () => "GetCustomerListCount DL");
                IQueryable<CustomerListViewModel> resultQuery = GetCustomerQuery(customerSearchViewModel);
                var result = resultQuery.Count();
                _lLogger.End();
                return result;
            }
            catch (Exception ex)
            {
                _lLogger.Log(typeof(string), LogLevel.ERROR, "GetCustomerListCount", ex);
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
                var result = CreateSuccessStatus(newCustomer.Id);
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
        public AddUpdateResultViewModel UpdateCustomer(DataModel.Customer customer, byte[] image, int userId)
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

                    if (image != null)
                    {
                        databaseContext.CustomerImages.Where(w => w.CustomerId == newCustomer.Id && w.IsDeleted == false).ToList().ForEach(p => p.IsDeleted = true);
                        var customerImages = new CustomerImage();
                        customerImages.Image = image;
                        customerImages.CustomerId = customerResult.CustomerId.Value;
                        databaseContext.CustomerImages.Add(customerImages);
                    }
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

        #region PrivateMethod
        private IQueryable<CustomerListViewModel> GetCustomerQuery(CustomerSearchViewModel customerSearchViewModel)
        {
            IQueryable<CustomerListViewModel> resultQuery = null;

            DateTime runDateEnd = customerSearchViewModel.DateAddedTo != null ? Convert.ToDateTime(customerSearchViewModel.DateAddedTo).AddMinutes(1439).AddSeconds(59) : DateTime.Now;

            //Get the basic data
            resultQuery = (from customer in _databaseContext.CustomerDetails
                           join user in _databaseContext.Users on customer.CreatedBy equals user.UserId
                           join userm in _databaseContext.Users on customer.ModifyBy equals userm.UserId
                           where !customer.IsDeleted && !customer.Customer.IsDeleted
                           select new CustomerListViewModel
                           {
                               Id = customer.Customer.Id,
                               BusinessName = customer.BusinessName,
                               ClassificationId = customer.ClassificationId,
                               ClientTypeId = customer.ClientTypeId,
                               Salutation = customer.Salutation,
                               PrimaryContact = customer.PrimaryContact,
                               Phone = customer.Phone,
                               PrimaryAddress1 = customer.PrimaryAddress1,
                               PrimaryAddress2 = customer.PrimaryAddress2,
                               PrimaryAddress3 = customer.PrimaryAddress3,
                               PrimaryCity = customer.PrimaryCity,
                               PrimaryCounty = customer.PrimaryCounty,
                               PrimaryEicode = customer.PrimaryEicode,
                               IsSecondaryAddressSame = customer.IsSecondaryAddressSame,
                               SecondaryAddress1 = customer.SecondaryAddress1,
                               SecondaryAddress2 = customer.SecondaryAddress2,
                               SecondaryAddress3 = customer.SecondaryAddress3,
                               SecondaryCity = customer.SecondaryCity,
                               SecondaryCounty = customer.SecondaryCounty,
                               SecondaryEicode = customer.SecondaryEicode,
                               ModifyOn = customer.ModifyOn,
                               CreatedOn = customer.Customer.CreatedOn.Value,
                               ModifyBy = userm.UserName,
                               CreatedBy = user.UserName,
                           }).AsQueryable();

            //Apply filter criteria
            if (!string.IsNullOrEmpty(customerSearchViewModel.CustomerName))
            {
                resultQuery = resultQuery.Where(w => w.BusinessName.Contains(customerSearchViewModel.CustomerName));
            }

            if (!string.IsNullOrEmpty(customerSearchViewModel.City))
            {
                resultQuery = resultQuery.Where(w => w.PrimaryCity.Contains(customerSearchViewModel.City) || w.SecondaryCity.Contains(customerSearchViewModel.City));
            }

            if (!string.IsNullOrEmpty(customerSearchViewModel.County))
            {
                resultQuery = resultQuery.Where(w => w.PrimaryCity.Contains(customerSearchViewModel.County) || w.SecondaryCity.Contains(customerSearchViewModel.County));
            }

            if (!string.IsNullOrEmpty(customerSearchViewModel.EirCode))
            {
                resultQuery = resultQuery.Where(w => w.PrimaryEicode.Contains(customerSearchViewModel.EirCode) || w.SecondaryEicode.Contains(customerSearchViewModel.EirCode));
            }

            if (!string.IsNullOrEmpty(customerSearchViewModel.Phone))
            {
                resultQuery = resultQuery.Where(w => w.Phone == customerSearchViewModel.Phone);
            }

            if (customerSearchViewModel.DateAddedFrom != null)
            {
                resultQuery = resultQuery.Where(w => w.CreatedOn >= customerSearchViewModel.DateAddedFrom);
            }

            if (customerSearchViewModel.DateAddedTo != null)
            {
                resultQuery = resultQuery.Where(w => w.CreatedOn <= runDateEnd);
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
            return resultQuery;
        }

        /// <summary>
        /// Get Customer Image.
        /// </summary>
        /// <param name="customerId">CustomerId</param>
        /// <returns>Image Byte</returns>
        public byte[] GetCustomerImage(int customerId)
        {
            var imageByte = _databaseContext.CustomerImages.Where(p => p.CustomerId == customerId && p.IsDeleted == false).FirstOrDefault();
            if (imageByte != null)
                return imageByte.Image;
            return null;

        }
        #endregion

    }
}