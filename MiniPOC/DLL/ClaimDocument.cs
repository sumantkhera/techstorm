namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClaimDocument
    {
        [Key]
        public int DocumentId { get; set; }

        public int Doc_ClaimNo { get; set; }

        public int? Doc_CodeId { get; set; }

        [StringLength(100)]
        public string Doc_Name { get; set; }

        public bool? Doc_IsChecked { get; set; }

        public DateTime? Doc_ReviewDate { get; set; }

        public DateTime? Doc_AcceptedDate { get; set; }

        public int? Clm_Id { get; set; }

        public DateTime? Doc_TransDate { get; set; }

        public virtual Claim_Occurence Claim_Occurence { get; set; }

        public virtual Mst_ClaimDocument Mst_ClaimDocument { get; set; }
    }
}
