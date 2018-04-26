using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models
{
    public class CustomerDetail : BaseModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Customer Customer { get; set; }
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

		public string Email { get; set; }

		public string Eicode { get; set; }


	}
}