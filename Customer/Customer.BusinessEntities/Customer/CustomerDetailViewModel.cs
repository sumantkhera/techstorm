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

        public string Salutation { get; set; }

        [Required, StringLength(10, MinimumLength = 1, ErrorMessageResourceType = (typeof(Utility.Resource.Error)), ErrorMessageResourceName = "RequiredField")]
        [RegularExpression("^[0-9]*$", ErrorMessageResourceType = (typeof(Utility.Resource.Error)), ErrorMessageResourceName = "PrimaryContact")]
        public string PrimaryContact { get; set; }

        public string PrimaryAddress1 { get; set; }
        public string PrimaryAddress2 { get; set; }
        public string PrimaryCity { get; set; }
        public string PrimaryState { get; set; }
        public int PrimaryZipcode { get; set; }

        public bool IsSecondaryAddressSame { get; set; }

        public string SecondaryAddress1 { get; set; }
        public string SecondaryAddress2 { get; set; }
        public string SecondaryCity { get; set; }
        public string SecondaryState { get; set; }
        public int SecondaryZipcode { get; set; }

        [Required, StringLength(10, MinimumLength = 1, ErrorMessageResourceType = (typeof(Utility.Resource.Error)), ErrorMessageResourceName = "RequiredField")]
        [RegularExpression("^[0-9]*$", ErrorMessageResourceType = (typeof(Utility.Resource.Error)), ErrorMessageResourceName = "Phone")]
        public string Phone { get; set; }

        [Required(ErrorMessageResourceType = (typeof(Utility.Resource.Error)), ErrorMessageResourceName = "RequiredField")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessageResourceType = (typeof(Utility.Resource.Error)), ErrorMessageResourceName = "Email")]
        public string Email { get; set; }

        public string Eicode { get; set; }

	}
}
