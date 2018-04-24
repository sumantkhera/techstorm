namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_ClaimLossCause
    {
        [Key]
        public int Clm_LossID { get; set; }

        [StringLength(4)]
        public string Clm_PropCode { get; set; }

        [StringLength(100)]
        public string Clm_LossDesc { get; set; }

        [StringLength(10)]
        public string Clm_Status { get; set; }

        [StringLength(10)]
        public string Clm_ModifyBy { get; set; }

        public DateTime? Clm_ModifyDate { get; set; }

        public virtual Mst_Proposal Mst_Proposal { get; set; }
    }
}
