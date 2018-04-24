namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mst_EndorsementType
    {
        [Key]
        [StringLength(5)]
        public string Endorse_code { get; set; }

        [StringLength(100)]
        public string Endorse_reason { get; set; }

        [StringLength(100)]
        public string type_desc1 { get; set; }

        [StringLength(100)]
        public string type_desc2 { get; set; }

        [StringLength(100)]
        public string type_desc3 { get; set; }

        [StringLength(100)]
        public string type_desc4 { get; set; }

        [StringLength(100)]
        public string type_desc5 { get; set; }

        [StringLength(1)]
        public string endorse_type { get; set; }

        [StringLength(1)]
        public string endorse_businessLine { get; set; }

        [StringLength(1)]
        public string endorse_status { get; set; }

        [StringLength(50)]
        public string Endorse_LastModifyBy { get; set; }

        public DateTime? Endorse_LastModifyDate { get; set; }
    }
}
