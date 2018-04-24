namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_CustomerStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mst_CustomerStatus()
        {
            PolicyInfoes = new HashSet<PolicyInfo>();
        }

        [Key]
        [StringLength(4)]
        public string StatusCode { get; set; }

        [StringLength(50)]
        public string Status_Description { get; set; }

        [StringLength(1)]
        public string Status_Status { get; set; }

        [StringLength(10)]
        public string Status_LastModifyBy { get; set; }

        public DateTime? Status_LastModifyDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyInfo> PolicyInfoes { get; set; }
    }
}
