using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Entities
{
    public class Customer : BaseEntities
    {
        [Key]
        public int Id { get; set; }

        public ICollection<CustomerDetail> CustomDetail { get; set; }

        public ICollection<CustomerImage> CustomImage { get; set; }
    }
}
