namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PensionSourceOfFundsTemp")]
    public partial class PensionSourceOfFundsTemp
    {
        public int Id { get; set; }

        public int? MemberId { get; set; }

        [StringLength(500)]
        public string CoverageCode { get; set; }

        public decimal? Premium { get; set; }

        public decimal? Commission { get; set; }

        [StringLength(500)]
        public string FundSource { get; set; }

        [StringLength(500)]
        public string SuperAnnuation { get; set; }

        public decimal? AnnualContribution { get; set; }

        [StringLength(500)]
        public string PaymentFrequency { get; set; }

        [StringLength(500)]
        public string PaymentMode { get; set; }

        [StringLength(500)]
        public string RiskPref { get; set; }

        [StringLength(500)]
        public string InvestmentApproach { get; set; }
    }
}
