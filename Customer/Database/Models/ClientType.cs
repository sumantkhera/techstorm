using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class ClientType : BaseModel
    {
        [Key]
        public short Id { get; set; }

        [Required]
        public string ClientTypeName { get; set; }
    }
}
