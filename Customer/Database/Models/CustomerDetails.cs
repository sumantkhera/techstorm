using System.ComponentModel.DataAnnotations;

namespace Database.Models
{
    public class CustomerDetails
    {
        [Key]
        public int Id { get; set; }

        public Customer Customer { get; set; }

        public string PrimaryAddress1 { get; set; }
        public string PrimaryAddress2 { get; set; }
        public string PrimaryCity { get; set; }
        public string PrimaryState { get; set; }
        public int PrimaryZipcode { get; set; }

        public string SecondaryAddress1 { get; set; }
        public string SecondaryAddress2 { get; set; }
        public string SecondaryCity { get; set; }
        public string SecondaryState { get; set; }
        public int SecondaryZipcode { get; set; }
    }
}