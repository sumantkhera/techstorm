using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class Customer : BaseModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ClientTypeId { get; set; }
        [Required]
        public int ClassificationId { get; set; }
        [Required]
        public string BusinessName { get; set; }
        [Required]
        public string Salutation { get; set; }

        [Required]
        public string PrimaryContact { get; set; }

		public CustomerDetail CustomerDetails { get; set; }
    }
}
