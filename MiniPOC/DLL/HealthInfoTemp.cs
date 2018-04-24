namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HealthInfoTemp")]
    public partial class HealthInfoTemp
    {
        [Key]
        public int HealthInfoId { get; set; }

        public int QuoteNo { get; set; }

        [StringLength(200)]
        public string CurInsuranceName { get; set; }

        [StringLength(100)]
        public string CurMemberID { get; set; }

        public DateTime? CurEffectiveDate { get; set; }

        [StringLength(200)]
        public string PrevInsuranceName { get; set; }

        [StringLength(100)]
        public string PrevMemberID { get; set; }

        public DateTime? PrevEffectiveDate { get; set; }

        public DateTime? PrevTerminationDate { get; set; }

        [StringLength(500)]
        public string PrevTerminationReason { get; set; }

        [StringLength(200)]
        public string LocalPhysician { get; set; }

        [StringLength(500)]
        public string LocalPhysicianAddress { get; set; }

        [StringLength(50)]
        public string LocPhysicianTel { get; set; }

        [StringLength(200)]
        public string OversPhysician { get; set; }

        [StringLength(500)]
        public string OverPhysianAddress { get; set; }

        [StringLength(50)]
        public string OverPhysicianTel { get; set; }
    }
}
