namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberCoverageInfoTemp")]
    public partial class MemberCoverageInfoTemp
    {
        [Key]
        public int MemberCoverageInfoId { get; set; }

        public int? PersonalInfoId { get; set; }

        [StringLength(1)]
        public string Engagement { get; set; }

        [StringLength(1)]
        public string EmploymentType { get; set; }

        public decimal? AnnualSalary { get; set; }

        public string JobDuties { get; set; }

        [StringLength(25)]
        public string LoanAccountNo { get; set; }

        public decimal? LoanAppliedAmount { get; set; }

        public DateTime? CommenceDate { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public int? NoOfMonths { get; set; }

        public decimal? ExistingLoanBalance { get; set; }

        public int? DefaultPeriod { get; set; }

        public DateTime? ExistingCommenceDate { get; set; }

        public DateTime? ExistingExpiryDate { get; set; }

        public int? ExistingNoOfMonths { get; set; }

        public decimal? MaxDeathBenefit { get; set; }

        public decimal? Premium { get; set; }

        [StringLength(25)]
        public string LoanType { get; set; }

        [StringLength(1)]
        public string BreavementPlan { get; set; }

        public bool? IsInvoluntaryEmployment { get; set; }

        public bool? IsTotalDisability { get; set; }

        public int? InvoluntaryTerm { get; set; }

        public decimal? TotalLoanAmount { get; set; }

        public DateTime? TotalExpiryDate { get; set; }

        public int? TotalNoOfMonths { get; set; }

        public decimal? Coverage { get; set; }

        public int? LoanId { get; set; }

        public virtual PersonalInfoTemp PersonalInfoTemp { get; set; }
    }
}
