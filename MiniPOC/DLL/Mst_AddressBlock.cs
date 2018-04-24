namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_AddressBlock
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mst_AddressBlock()
        {
            Claim_Name = new HashSet<Claim_Name>();
            Claim_Occurence = new HashSet<Claim_Occurence>();
            Claim_Occurence1 = new HashSet<Claim_Occurence>();
            Claim_Occurence2 = new HashSet<Claim_Occurence>();
            Cmn_Address = new HashSet<Cmn_Address>();
            Mst_AddressRisk = new HashSet<Mst_AddressRisk>();
            Mst_WorkShop = new HashSet<Mst_WorkShop>();
        }

        [Key]
        public int block_id { get; set; }

        [StringLength(4)]
        public string block_code { get; set; }

        [StringLength(4)]
        public string zone_code { get; set; }

        [StringLength(4)]
        public string area_code { get; set; }

        [StringLength(45)]
        public string block_name { get; set; }

        public decimal? block_limit { get; set; }

        public int? area_id { get; set; }

        [StringLength(10)]
        public string block_LastModifyBy { get; set; }

        public DateTime? block_LastModifyDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_Name> Claim_Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_Occurence> Claim_Occurence { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_Occurence> Claim_Occurence1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_Occurence> Claim_Occurence2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cmn_Address> Cmn_Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mst_AddressRisk> Mst_AddressRisk { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mst_WorkShop> Mst_WorkShop { get; set; }
    }
}
