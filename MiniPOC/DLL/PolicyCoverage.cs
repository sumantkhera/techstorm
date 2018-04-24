namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PolicyCoverage")]
    public partial class PolicyCoverage
    {
        public int Id { get; set; }

        public int PolicyQuoteNo { get; set; }

        [StringLength(5)]
        public string CoverageCode { get; set; }

        [StringLength(50)]
        public string CoverageType { get; set; }

        [StringLength(10)]
        public string LimitCode { get; set; }

        public decimal? LimitValue { get; set; }

        public int? SurchargeFactor { get; set; }

        [StringLength(10)]
        public string PolicyUserId { get; set; }

        public bool? CoverageIsActive { get; set; }

        public decimal? LimitRate { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public DateTime? TransactionDate { get; set; }

        public decimal? Rate { get; set; }

        public virtual PolicyInfo PolicyInfo { get; set; }
    }
}
