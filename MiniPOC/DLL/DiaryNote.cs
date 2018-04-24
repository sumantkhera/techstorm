namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DiaryNote
    {
        public int ID { get; set; }

        public int? QuoteNo { get; set; }

        public int? ClaimNo { get; set; }

        public string Notes { get; set; }

        [StringLength(50)]
        public string User { get; set; }

        public DateTime? DateAdded { get; set; }

        [StringLength(1)]
        public string Status { get; set; }

        public DateTime? DateUpdated { get; set; }

        public virtual Claim_Occurence Claim_Occurence { get; set; }

        public virtual PolicyInfo PolicyInfo { get; set; }
    }
}
