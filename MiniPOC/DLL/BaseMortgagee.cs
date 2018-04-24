namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseMortgagee")]
    public partial class BaseMortgagee
    {
        [Key]
        public int BaseId { get; set; }

        [StringLength(2)]
        public string RateType { get; set; }

        public decimal? AmountFrom { get; set; }

        public decimal? AmountTo { get; set; }

        public int? DurationFrom { get; set; }

        public int? DurationTo { get; set; }

        public decimal? FactorPercent { get; set; }

        public decimal? FactorAmount { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [StringLength(10)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
