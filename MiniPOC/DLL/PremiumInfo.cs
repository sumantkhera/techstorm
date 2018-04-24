namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PremiumInfo")]
    public partial class PremiumInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PremiumInfo()
        {
            Billings = new HashSet<Billing>();
        }

        [Key]
        public int Prem_Id { get; set; }

        public int? QuoteNo { get; set; }

        [StringLength(4)]
        public string Plan_PropCode { get; set; }

        [StringLength(5)]
        public string Plan_Code { get; set; }

        [StringLength(4)]
        public string Plan_TrmCode { get; set; }

        [StringLength(1)]
        public string Plan_TrmType { get; set; }

        public DateTime? Plan_TransDate { get; set; }

        [StringLength(2)]
        public string Plan_TransType { get; set; }

        [StringLength(10)]
        public string Appr_UserId { get; set; }

        [StringLength(50)]
        public string Appr_Status { get; set; }

        public bool? PIF_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Down_Payment { get; set; }

        [StringLength(50)]
        public string Pay_Mode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? GovTax { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Pol_Fee { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Agn_Fee { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Total_Prem { get; set; }

        [StringLength(1000)]
        public string Appr_Desc { get; set; }

        public decimal? NetPremWithoutPerils { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? GovTaxPercentage { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SpecialSurchargePercentage { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SpecialDiscountPercentage { get; set; }

        public decimal? SpecialSurchargeAmount { get; set; }

        public decimal? SpecialDiscountAmount { get; set; }

        public decimal? Pol_EarnedPremium { get; set; }

        public decimal? BrokerCommission { get; set; }

        [StringLength(1)]
        public string BrokerCommissionType { get; set; }

        [StringLength(500)]
        public string SpecialDiscountComment { get; set; }

        [StringLength(500)]
        public string SpecialSurchargeComment { get; set; }

        public bool IsDiscontInPercentage { get; set; }

        public bool IsSurchargeInPercentage { get; set; }

        public decimal? EndorsementPremium { get; set; }

        [StringLength(10)]
        public string Prem_AgentId { get; set; }

        public bool? IsPremiumFinance { get; set; }

        [StringLength(20)]
        public string Prem_BankAccount { get; set; }

        [StringLength(20)]
        public string Prem_Transit { get; set; }

        public decimal? Prem_DownPayment { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Prem_DownPaymentPercentage { get; set; }

        public decimal? Prem_AmountFinance { get; set; }

        public decimal? Prem_FinanceCharges { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Prem_FinanceChargesPercentage { get; set; }

        public decimal? Prem_MonthlyInstalment { get; set; }

        public DateTime? Prem_InstalmentDueDate { get; set; }

        public decimal? Prem_EnterMonthlyInstalment { get; set; }

        public decimal? Prem_NetAmount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Billing> Billings { get; set; }

        public virtual Mst_Proposal Mst_Proposal { get; set; }

        public virtual Mst_Usr Mst_Usr { get; set; }

        public virtual PolicyInfo PolicyInfo { get; set; }
    }
}
