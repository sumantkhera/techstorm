using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Entities
{
    public class ClientType : BaseEntities
    {
        [Key]
        public short Id { get; set; }

        [Required]
        public string ClientTypeName { get; set; }
    }
}
