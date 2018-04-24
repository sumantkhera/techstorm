namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_AddressZone
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mst_AddressZone()
        {
            Claim_Name = new HashSet<Claim_Name>();
            Claim_Occurence = new HashSet<Claim_Occurence>();
            Claim_Occurence1 = new HashSet<Claim_Occurence>();
            Claim_Occurence2 = new HashSet<Claim_Occurence>();
            Cmn_Address = new HashSet<Cmn_Address>();
            Mst_WorkShop = new HashSet<Mst_WorkShop>();
        }

        [Key]
        public int zone_ID { get; set; }

        [Required]
        [StringLength(4)]
        public string zone_code { get; set; }

        [StringLength(50)]
        public string zone_name { get; set; }

        [StringLength(4)]
        public string country_code { get; set; }

        [StringLength(1)]
        public string capital { get; set; }

        [StringLength(10)]
        public string zone_LastModifyBy { get; set; }

        public DateTime? zone_LastModifyDate { get; set; }

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
        public virtual ICollection<Mst_WorkShop> Mst_WorkShop { get; set; }

        public virtual Mst_Country Mst_Country { get; set; }
    }
}
