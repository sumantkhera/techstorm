namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_LOB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mst_LOB()
        {
            Mst_Proposal = new HashSet<Mst_Proposal>();
            Mst_LOBCountry = new HashSet<Mst_LOBCountry>();
            Mst_Tabs = new HashSet<Mst_Tabs>();
        }

        [Key]
        [StringLength(1)]
        public string LOBCode { get; set; }

        [StringLength(50)]
        public string LOB_Desc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mst_Proposal> Mst_Proposal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mst_LOBCountry> Mst_LOBCountry { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mst_Tabs> Mst_Tabs { get; set; }
    }
}
