namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Claim_ClaimantItemDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Claim_ClaimantItemDetail()
        {
            Claim_PayOut = new HashSet<Claim_PayOut>();
        }

        [Key]
        public int ClaimantId { get; set; }

        public int Clm_ClaimNo { get; set; }

        public int? Clm_ItemDetailId { get; set; }

        [StringLength(500)]
        public string Clm_ItemDetailValue { get; set; }

        public int? Clm_InsuredCd { get; set; }

        public int? Clm_ClmId { get; set; }

        [StringLength(50)]
        public string Clm_MName { get; set; }

        [StringLength(50)]
        public string Clm_LName { get; set; }

        [StringLength(50)]
        public string Clm_SName { get; set; }

        [StringLength(100)]
        public string Clm_CompanyName { get; set; }

        [StringLength(15)]
        public string Clm_VatRegistrationNo { get; set; }

        [StringLength(50)]
        public string Clm_CompReg { get; set; }

        [StringLength(2)]
        public string Clm_ProposerType { get; set; }

        public DateTime? Clm_CloseDate { get; set; }

        [StringLength(500)]
        public string Clm_CloseComments { get; set; }

        [StringLength(1)]
        public string Clm_CloseStatus { get; set; }

        public DateTime? Clm_ReopenDate { get; set; }

        [StringLength(500)]
        public string Clm_ReopenComments { get; set; }

        public virtual Claim_Occurence Claim_Occurence { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_PayOut> Claim_PayOut { get; set; }
    }
}
