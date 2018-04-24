namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EarnedPremiumTranscation")]
    public partial class EarnedPremiumTranscation
    {
        [Key]
        public int TransactionId { get; set; }

        [StringLength(2)]
        public string Pol_TransType { get; set; }

        [StringLength(4)]
        public string Pol_ProposalCode { get; set; }

        [StringLength(50)]
        public string Pol_PolicyNumber { get; set; }

        public DateTime? Pol_EffectiveDate { get; set; }

        public DateTime? Pol_ExpiryDate { get; set; }

        public decimal? Total_Prem { get; set; }

        public decimal? EarnedPremium { get; set; }

        public decimal? UnEarnedPremium { get; set; }

        public DateTime? CurrentDate { get; set; }

        [StringLength(3)]
        public string Producer_Type { get; set; }

        [StringLength(10)]
        public string Pol_AgentiD { get; set; }

        [StringLength(50)]
        public string PolicyNumberOnly { get; set; }

        [StringLength(200)]
        public string InsuredName { get; set; }

        public decimal? PaymentReceived { get; set; }

        [StringLength(100)]
        public string producer_name { get; set; }

        public decimal? GrossPremium { get; set; }

        public virtual Mst_ProducerCode Mst_ProducerCode { get; set; }

        public virtual Mst_Proposal Mst_Proposal { get; set; }

        public virtual Mst_TransType Mst_TransType { get; set; }
    }
}
