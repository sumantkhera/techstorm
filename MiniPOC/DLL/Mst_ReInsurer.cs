namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_ReInsurer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mst_ReInsurer()
        {
            PolicyInfoes = new HashSet<PolicyInfo>();
        }

        [Key]
        [StringLength(10)]
        public string Reins_Code { get; set; }

        [StringLength(100)]
        public string Reins_Name { get; set; }

        [StringLength(8)]
        public string currency_code { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? comm_percent { get; set; }

        [StringLength(50)]
        public string reins_add1 { get; set; }

        [StringLength(50)]
        public string reins_add2 { get; set; }

        [StringLength(15)]
        public string reins_tel_no { get; set; }

        [StringLength(15)]
        public string reins_fax_no { get; set; }

        [StringLength(50)]
        public string reins_contact { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? reins_balance { get; set; }

        [StringLength(1)]
        public string Reins_Status { get; set; }

        [StringLength(10)]
        public string Reins_LastModifyBy { get; set; }

        public DateTime? Reins_LastModifyDate { get; set; }

        [StringLength(50)]
        public string Town { get; set; }

        [StringLength(50)]
        public string State { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(100)]
        public string Ads_AddressLine1 { get; set; }

        [StringLength(100)]
        public string Ads_AddressLine2 { get; set; }

        [StringLength(50)]
        public string Ads_City { get; set; }

        [StringLength(50)]
        public string Ads_State { get; set; }

        [StringLength(50)]
        public string Ads_Country { get; set; }

        [StringLength(10)]
        public string Ads_Zip { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyInfo> PolicyInfoes { get; set; }
    }
}
