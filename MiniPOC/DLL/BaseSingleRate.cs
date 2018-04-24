namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseSingleRate")]
    public partial class BaseSingleRate
    {
        [Key]
        public int SingleId { get; set; }

        [StringLength(4)]
        public string PropCode { get; set; }

        public int? Years { get; set; }

        public int? Term { get; set; }

        public decimal? Rate { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool? IsActive { get; set; }
    }
}
