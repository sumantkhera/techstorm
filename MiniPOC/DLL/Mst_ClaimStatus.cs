namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_ClaimStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mst_ClaimStatus()
        {
            ClaimStatus = new HashSet<ClaimStatu>();
        }

        [Key]
        [StringLength(5)]
        public string Status_code { get; set; }

        [StringLength(500)]
        public string Status_desc { get; set; }

        [StringLength(1)]
        public string Status_type { get; set; }

        [StringLength(1)]
        public string Status { get; set; }

        [StringLength(100)]
        public string ModifyBy { get; set; }

        public DateTime? ModifyDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClaimStatu> ClaimStatus { get; set; }
    }
}
