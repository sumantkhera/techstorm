namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Claim_Comments
    {
        [Key]
        public int CommentId { get; set; }

        public int? Clm_ClaimNo { get; set; }

        [StringLength(1000)]
        public string Clm_CommentDesc { get; set; }

        public DateTime? Clm_CommentDate { get; set; }
    }
}
