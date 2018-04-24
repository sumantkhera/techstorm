namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_CreditRating
    {
        [Key]
        public int CRDID { get; set; }

        public int? CRD_VAL { get; set; }

        [StringLength(20)]
        public string CRD_NAME { get; set; }

        [StringLength(5)]
        public string CRD_PROPCODE { get; set; }

        public bool? CRD_ISACTIVE { get; set; }

        [StringLength(10)]
        public string CRD_MODIFIEDBY { get; set; }

        public DateTime? CRD_MODIFIEDDATE { get; set; }
    }
}
