namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClaimStatu
    {
        [Key]
        public int ClaimId { get; set; }

        public int Clm_ClaimNo { get; set; }

        [StringLength(50)]
        public string Clm_PermanentClaimNo { get; set; }

        [StringLength(5)]
        public string Clm_StatusCode { get; set; }

        public DateTime? Clm_StatusDate { get; set; }

        [StringLength(500)]
        public string Clm_StatusComments { get; set; }

        [StringLength(3)]
        public string Claim_Status { get; set; }

        public virtual Claim_Occurence Claim_Occurence { get; set; }

        public virtual Mst_ClaimStatus Mst_ClaimStatus { get; set; }
    }
}
