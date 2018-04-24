namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Claim_ReserveDetails
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Claim_ReserveDetails()
        {
            Claim_PayOut = new HashSet<Claim_PayOut>();
            Claim_ReserveHistory = new HashSet<Claim_ReserveHistory>();
        }

        [Key]
        public int Res_ID { get; set; }

        public int Clm_ClaimNo { get; set; }

        [StringLength(5)]
        public string Res_Coverage { get; set; }

        public decimal? Res_Loss { get; set; }

        public decimal? Res_Expense { get; set; }

        public decimal? Res_CurrentReserve { get; set; }

        public decimal? Res_TotalPayment { get; set; }

        public int? Res_ClaimantID { get; set; }

        public decimal? Res_Estimate { get; set; }

        public decimal? Res_AOC { get; set; }

        public decimal? Res_Deductible { get; set; }

        public int? Res_Clm_ClaimantID { get; set; }

        [StringLength(5)]
        public string Res_ClaimSection { get; set; }

        public int? Res_Excess { get; set; }

        [StringLength(4)]
        public string Res_Perils_Code { get; set; }

        [StringLength(10)]
        public string Res_Consequetal { get; set; }

        public int? Res_WageId { get; set; }

        public int? Res_MedicalId { get; set; }

        public int? Res_PPDId { get; set; }

        public int? Res_CLLId { get; set; }

        public DateTime? Res_CreateDate { get; set; }

        public decimal? Res_ClaimStatement { get; set; }

        [StringLength(4)]
        public string Res_Status { get; set; }

        public decimal? Res_UnInsuredLosses { get; set; }

        public virtual Claim_Occurence Claim_Occurence { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_PayOut> Claim_PayOut { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_ReserveHistory> Claim_ReserveHistory { get; set; }
    }
}
