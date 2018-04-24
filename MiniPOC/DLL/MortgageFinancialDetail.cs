namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MortgageFinancialDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QuoteNo { get; set; }

        [StringLength(50)]
        public string BankerName { get; set; }

        [StringLength(500)]
        public string BankerAddress { get; set; }

        public bool? AnyotherProposed { get; set; }

        [StringLength(50)]
        public string ProposedName { get; set; }

        public bool? AccomodationObtained { get; set; }

        [StringLength(500)]
        public string Obtaineddescritption { get; set; }

        public bool? HaveLIC { get; set; }

        public bool? LICFreeAssignCollab { get; set; }

        public decimal? GrossSalary { get; set; }

        public decimal? Allowance { get; set; }

        public decimal? RentIncome { get; set; }

        public decimal? OtherIncome { get; set; }

        public decimal? IncomeTax { get; set; }

        public decimal? NationalInsurance { get; set; }

        public decimal? WidowsOrphan { get; set; }

        public decimal? CreditUnion { get; set; }

        public decimal? LifeHeathContribution { get; set; }

        public decimal? InsurancePremium { get; set; }

        public decimal? BankLoans { get; set; }

        public decimal? OtherLoans { get; set; }

        public decimal? HirePurchase { get; set; }

        public decimal? Rent { get; set; }

        public decimal? LivingExpence { get; set; }

        public decimal? Entertainment { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public decimal? TotalIncome { get; set; }

        public decimal? TotalExpence { get; set; }

        public bool? IsRegCompany { get; set; }

        public decimal? TotalLiabilities { get; set; }

        public decimal? TotalAssests { get; set; }
    }
}
