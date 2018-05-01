﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Entities
{
    public class CustomerImage : BaseEntities
    {
        [Key]
        public int Id { get; set; }
        
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public byte[] Image { get; set; }
    }
}
