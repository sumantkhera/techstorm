namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EarnedPremiumSummary")]
    public partial class EarnedPremiumSummary
    {
        [Key]
        public int SummaryId { get; set; }

        public decimal? Total_Prem { get; set; }

        public decimal? EarnedPremium { get; set; }

        public decimal? UnEarnedPremium { get; set; }

        public DateTime? CurrentDate { get; set; }

        public decimal? PaymentReceived { get; set; }
    }
}
