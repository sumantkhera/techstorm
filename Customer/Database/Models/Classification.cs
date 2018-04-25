using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class Classification : BaseModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ClassificationName { get; set; }
    }
}
