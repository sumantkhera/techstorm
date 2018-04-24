namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_ClaimAddOnCoverage
    {
        [Key]
        public int Clm_CovID { get; set; }

        [StringLength(5)]
        public string Clm_PropCode { get; set; }

        [StringLength(5)]
        public string Clm_CovgCode { get; set; }

        [StringLength(5)]
        public string Clm_AddOnCovgCode { get; set; }

        [StringLength(100)]
        public string Clm_AddOnCovgDesc { get; set; }

        [StringLength(5)]
        public string Clm_CovgType { get; set; }

        public bool? Clm_IsActive { get; set; }

        [StringLength(10)]
        public string Clm_LastModifyBy { get; set; }

        public DateTime? Clm_LastModifyDate { get; set; }
    }
}
