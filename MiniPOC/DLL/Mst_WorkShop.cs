namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_WorkShop
    {
        [Key]
        public int WrkId { get; set; }

        [StringLength(100)]
        public string Wrk_Name { get; set; }

        [StringLength(50)]
        public string Wrk_Country { get; set; }

        [StringLength(1000)]
        public string Wrk_Address1 { get; set; }

        public int? Wrk_ZoneId { get; set; }

        public int? Wrk_AreaId { get; set; }

        public int? Wrk_BlockId { get; set; }

        public int? Wrk_RiskId { get; set; }

        [StringLength(1)]
        public string Wrk_Status { get; set; }

        [StringLength(100)]
        public string Wrk_LastModifiedBy { get; set; }

        public DateTime? Wrk_LastModifiedDate { get; set; }

        public virtual Mst_AddressArea Mst_AddressArea { get; set; }

        public virtual Mst_AddressBlock Mst_AddressBlock { get; set; }

        public virtual Mst_AddressRisk Mst_AddressRisk { get; set; }

        public virtual Mst_AddressZone Mst_AddressZone { get; set; }
    }
}
