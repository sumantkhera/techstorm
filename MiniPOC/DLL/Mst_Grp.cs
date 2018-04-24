namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_Grp
    {
        [Key]
        public int GrpID { get; set; }

        [Required]
        [StringLength(3)]
        public string Usr_Grp { get; set; }

        [Required]
        [StringLength(5)]
        public string Grp_Code { get; set; }

        [StringLength(100)]
        public string Grp_Desc { get; set; }

        [StringLength(10)]
        public string Chgusr { get; set; }

        public DateTime? Chgtime { get; set; }

        [StringLength(1)]
        public string Status { get; set; }

        public int? Auth_Level { get; set; }

        public int? Dis_Auth { get; set; }

        [StringLength(10)]
        public string Prod_Code { get; set; }

        [StringLength(5)]
        public string Grp_ProdCode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Grp_CommPerc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Grp_SalesTragetMonth1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Grp_SalesTragetMonth2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Grp_SalesTragetMonth3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Grp_SalesTragetMonth4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Grp_SalesTragetMonth5 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Grp_SalesTragetMonth6 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Grp_SalesTragetMonth7 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Grp_SalesTragetMonth8 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Grp_SalesTragetMonth9 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Grp_SalesTragetMonth10 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Grp_SalesTragetMonth11 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Grp_SalesTragetMonth12 { get; set; }

        public DateTime? Grp_EffectiveDate { get; set; }

        public DateTime? Grp_ExpiryDate { get; set; }

        [StringLength(10)]
        public string Grp_BranchCode { get; set; }

        [StringLength(10)]
        public string Grp_LastModifyBy { get; set; }

        public DateTime? Grp_LastModifyDate { get; set; }
    }
}
