namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_PolicyTerm
    {
        [Key]
        public int TermID { get; set; }

        [StringLength(4)]
        public string Ter_PropCode { get; set; }

        [Required]
        [StringLength(50)]
        public string Ter_Code { get; set; }

        public int? Ter_Duration { get; set; }

        [StringLength(1)]
        public string Ter_DurationType { get; set; }

        [StringLength(50)]
        public string Ter_Description { get; set; }

        public int? Ter_SequenceNo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Ter_Fact { get; set; }

        [StringLength(1)]
        public string Ter_IsActive { get; set; }

        [StringLength(10)]
        public string Ter_LastModifyBy { get; set; }

        public DateTime? Ter_LastModifyDate { get; set; }

        public virtual Mst_Proposal Mst_Proposal { get; set; }
    }
}
