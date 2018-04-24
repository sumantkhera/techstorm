namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MstClaimLimitation")]
    public partial class MstClaimLimitation
    {
        [Key]
        public int LimitationID { get; set; }

        [StringLength(100)]
        public string LimitationName { get; set; }
    }
}
