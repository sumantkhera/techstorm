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

        public ICollection<CustomerDetail> CustomDetail { get; set; }
    }
}
