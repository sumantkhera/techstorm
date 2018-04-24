namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_Tabs
    {
        [Key]
        public int TabId { get; set; }

        [StringLength(50)]
        public string Tab_Name { get; set; }

        [StringLength(50)]
        public string Tab_DisName { get; set; }

        [StringLength(10)]
        public string Tab_Prp_TabCode { get; set; }

        [StringLength(1)]
        public string Tab_Prp_LOB { get; set; }

        [StringLength(4)]
        public string Tab_Prp_Code { get; set; }

        [StringLength(250)]
        public string Tab_Prp_URL { get; set; }

        public int? Tab_LastModifyBy { get; set; }

        public DateTime? Tab_LastModifyDate { get; set; }

        public bool Tab_IsActive { get; set; }

        public bool? Tab_IsThirdParty { get; set; }

        [StringLength(20)]
        public string ControllerName { get; set; }

        [StringLength(50)]
        public string ActionName { get; set; }

        public virtual Mst_LOB Mst_LOB { get; set; }

        public virtual Mst_Proposal Mst_Proposal { get; set; }
    }
}
