using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class BaseModel
    {
        public DateTime? CreatedOn { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? ModifyOn { get; set; }

        public int? ModifyBy { get; set; }

        public int? Version { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

    }
}
