namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MST_ProducerName
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MST_ProducerName()
        {
            Mst_Branch = new HashSet<Mst_Branch>();
            Mst_BrokerCommissions = new HashSet<Mst_BrokerCommissions>();
            PolicyInfoes = new HashSet<PolicyInfo>();
        }

        [Key]
        [StringLength(10)]
        public string producer_code { get; set; }

        [StringLength(100)]
        public string producer_name { get; set; }

        public decimal? credit_limit { get; set; }

        [StringLength(1)]
        public string paid_license { get; set; }

        public DateTime? license_date { get; set; }

        public decimal? balance { get; set; }

        public decimal? un_applied { get; set; }

        [StringLength(1)]
        public string ag_br_type { get; set; }

        [StringLength(1)]
        public string bill_net { get; set; }

        [StringLength(8)]
        public string group_id { get; set; }

        [StringLength(1)]
        public string print_notice { get; set; }

        [StringLength(1)]
        public string hidden { get; set; }

        [StringLength(1)]
        public string aml_certified { get; set; }

        [StringLength(50)]
        public string Prod_IsActive { get; set; }

        [StringLength(10)]
        public string Prod_LastModifyBy { get; set; }

        public DateTime? Prod_LastModifyDate { get; set; }

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

        [StringLength(12)]
        public string Prod_OfficeNo1 { get; set; }

        [StringLength(12)]
        public string Prod_OfficeNo2 { get; set; }

        [StringLength(18)]
        public string Prod_FaxNo { get; set; }

        [StringLength(100)]
        public string Prod_EmailAdd { get; set; }

        [Column(TypeName = "image")]
        public byte[] Prod_Logo { get; set; }

        [StringLength(100)]
        public string Prod_LogoName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mst_Branch> Mst_Branch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mst_BrokerCommissions> Mst_BrokerCommissions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyInfo> PolicyInfoes { get; set; }
    }
}
