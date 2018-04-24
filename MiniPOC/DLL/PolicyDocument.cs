namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PolicyDocument")]
    public partial class PolicyDocument
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PolicyDocument()
        {
            ClientDetails = new HashSet<ClientDetail>();
            ClientDetails1 = new HashSet<ClientDetail>();
            ClientDetails2 = new HashSet<ClientDetail>();
            PersonalInfoes = new HashSet<PersonalInfo>();
            Personnel_Identity = new HashSet<Personnel_Identity>();
        }

        [Key]
        public int PolicyDocId { get; set; }

        public int? Pdo_QuoteNo { get; set; }

        public int? Pdo_Doc_TypeId { get; set; }

        [StringLength(50)]
        public string Pdo_DocName { get; set; }

        [StringLength(50)]
        public string Pdo_FileName { get; set; }

        [StringLength(1000)]
        public string Pdo_FilePath { get; set; }

        public DateTime? Pdo_Gen_Date { get; set; }

        public bool? Pdo_FileStatus { get; set; }

        public bool Pdo_IsActive { get; set; }

        public int? Pdo_ClientId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientDetail> ClientDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientDetail> ClientDetails1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientDetail> ClientDetails2 { get; set; }

        public virtual mst_DocumentType mst_DocumentType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonalInfo> PersonalInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personnel_Identity> Personnel_Identity { get; set; }

        public virtual PolicyInfo PolicyInfo { get; set; }
    }
}
