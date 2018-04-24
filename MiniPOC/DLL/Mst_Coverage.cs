namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_Coverage
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string Cov_Code { get; set; }

        [StringLength(150)]
        public string Cov_Description { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string Cov_BusinessClass { get; set; }

        [StringLength(1)]
        public string Cov_AllowSumIns { get; set; }

        [StringLength(1)]
        public string Cov_AllowBenefits { get; set; }

        [StringLength(1)]
        public string Cov_IsBase { get; set; }

        [StringLength(1)]
        public string Cov_Status { get; set; }

        [StringLength(50)]
        public string Cov_BaseCover { get; set; }

        [StringLength(10)]
        public string Cov_LastModifyBy { get; set; }

        public DateTime? Cov_LastModifyDate { get; set; }

        [StringLength(10)]
        public string CovPropCode { get; set; }

        public virtual Mst_Usr Mst_Usr { get; set; }
    }
}
