namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_ClaimDocument
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mst_ClaimDocument()
        {
            ClaimDocuments = new HashSet<ClaimDocument>();
        }

        [Key]
        public int DocumentId { get; set; }

        [StringLength(100)]
        public string Doc_Name { get; set; }

        [StringLength(5)]
        public string Doc_PropCode { get; set; }

        public bool? Doc_IsActive { get; set; }

        [StringLength(10)]
        public string Doc_LastModifyBy { get; set; }

        public DateTime? Doc_LastModifyDate { get; set; }

        [StringLength(50)]
        public string Doc_ClaimantType { get; set; }

        [StringLength(500)]
        public string Doc_ClaimantTypeVal { get; set; }

        [StringLength(5)]
        public string Doc_ClaimantTypeParent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClaimDocument> ClaimDocuments { get; set; }
    }
}
