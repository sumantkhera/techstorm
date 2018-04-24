namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_Proposal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mst_Proposal()
        {
            Claim_Occurence = new HashSet<Claim_Occurence>();
            Claim_Occurence1 = new HashSet<Claim_Occurence>();
            EarnedPremiumTranscations = new HashSet<EarnedPremiumTranscation>();
            Mst_BrokerCommissions = new HashSet<Mst_BrokerCommissions>();
            Mst_Claim_Range = new HashSet<Mst_Claim_Range>();
            Mst_ClaimLossCause = new HashSet<Mst_ClaimLossCause>();
            mst_DocumentType = new HashSet<mst_DocumentType>();
            Mst_PolicyTerm = new HashSet<Mst_PolicyTerm>();
            Mst_Question = new HashSet<Mst_Question>();
            Mst_SystemVariable = new HashSet<Mst_SystemVariable>();
            Mst_Tabs = new HashSet<Mst_Tabs>();
            PolicyInfoes = new HashSet<PolicyInfo>();
            PremiumInfoes = new HashSet<PremiumInfo>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Prp_ID { get; set; }

        [Key]
        [StringLength(4)]
        public string Prp_Code { get; set; }

        [StringLength(50)]
        public string Prp_Name { get; set; }

        [StringLength(100)]
        public string Prp_Desc { get; set; }

        public bool? Prp_IsActive { get; set; }

        public int? Prp_LastModifyBy { get; set; }

        public DateTime? Prp_LastModifyDate { get; set; }

        [StringLength(1)]
        public string Prp_LOB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_Occurence> Claim_Occurence { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_Occurence> Claim_Occurence1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EarnedPremiumTranscation> EarnedPremiumTranscations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mst_BrokerCommissions> Mst_BrokerCommissions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mst_Claim_Range> Mst_Claim_Range { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mst_ClaimLossCause> Mst_ClaimLossCause { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mst_DocumentType> mst_DocumentType { get; set; }

        public virtual Mst_LOB Mst_LOB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mst_PolicyTerm> Mst_PolicyTerm { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mst_Question> Mst_Question { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mst_SystemVariable> Mst_SystemVariable { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mst_Tabs> Mst_Tabs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyInfo> PolicyInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PremiumInfo> PremiumInfoes { get; set; }
    }
}
