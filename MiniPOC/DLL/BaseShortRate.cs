namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseShortRate")]
    public partial class BaseShortRate
    {
        [Key]
        public int ShortId { get; set; }

        [StringLength(4)]
        public string PropCode { get; set; }

        public int? Days { get; set; }

        public decimal? ShortRate { get; set; }

        public decimal? ProRate { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool? IsActive { get; set; }
    }
}
