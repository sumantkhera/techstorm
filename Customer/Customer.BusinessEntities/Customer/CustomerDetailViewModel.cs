using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aa = Customer.Utility;

namespace Customer.BusinessEntities.Customer
{
    public class CustomerDetailViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessageResourceType =  (typeof(aa.Resource.Error)), ErrorMessageResourceName = "ClientType")]
        public int ClientTypeId { get; set; }

        [Required(ErrorMessageResourceType = (typeof(aa.Resource.Error)), ErrorMessageResourceName = "Classification")]
        public int ClassificationId { get; set; }

        [Required, StringLength(500, MinimumLength = 1, ErrorMessageResourceType = (typeof(aa.Resource.Error)), ErrorMessageResourceName = "BusinessName")]

        public string BusinessName { get; set; }

        public string Salutation { get; set; }

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

		public string Phone { get; set; }

        [Required, RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        
		public string Eicode { get; set; }

	}
}
