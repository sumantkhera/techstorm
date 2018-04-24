namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MasterDisease")]
    public partial class MasterDisease
    {
        [Key]
        public int DiseaseId { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public bool? IsActive { get; set; }

        [StringLength(10)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string DiseaseDetail { get; set; }
    }
}
