namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberAddonCoverage")]
    public partial class MemberAddonCoverage
    {
        public int Id { get; set; }

        public int? MemberId { get; set; }

        [StringLength(5)]
        public string CoverageCode { get; set; }

        public decimal? Premium { get; set; }

        public decimal? Commission { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public decimal? Coverage1 { get; set; }

        public decimal? Coverage2 { get; set; }

        public decimal? CalculatedPremium { get; set; }

        public decimal? CalculatedComm { get; set; }

        public decimal? NetPremium { get; set; }

        public decimal? ActualCoverage1 { get; set; }

        public decimal? ActualCoverage2 { get; set; }

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

        public int? LoanId { get; set; }

        public bool? IsPermanentClaimNo { get; set; }
    }
}
