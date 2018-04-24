namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_Usr
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mst_Usr()
        {
            Claim_Occurence = new HashSet<Claim_Occurence>();
            ClientDetails = new HashSet<ClientDetail>();
            Mst_Country = new HashSet<Mst_Country>();
            Mst_Coverage = new HashSet<Mst_Coverage>();
            PremiumInfoes = new HashSet<PremiumInfo>();
        }

        [Key]
        [StringLength(10)]
        public string UserId { get; set; }

        [StringLength(3)]
        public string Usr_Grp { get; set; }

        [StringLength(5)]
        public string Grp_Code { get; set; }

        [StringLength(50)]
        public string Usr_First_Name { get; set; }

        [StringLength(15)]
        public string Usr_Middle_Name { get; set; }

        [StringLength(15)]
        public string Usr_Last_Name { get; set; }

        public DateTime? Usr_Dob { get; set; }

        [StringLength(50)]
        public string Ads_Country { get; set; }

        [StringLength(50)]
        public string Ads_City { get; set; }

        [StringLength(10)]
        public string Ads_Zip { get; set; }

        [StringLength(1000)]
        public string Doc_path { get; set; }

        [StringLength(10)]
        public string Usr_Pwd { get; set; }

        [StringLength(100)]
        public string Usr_EmailAdd { get; set; }

        [StringLength(50)]
        public string Usr_AltEmailAdd { get; set; }

        [StringLength(12)]
        public string Usr_Mobile_1 { get; set; }

        [StringLength(12)]
        public string Usr_Mobile_2 { get; set; }

        [StringLength(18)]
        public string Usr_Work_Phone { get; set; }

        [StringLength(12)]
        public string Usr_Home_Phone { get; set; }

        public int? Usr_HntQstCd { get; set; }

        [StringLength(50)]
        public string Usr_Hnt_Ans { get; set; }

        public DateTime? Usr_InTime { get; set; }

        public DateTime? Usr_OutTime { get; set; }

        public DateTime? Usr_LstInTime { get; set; }

        [StringLength(1)]
        public string Usr_Stat { get; set; }

        [StringLength(10)]
        public string Usr_Chgusr { get; set; }

        public DateTime? Usr_Chgtime { get; set; }

        [StringLength(18)]
        public string Usr_Fax { get; set; }

        [StringLength(1)]
        public string Usr_MaritalStatus { get; set; }

        [StringLength(20)]
        public string Usr_Relation { get; set; }

        [StringLength(1)]
        public string Usr_Sex { get; set; }

        [StringLength(1)]
        public string Usr_Title { get; set; }

        [StringLength(1)]
        public string Usr_PrimaryPhone { get; set; }

        [StringLength(1)]
        public string Usr_Status { get; set; }

        [StringLength(1)]
        public string AccessLevel { get; set; }

        [StringLength(5)]
        public string Usr_Salutation { get; set; }

        [StringLength(100)]
        public string Ads_AddressLine1 { get; set; }

        [StringLength(100)]
        public string Ads_AddressLine2 { get; set; }

        [StringLength(50)]
        public string Ads_State { get; set; }

        [StringLength(1)]
        public string Grp_ProdCode { get; set; }

        [StringLength(10)]
        public string Grp_ProdName { get; set; }

        [StringLength(5)]
        public string Usr_RepUserGroup { get; set; }

        [StringLength(10)]
        public string Usr_RepUserId { get; set; }

        [StringLength(200)]
        public string Usr_SaltPassword { get; set; }

        [StringLength(200)]
        public string Usr_HashPassword { get; set; }

        public bool Usr_ChangePwdFlag { get; set; }

        [StringLength(10)]
        public string Grp_BranchCode { get; set; }

        [StringLength(10)]
        public string Usr_LastModifyBy { get; set; }

        public DateTime? Usr_LastModifyDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_Occurence> Claim_Occurence { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientDetail> ClientDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mst_Country> Mst_Country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mst_Coverage> Mst_Coverage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PremiumInfo> PremiumInfoes { get; set; }
    }
}
