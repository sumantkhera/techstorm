namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_Salutation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mst_Salutation()
        {
            ClientDetails = new HashSet<ClientDetail>();
            ClientDetails1 = new HashSet<ClientDetail>();
            PolicyHolderInfoes = new HashSet<PolicyHolderInfo>();
        }

        [Key]
        [StringLength(4)]
        public string SalutationCode { get; set; }

        [StringLength(50)]
        public string Salutation_Description { get; set; }

        [StringLength(1)]
        public string Salutation_Status { get; set; }

        [StringLength(10)]
        public string Salutation_LastModifyBy { get; set; }

        public DateTime? Salutation_LastModifyDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientDetail> ClientDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientDetail> ClientDetails1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyHolderInfo> PolicyHolderInfoes { get; set; }
    }
}
