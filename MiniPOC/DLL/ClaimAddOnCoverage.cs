namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClaimAddOnCoverage")]
    public partial class ClaimAddOnCoverage
    {
        [Key]
        public int Clm_CoverageId { get; set; }

        public int Clm_ClaimNo { get; set; }

        public int? Clm_Id { get; set; }

        [StringLength(1000)]
        public string Clm_CoverageCode { get; set; }

        public int? Clm_ClaimantID { get; set; }

        public virtual Claim_Occurence Claim_Occurence { get; set; }
    }
}
