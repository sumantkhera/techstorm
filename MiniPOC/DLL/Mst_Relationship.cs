namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_Relationship
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mst_Relationship()
        {
            Claim_Name = new HashSet<Claim_Name>();
        }

        [Key]
        [StringLength(4)]
        public string RelationshipCode { get; set; }

        [StringLength(50)]
        public string Relationship_Description { get; set; }

        [StringLength(1)]
        public string Relationship_Status { get; set; }

        [StringLength(10)]
        public string Relationship_LastModifyBy { get; set; }

        public DateTime? Relationship_LastModifyDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_Name> Claim_Name { get; set; }
    }
}
