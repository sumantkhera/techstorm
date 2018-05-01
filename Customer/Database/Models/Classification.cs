﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Entities
{
    public class Classification : BaseEntities
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ClassificationName { get; set; }
    }
}
