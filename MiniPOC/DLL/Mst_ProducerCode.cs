namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_ProducerCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mst_ProducerCode()
        {
            EarnedPremiumTranscations = new HashSet<EarnedPremiumTranscation>();
            PolicyInfoes = new HashSet<PolicyInfo>();
        }

        [Key]
        [StringLength(3)]
        public string ProdCode { get; set; }

        [StringLength(100)]
        public string Prod_Desc { get; set; }

        [StringLength(1)]
        public string Prod_Status { get; set; }

        public int? Prod_LastModifyBy { get; set; }

        public DateTime? Prod_LastModifyDate { get; set; }

        [StringLength(1)]
        public string Prod_FACFlagReins { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EarnedPremiumTranscation> EarnedPremiumTranscations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyInfo> PolicyInfoes { get; set; }
    }
}
