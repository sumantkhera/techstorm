namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_Country
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mst_Country()
        {
            Claim_Name = new HashSet<Claim_Name>();
            Claim_Name1 = new HashSet<Claim_Name>();
            Claim_Name2 = new HashSet<Claim_Name>();
            Claim_Occurence = new HashSet<Claim_Occurence>();
            Claim_Occurence1 = new HashSet<Claim_Occurence>();
            Claim_Occurence2 = new HashSet<Claim_Occurence>();
            ClientDetails = new HashSet<ClientDetail>();
            ClientDetails1 = new HashSet<ClientDetail>();
            Cmn_Address = new HashSet<Cmn_Address>();
            Mst_AddressZone = new HashSet<Mst_AddressZone>();
            Personnel_Identity = new HashSet<Personnel_Identity>();
        }

        [Key]
        [StringLength(4)]
        public string CountryCode { get; set; }

        [StringLength(50)]
        public string Country_Desc { get; set; }

        [StringLength(5)]
        public string Policy_Code { get; set; }

        [StringLength(5)]
        public string Curr_Code { get; set; }

        [StringLength(1)]
        public string Country_Status { get; set; }

        [StringLength(10)]
        public string Country_LastModifyBy { get; set; }

        public DateTime? Country_LastModifyDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_Name> Claim_Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_Name> Claim_Name1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_Name> Claim_Name2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_Occurence> Claim_Occurence { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_Occurence> Claim_Occurence1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_Occurence> Claim_Occurence2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientDetail> ClientDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientDetail> ClientDetails1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cmn_Address> Cmn_Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mst_AddressZone> Mst_AddressZone { get; set; }

        public virtual Mst_Usr Mst_Usr { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personnel_Identity> Personnel_Identity { get; set; }
    }
}
