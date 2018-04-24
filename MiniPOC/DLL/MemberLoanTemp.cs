namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberLoanTemp")]
    public partial class MemberLoanTemp
    {
        public int Id { get; set; }

        public int? PersonalInfoId { get; set; }

        [StringLength(25)]
        public string LoanAccountNumber { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        public decimal? LoanAppliedAmount { get; set; }

        public DateTime? CommenceDate { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public int? NoOfMonths { get; set; }

        public decimal? ExistingLoanBalance { get; set; }

        public int? DefaultPeriod { get; set; }

        public DateTime? ExistingCommenceDate { get; set; }

        public DateTime? ExistingExpiryDate { get; set; }

        public int? ExistingNoOfMonths { get; set; }

        public decimal? TotalLoanAmount { get; set; }

        public DateTime? TotalExpiryDate { get; set; }

        public int? TotalNoOfMonths { get; set; }

        public decimal? MaxDeathBenefit { get; set; }

        public decimal? Premium { get; set; }

        [StringLength(25)]
        public string LoanType { get; set; }

        public decimal? LoanAppliedCoverageAmount { get; set; }

        public decimal? LoanApplliedCoveragePercentage { get; set; }

        public decimal? ExistingLoanCoverageAmount { get; set; }

        public decimal? ExistingLoanCoveragePercentage { get; set; }

        public decimal? TotalLoanCoverageAmount { get; set; }

        public decimal? TotalLoanCoveragePercentage { get; set; }

        public decimal? LoanAppliedActualAmount { get; set; }

        [StringLength(100)]
        public string ClientId { get; set; }

        public virtual PersonalInfoTemp PersonalInfoTemp { get; set; }
    }
}
