using Customer.BusinessEntities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.BusinessEntities.Customer
{
    public class CustomerListViewModel
    {
        public int Id { get; set; }

        public string BusinessName { get; set; }

        public string ExternalReference { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime ModifyDate { get; set; }

        public string ModifyBy { get; set; }

        public string Status { get; set; }

    }
}