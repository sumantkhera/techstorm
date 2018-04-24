namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_Question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mst_Question()
        {
            Cmn_QuestionAnswer = new HashSet<Cmn_QuestionAnswer>();
        }

        [Key]
        public int QuestionId { get; set; }

        [StringLength(500)]
        public string Qst_Des { get; set; }

        [StringLength(4)]
        public string Qst_PropCode { get; set; }

        public bool? Qst_Default { get; set; }

        [StringLength(4)]
        public string Qst_Type { get; set; }

        [StringLength(1)]
        public string Qst_IsActive { get; set; }

        public int? Qst_Parent_QstId { get; set; }

        [StringLength(10)]
        public string Qst_LastModifyBy { get; set; }

        public DateTime? Qst_LastModifyDate { get; set; }

        [StringLength(10)]
        public string Qst_Detail { get; set; }

        public bool? Qst_IsYesNoVisible { get; set; }

        [StringLength(5)]
        public string Qst_SectionCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cmn_QuestionAnswer> Cmn_QuestionAnswer { get; set; }

        public virtual Mst_Proposal Mst_Proposal { get; set; }
    }
}
