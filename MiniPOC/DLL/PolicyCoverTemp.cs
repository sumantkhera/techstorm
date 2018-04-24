namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PolicyCoverTemp")]
    public partial class PolicyCoverTemp
    {
        public int Id { get; set; }

        public int PolicyInfoId { get; set; }

        public bool? GroupLife { get; set; }

        public bool? CreditorLife { get; set; }

        public bool? CriticalIllness { get; set; }

        public bool? AddandD { get; set; }

        public bool? Breavement { get; set; }

        public bool? Involuntary { get; set; }

        public int CoverType { get; set; }

        [StringLength(50)]
        public string BaseCover { get; set; }

        [StringLength(100)]
        public string LoanType { get; set; }

        public decimal? TotalPremium { get; set; }

        public decimal? TotalCommission { get; set; }

        public decimal? TotalFees { get; set; }

        public decimal? NetPremium { get; set; }

        [StringLength(200)]
        public string Error { get; set; }

        public bool? AdandD { get; set; }

        [StringLength(10)]
        public string PremiumMode { get; set; }

        public decimal? BlendedPrimaryRate { get; set; }

        public decimal? BlendedSecondaryRate { get; set; }

        public virtual PolicyInfoTemp PolicyInfoTemp { get; set; }
    }
}
