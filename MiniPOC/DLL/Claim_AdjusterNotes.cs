namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Claim_AdjusterNotes
    {
        [Key]
        public int Clm_AdjusterId { get; set; }

        public int Clm_ClaimNo { get; set; }

        public int? Clm_QuoteNo { get; set; }

        [StringLength(3)]
        public string Clm_AdjusterCode { get; set; }

        [StringLength(100)]
        public string Clm_AdjusterName { get; set; }

        public DateTime? Clm_AdjusterDate { get; set; }

        [StringLength(100)]
        public string Clm_AdjusterSubject { get; set; }

        [StringLength(500)]
        public string Clm_AdjusterNotes { get; set; }

        public virtual Claim_Occurence Claim_Occurence { get; set; }

        public virtual PolicyInfo PolicyInfo { get; set; }
    }
}
