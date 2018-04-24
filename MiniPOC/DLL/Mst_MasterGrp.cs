namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_MasterGrp
    {
        [Key]
        public int GrpID { get; set; }

        [Required]
        [StringLength(3)]
        public string Grp_Code { get; set; }

        [StringLength(100)]
        public string Grp_Desc { get; set; }

        [StringLength(1)]
        public string Status { get; set; }

        [StringLength(200)]
        public string Grp_DefaultURL { get; set; }

        [StringLength(10)]
        public string Grp_LastModifyBy { get; set; }

        public DateTime? Grp_LastModifyDate { get; set; }

        public int? Grp_PageId { get; set; }
    }
}
