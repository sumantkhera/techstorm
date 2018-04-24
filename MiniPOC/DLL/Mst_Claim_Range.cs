namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_Claim_Range
    {
        [Key]
        public int Rng_ID { get; set; }

        [Required]
        [StringLength(4)]
        public string Rng_ProposalCode { get; set; }

        public int? Rng_Claim_Start { get; set; }

        public int? Rng_Claim_Current { get; set; }

        public int? Rng_Claim_End { get; set; }

        public int? Rng_Permanent_Start { get; set; }

        public int? Rng_Permanent_Current { get; set; }

        public int? Rng_Permanent_End { get; set; }

        public virtual Mst_Proposal Mst_Proposal { get; set; }
    }
}
