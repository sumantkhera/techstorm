namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Personnel_Identity
    {
        [Key]
        public int PersonIdentityID { get; set; }

        public int? Idt_PersonalInfoId { get; set; }

        public int? Idt_SequenceNo { get; set; }

        [StringLength(25)]
        public string Idt_IdentityVal { get; set; }

        public DateTime? Idt_Issue_Dt { get; set; }

        public DateTime? Idt_Expiry_Dt { get; set; }

        public int? Idt_PolicyDocId { get; set; }

        public bool? Idt_IsActive { get; set; }

        public int? Pif_Lic_Type { get; set; }

        public int? Pif_LicenceClassId { get; set; }

        [StringLength(50)]
        public string Idt_Permit { get; set; }

        [StringLength(50)]
        public string Idt_Class { get; set; }

        [StringLength(4)]
        public string Idt_Country { get; set; }

        [StringLength(50)]
        public string Idt_City { get; set; }

        [StringLength(500)]
        public string Idt_ClassValue { get; set; }

        public DateTime? Idt_Renew_Dt { get; set; }

        public virtual Mst_Country Mst_Country { get; set; }

        public virtual mst_DocumentType mst_DocumentType { get; set; }

        public virtual PersonalInfo PersonalInfo { get; set; }

        public virtual PolicyDocument PolicyDocument { get; set; }
    }
}
