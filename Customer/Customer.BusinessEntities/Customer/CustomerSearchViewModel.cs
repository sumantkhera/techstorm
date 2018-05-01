using Customer.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.ViewModel.Customer
{
    public class CustomerSearchViewModel : FilterBaseClass
    {
        public string CustomerName { get; set; }

        public string Phone { get; set; }

        public string County { get; set; }

        public string City { get; set; }

        public string EirCode { get; set; }

        public DateTime? DateAddedFrom { get; set; }

        public DateTime? DateAddedTo { get; set; }

    }
}
