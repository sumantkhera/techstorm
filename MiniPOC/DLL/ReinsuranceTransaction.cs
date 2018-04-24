namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReinsuranceTransaction")]
    public partial class ReinsuranceTransaction
    {
        [Key]
        public int RT_ID { get; set; }

        public int RT_QuoteNo { get; set; }

        public int RT_ContractType_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string RT_TreatyType { get; set; }

        public decimal? RT_LowerLimit { get; set; }

        public decimal RT_UpperLimit { get; set; }

        [StringLength(100)]
        public string RT_Reinsurer { get; set; }

        public decimal? RT_LimitPerc { get; set; }

        public decimal? RT_CATPerilPerc { get; set; }

        public decimal? RT_NonCATPerilPerc { get; set; }

        public decimal? RT_CATPerilAmt { get; set; }

        public decimal? RT_NonCATPerilAmt { get; set; }

        public decimal? RT_TotalPerilAmt { get; set; }

        public decimal? RT_SumInsuredDistAmt { get; set; }

        public decimal? RT_SumInsuredPerc { get; set; }

        public decimal? RT_CATPerilCommPerc { get; set; }

        public decimal? RT_NonCATPerilCommPerc { get; set; }

        public decimal? RT_CATPerilCommAmt { get; set; }

        public decimal? RT_NonCATPerilCommAmt { get; set; }

        public int? RT_UnitId { get; set; }

        [StringLength(20)]
        public string RT_LobType { get; set; }

        [StringLength(5)]
        public string RT_CoverageCode { get; set; }
    }
}
