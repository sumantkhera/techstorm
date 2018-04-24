namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RenewalPolicy")]
    public partial class RenewalPolicy
    {
        [Key]
        public int RenewalId { get; set; }

        [StringLength(25)]
        public string Rn_PolicyNo { get; set; }

        public int? Rn_QuoteNoRef { get; set; }

        public int? Rn_ClientID { get; set; }

        [StringLength(10)]
        public string Rn_Prefix { get; set; }

        [StringLength(4)]
        public string Rn_TermCode { get; set; }

        [StringLength(1)]
        public string Rn_TermType { get; set; }

        [StringLength(4)]
        public string Rn_PolicyClass { get; set; }

        public decimal? Rn_TaxPercentage { get; set; }

        public decimal? Rn_NetPremium { get; set; }

        public decimal? Rn_TotalTax { get; set; }

        public decimal? Rn_BilledPremium { get; set; }

        public DateTime? Rn_TransDate { get; set; }

        [StringLength(200)]
        public string Rn_InsuredName { get; set; }

        [StringLength(4)]
        public string Rn_ProposalCode { get; set; }

        [StringLength(3)]
        public string Rn_ProducerCode { get; set; }

        [StringLength(10)]
        public string Rn_ProducerName { get; set; }

        [StringLength(4)]
        public string Rn_TransType { get; set; }

        public DateTime? Rn_EffectiveDate { get; set; }

        public DateTime? Rn_ExpiryDate { get; set; }

        [StringLength(200)]
        public string Rn_EmailAddress { get; set; }

        public DateTime? Rn_Reminder1 { get; set; }

        public DateTime? Rn_Reminder2 { get; set; }

        public DateTime? Rn_Reminder3 { get; set; }

        public DateTime? Rn_Reminder4 { get; set; }

        public DateTime? Rn_Reminder5 { get; set; }

        public bool? Rn_IsRenewed { get; set; }

        public DateTime? Rn_BatchRenewDate { get; set; }

        public DateTime? Rn_RenewalTransDate { get; set; }

        public virtual PolicyInfo PolicyInfo { get; set; }
    }
}
