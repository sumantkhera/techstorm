namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mst_DocumentType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mst_DocumentType()
        {
            Claim_Name = new HashSet<Claim_Name>();
            Claim_Name1 = new HashSet<Claim_Name>();
            ClientDetails = new HashSet<ClientDetail>();
            ClientDetails1 = new HashSet<ClientDetail>();
            Personnel_Identity = new HashSet<Personnel_Identity>();
            PolicyDocuments = new HashSet<PolicyDocument>();
        }

        [Key]
        public int DocumentTypeId { get; set; }

        [StringLength(4)]
        public string Dot_Type { get; set; }

        [StringLength(50)]
        public string Dot_Name { get; set; }

        [StringLength(50)]
        public string Dot_Desc { get; set; }

        [StringLength(4)]
        public string Dot_ProposalCode { get; set; }

        public bool? Dot_IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_Name> Claim_Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_Name> Claim_Name1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientDetail> ClientDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientDetail> ClientDetails1 { get; set; }

        public virtual Mst_Proposal Mst_Proposal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personnel_Identity> Personnel_Identity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyDocument> PolicyDocuments { get; set; }
    }
}
