using Customer.BusinessEntities.Common;
using System;

namespace Customer.BusinessEntities.Customer
{
    public class CustomerListViewModel : BaseViewModel
    {
        public int Id { get; set; }

        public string BusinessName { get; set; }

        public int? CustomerId { get; set; }

        public int? ClientTypeId { get; set; }

        public int? ClassificationId { get; set; }

        public string Salutation { get; set; }

        public string PrimaryContact { get; set; }

        public string Phone { get; set; }

        public string PrimaryAddress1 { get; set; }

        public string PrimaryAddress2 { get; set; }

        public string PrimaryAddress3 { get; set; }

        public string PrimaryCity { get; set; }

        public string PrimaryCounty { get; set; }

        public string PrimaryeirCode { get; set; }

        public bool IsSecondaryAddressSame { get; set; }

        public string SecondaryAddress1 { get; set; }

        public string SecondaryAddress2 { get; set; }

        public string SecondaryAddress3 { get; set; }

        public string SecondaryCity { get; set; }

        public string SecondaryCounty { get; set; }

        public string SecondaryeirCode { get; set; }
    }
}