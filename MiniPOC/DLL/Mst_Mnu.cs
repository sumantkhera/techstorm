namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_Mnu
    {
        [Key]
        [StringLength(10)]
        public string Mnu_Id { get; set; }

        [StringLength(50)]
        public string Mnu_Name { get; set; }

        [StringLength(250)]
        public string Mnu_Desc { get; set; }

        [StringLength(10)]
        public string Mnu_Chgusr { get; set; }

        public DateTime? Mnu_Chgtime { get; set; }

        [StringLength(100)]
        public string Mnu_Url { get; set; }

        [StringLength(1)]
        public string Mnu_Status { get; set; }

        public string Mnu_LinkedPages { get; set; }

        [StringLength(10)]
        public string Mnu_ParentMenuId { get; set; }
    }
}
