namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_TradeGroup
    {
        [Key]
        public int Trd_Id { get; set; }

        [StringLength(1)]
        public string Trd_Code { get; set; }

        [StringLength(100)]
        public string Trd_Desc { get; set; }

        [StringLength(1)]
        public string Trd_IsActive { get; set; }

        [StringLength(10)]
        public string Trd_LastModifyBy { get; set; }

        public DateTime? Trd_LastModifyDate { get; set; }
    }
}
