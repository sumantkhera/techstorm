namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_AddOnCoverage
    {
        [Key]
        public int AOCovID { get; set; }

        [StringLength(6)]
        public string AOCov_CovgCode { get; set; }

        [StringLength(500)]
        public string AOCov_Description { get; set; }

        [StringLength(10)]
        public string AOCov_PropCode { get; set; }

        [StringLength(1)]
        public string AOCov_Detail { get; set; }

        public int? AOCov_DefaultValue { get; set; }

        public DateTime? AOCov_LastModifyBy { get; set; }

        public DateTime? AOCov_LastModifyDate { get; set; }

        [StringLength(5)]
        public string AOCov_SectionCode { get; set; }

        public bool IsActive { get; set; }

        public int? AOCov_Parent_QstId { get; set; }
    }
}
