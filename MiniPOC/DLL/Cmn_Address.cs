namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cmn_Address
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cmn_Address()
        {
            ClientDetails = new HashSet<ClientDetail>();
            ClientDetails1 = new HashSet<ClientDetail>();
            ClientDetails2 = new HashSet<ClientDetail>();
            Employers = new HashSet<Employer>();
            PersonalInfoes = new HashSet<PersonalInfo>();
            PersonalInfoes1 = new HashSet<PersonalInfo>();
            PersonalInfoes2 = new HashSet<PersonalInfo>();
            PersonalInfoes3 = new HashSet<PersonalInfo>();
        }

        [Key]
        public int AddressId { get; set; }

        public int? Ads_QuoteNo { get; set; }

        [StringLength(1000)]
        public string Ads_Address1 { get; set; }

        [StringLength(1000)]
        public string Ads_Address2 { get; set; }

        [StringLength(4)]
        public string Ads_CountryId { get; set; }

        public int? Ads_ZoneId { get; set; }

        public int? Ads_AreaId { get; set; }

        public int? Ads_BlockId { get; set; }

        public int? Ads_RiskId { get; set; }

        [StringLength(10)]
        public string Ads_Zip { get; set; }

        public bool? Ads_IsActive { get; set; }

        public int? Ads_ClientId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientDetail> ClientDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientDetail> ClientDetails1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientDetail> ClientDetails2 { get; set; }

        public virtual Mst_AddressArea Mst_AddressArea { get; set; }

        public virtual Mst_AddressBlock Mst_AddressBlock { get; set; }

        public virtual Mst_Country Mst_Country { get; set; }

        public virtual PolicyInfo PolicyInfo { get; set; }

        public virtual Mst_AddressZone Mst_AddressZone { get; set; }

        public virtual Mst_AddressRisk Mst_AddressRisk { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employer> Employers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonalInfo> PersonalInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonalInfo> PersonalInfoes1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonalInfo> PersonalInfoes2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonalInfo> PersonalInfoes3 { get; set; }
    }
}
