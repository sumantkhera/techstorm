namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Claim_ItemsCoveredType
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string Clm_ItemsCoveredValue { get; set; }

        [StringLength(500)]
        public string Clm_ItemsCoveredText { get; set; }

        [StringLength(50)]
        public string Type { get; set; }
    }
}
