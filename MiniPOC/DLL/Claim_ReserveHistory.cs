namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Claim_ReserveHistory
    {
        [Key]
        public int Res_ID { get; set; }

        public int Clm_ClaimNo { get; set; }

        [StringLength(5)]
        public string Res_Coverage { get; set; }

        public decimal? Res_Loss { get; set; }

        public decimal? Res_Expense { get; set; }

        public int? Res_ClaimantID { get; set; }

        public int? Res_Clm_ClaimantID { get; set; }

        [StringLength(4)]
        public string Res_Perils_Code { get; set; }

        [StringLength(10)]
        public string Res_Consequetal { get; set; }

        public DateTime? Res_CreateDate { get; set; }

        public decimal? Res_ClaimStatement { get; set; }

        public int? Res_ReserveId { get; set; }

        public DateTime? Res_TransDate { get; set; }

        [StringLength(10)]
        public string Res_User { get; set; }

        public virtual Claim_Occurence Claim_Occurence { get; set; }

        public virtual Claim_ReserveDetails Claim_ReserveDetails { get; set; }
    }
}
