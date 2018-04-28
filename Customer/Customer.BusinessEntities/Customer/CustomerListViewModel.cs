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

        public DateTime? ModifyDate { get; set; }

        public string ModifyBy { get; set; }

        public string Status { get; set; }

		public string Phone { get; set; }

		public string Email { get; set; }

		public string Eicode { get; set; }
        public string PrimaryAddress1 { get; set; }
        public string PrimaryAddress2 { get; set; }
        public string PrimaryCity { get; set; }
        public string PrimaryState { get; set; }
        public int PrimaryZipcode { get; set; }
        public DateTime? ModifyOn { get; set; }
        public string PrimaryContact { get; set; }
        public int? ClassificationId { get; set; }
        public string SecondaryAddress1 { get; set; }
        public int? ClientTypeId { get; set; }
        public string SecondaryAddress2 { get; set; }
        public string SecondaryCity { get; set; }
        public string SecondaryState { get; set; }
        public int SecondaryZipcode { get; set; }
    }
}