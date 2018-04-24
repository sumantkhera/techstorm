namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReinsuranceTransactionHistory")]
    public partial class ReinsuranceTransactionHistory
    {
        [Key]
        public int RT_History_ID { get; set; }

        public int RT_History_QuoteNo { get; set; }

        public int RT_History_ContractType_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string RT_History_TreatyType { get; set; }

        public decimal? RT_History_LowerLimit { get; set; }

        public decimal RT_History_UpperLimit { get; set; }

        [StringLength(100)]
        public string RT_History_Reinsurer { get; set; }

        public decimal? RT_History_LimitPerc { get; set; }

        public decimal? RT_History_CATPerilPerc { get; set; }

        public decimal? RT_History_NonCATPerilPerc { get; set; }

        public decimal? RT_History_CATPerilAmt { get; set; }

        public decimal? RT_History_NonCATPerilAmt { get; set; }

        public decimal? RT_History_TotalPerilAmt { get; set; }

        public decimal? RT_History_SumInsuredDistAmt { get; set; }

        public decimal? RT_History_SumInsuredPerc { get; set; }

        public decimal? RT_History_CATPerilCommPerc { get; set; }

        public decimal? RT_History_NonCATPerilCommPerc { get; set; }

        public decimal? RT_History_CATPerilCommAmt { get; set; }

        public decimal? RT_History_NonCATPerilCommAmt { get; set; }

        public int? RT_History_UnitId { get; set; }

        public DateTime? RT_History_CreatedDate { get; set; }

        [StringLength(20)]
        public string RT_History_LobType { get; set; }
    }
}
