namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_Occupation
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string OccupationCode { get; set; }

        [StringLength(50)]
        public string Ocu_Name { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string Ocu_Type { get; set; }

        [StringLength(1)]
        public string Ocu_Status { get; set; }

        [StringLength(10)]
        public string Ocu_LastModifyBy { get; set; }

        public DateTime? Ocu_LastModifyDate { get; set; }
    }
}
