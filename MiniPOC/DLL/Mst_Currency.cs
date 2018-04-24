namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_Currency
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mst_Currency()
        {
            PolicyInfoes = new HashSet<PolicyInfo>();
        }

        [Key]
        [StringLength(4)]
        public string currency_code { get; set; }

        [StringLength(50)]
        public string currency_desc { get; set; }

        public decimal? current_rate { get; set; }

        [StringLength(1)]
        public string currency_Status { get; set; }

        [StringLength(10)]
        public string currency_LastModifyBy { get; set; }

        public DateTime? currency_LastModifyDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyInfo> PolicyInfoes { get; set; }
    }
}
