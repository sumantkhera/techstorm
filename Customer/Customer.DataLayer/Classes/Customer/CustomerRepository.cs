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

namespace Customer.DataLayer.Classes.Customer
{
	public class CustomerRepository : ICustomerRepository
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
		/// <summary>
		/// Update customer Information
		/// </summary>
		/// <param name="customer"></param>
		/// <returns></returns>
		public DataModel.Customer UpdateCustomer(DataModel.Customer customer)
		{
			try
			{
				DataModel.Customer newCustomer = new DataModel.Customer();
				newCustomer = customer;

				using (var databaseContext = new DatabaseContext())
				{
					var CustomerResult = databaseContext.Customers.Where(w => w.Id == newCustomer.Id && w.IsDeleted == false).FirstOrDefault();

					if (CustomerResult == null)
						return null;

					//CustomerResult.ClassificationId = newCustomer.ClassificationId;
					//CustomerResult.BusinessName = newCustomer.BusinessName;
					//CustomerResult.Salutation = newCustomer.Salutation;
					//CustomerResult.PrimaryContact = newCustomer.PrimaryContact;
					

					var saveResult = databaseContext.SaveChanges();

					var CustomerDetailResult = databaseContext.CustomerDetails.Where(w => w.Id == newCustomer.Id && w.IsDeleted == false).FirstOrDefault();
					//CustomerDetailResult.PrimaryAddress1 = newCustomer.CustomerDetails.PrimaryAddress1;
					//CustomerDetailResult.PrimaryAddress2 = newCustomer.CustomerDetails.PrimaryAddress2;
					//CustomerDetailResult.PrimaryCity = newCustomer.CustomerDetails.PrimaryCity;
					//CustomerDetailResult.PrimaryState = newCustomer.CustomerDetails.PrimaryState;
					//CustomerDetailResult.PrimaryZipcode = newCustomer.CustomerDetails.PrimaryZipcode;
					//CustomerDetailResult.SecondaryAddress1 = newCustomer.CustomerDetails.SecondaryAddress1;
					//CustomerDetailResult.SecondaryAddress2 = newCustomer.CustomerDetails.SecondaryAddress2;
					//CustomerDetailResult.SecondaryCity = newCustomer.CustomerDetails.SecondaryCity;
					//CustomerDetailResult.SecondaryState = newCustomer.CustomerDetails.SecondaryState;
					//CustomerDetailResult.SecondaryZipcode = newCustomer.CustomerDetails.SecondaryZipcode;
					//CustomerDetailResult.IsSecondaryAddressSame = newCustomer.CustomerDetails.IsSecondaryAddressSame;
					//CustomerDetailResult.Phone = newCustomer.CustomerDetails.Phone;
					//CustomerDetailResult.Email = newCustomer.CustomerDetails.Email;
					//CustomerDetailResult.Eicode = newCustomer.CustomerDetails.Eicode;

					var saveCustomerDetailResult = databaseContext.SaveChanges();


					if (saveResult > 0)
						return CustomerResult;
					else
						return null;
					//databaseContext.Customers.Add(newCustomer);
					//databaseContext.SaveChanges();
				}
				//return newCustomer;
			}
			catch (Exception ex)
			{

				throw;
			}
		}
		#endregion

	}
}
