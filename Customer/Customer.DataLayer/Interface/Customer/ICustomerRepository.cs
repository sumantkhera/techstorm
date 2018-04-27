﻿using Customer.BusinessEntities.Common;
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
		/// <summary>
		/// Get customer Information
		/// </summary>
		/// <param name="customer"></param>
		/// <returns></returns>
		IEnumerable<CustomerListViewModel> GetCustomerList(CustomerSearchViewModel customerSearchViewModel);

        /// <summary>
        /// Save customer Information
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        AddUpdateResultViewModel Add(DataModel.Customer customer, int userId);

        /// <summary>
        /// Update customer Information
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        AddUpdateResultViewModel UpdateCustomer(DataModel.Customer customer, int userId);

	}
}
