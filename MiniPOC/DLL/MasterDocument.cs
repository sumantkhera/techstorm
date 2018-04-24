namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MasterDocument")]
    public partial class MasterDocument
    {
        public int MasterDocumentId { get; set; }

        [StringLength(100)]
        public string DocumentName { get; set; }

        public int? AgeFrom { get; set; }

        public int? AgeTo { get; set; }

        public int? SumInsuredFrom { get; set; }

        public int? SumInsuredTo { get; set; }

        [StringLength(5)]
        public string Coverage { get; set; }

        public DateTime? DateAdded { get; set; }

        public DateTime? DateModified { get; set; }

        [StringLength(10)]
        public string UserId { get; set; }
    }
}
