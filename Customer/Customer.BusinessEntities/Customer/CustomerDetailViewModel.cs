using System;
using System.ComponentModel.DataAnnotations;

namespace Customer.BusinessEntities.Customer
{
    public class CustomerDetailViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessageResourceType = (typeof(Utility.Resource.Error)), ErrorMessageResourceName = "RequiredField")]
        [Range(1, Int32.MaxValue, ErrorMessageResourceType = (typeof(Utility.Resource.Error)), ErrorMessageResourceName = "ClientType")]
        public int ClientTypeId { get; set; }

        [Required(ErrorMessageResourceType = (typeof(Utility.Resource.Error)), ErrorMessageResourceName = "RequiredField")]
        [Range(1, Int32.MaxValue, ErrorMessageResourceType = (typeof(Utility.Resource.Error)), ErrorMessageResourceName = "Classification")]
        public int ClassificationId { get; set; }

        [Required, StringLength(500, MinimumLength = 1, ErrorMessageResourceType = (typeof(Utility.Resource.Error)), ErrorMessageResourceName = "BusinessName")]
        public string BusinessName { get; set; }

        [Required, StringLength(10, MinimumLength = 1, ErrorMessageResourceType = (typeof(Utility.Resource.Error)), ErrorMessageResourceName = "RequiredField")]
        [RegularExpression("^[0-9]*$", ErrorMessageResourceType = (typeof(Utility.Resource.Error)), ErrorMessageResourceName = "Phone")]
        public string Phone { get; set; }

        public string Salutation { get; set; }

        [Required, StringLength(10, MinimumLength = 1, ErrorMessageResourceType = (typeof(Utility.Resource.Error)), ErrorMessageResourceName = "RequiredField")]
        [RegularExpression("^[0-9]*$", ErrorMessageResourceType = (typeof(Utility.Resource.Error)), ErrorMessageResourceName = "PrimaryContact")]
        public string PrimaryContact { get; set; }

        public string PrimaryAddress1 { get; set; }

        public string PrimaryAddress2 { get; set; }

        public string PrimaryAddress3 { get; set; }

        public string PrimaryCity { get; set; }

        public string PrimaryCounty { get; set; }

        public string PrimaryEicode { get; set; }

        public bool IsSecondaryAddressSame { get; set; }

        public string SecondaryAddress1 { get; set; }

        public string SecondaryAddress2 { get; set; }

        public string SecondaryAddress3 { get; set; }

        public string SecondaryCity { get; set; }

        public string SecondaryCounty { get; set; }

        public string SecondaryEicode { get; set; }

        public byte[] Image { get; set; }
    }
}
