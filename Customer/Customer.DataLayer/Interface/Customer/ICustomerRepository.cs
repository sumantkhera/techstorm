﻿using Customer.BusinessEntities.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.DataLayer.Interface.Customer
{
    public interface ICustomerRepository
    {
        IEnumerable<CustomerListViewModel> GetCustomerList();
    }
}
