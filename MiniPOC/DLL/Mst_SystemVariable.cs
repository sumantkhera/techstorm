namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_SystemVariable
    {
        [Key]
        public int KeyID { get; set; }

        [StringLength(50)]
        public string KeyCode { get; set; }

        [StringLength(50)]
        public string KeyName { get; set; }

        [StringLength(20)]
        public string KeyMinValue { get; set; }

        public string KeyMaxValue { get; set; }

        [StringLength(4)]
        public string ProposalCode { get; set; }

        [StringLength(50)]
        public string MasterTable { get; set; }

        public bool IsPolicyWise { get; set; }

        public bool IsActive { get; set; }

        public DateTime? TransDate { get; set; }

        public virtual Mst_Proposal Mst_Proposal { get; set; }
    }
}
