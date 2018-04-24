namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_ReviewedDocument
    {
        [Key]
        [StringLength(4)]
        public string Review_Code { get; set; }

        [StringLength(50)]
        public string Review_Description { get; set; }

        [StringLength(1)]
        public string Review_Status { get; set; }

        [StringLength(10)]
        public string Review_LastModifyBy { get; set; }

        public DateTime? Review_LastModifyDate { get; set; }
    }
}
