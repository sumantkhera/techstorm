namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MasterCoverageSumInsured")]
    public partial class MasterCoverageSumInsured
    {
        public int ID { get; set; }

        [Required]
        [StringLength(2)]
        public string Code { get; set; }

        public decimal? SumInsured { get; set; }

        public bool? Status { get; set; }

        [StringLength(10)]
        public string LastModifyBy { get; set; }

        public DateTime? LastModifyDate { get; set; }

        public string Description { get; set; }
    }
}
