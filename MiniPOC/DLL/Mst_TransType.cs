namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_TransType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mst_TransType()
        {
            EarnedPremiumTranscations = new HashSet<EarnedPremiumTranscation>();
            PolicyInfoes = new HashSet<PolicyInfo>();
            Transaction_Details = new HashSet<Transaction_Details>();
        }

        [Key]
        [StringLength(2)]
        public string Trn_Code { get; set; }

        [StringLength(50)]
        public string Trn_Description { get; set; }

        public bool? Trn_IsActive { get; set; }

        public int? Trn_LastModifyBy { get; set; }

        public DateTime? Trn_LastModifyDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EarnedPremiumTranscation> EarnedPremiumTranscations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyInfo> PolicyInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction_Details> Transaction_Details { get; set; }
    }
}
