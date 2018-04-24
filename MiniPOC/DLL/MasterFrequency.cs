namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MasterFrequency")]
    public partial class MasterFrequency
    {
        [Key]
        [StringLength(3)]
        public string FrequencyCode { get; set; }

        [StringLength(20)]
        public string FrequencyName { get; set; }

        [StringLength(1)]
        public string FrequencyType { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(10)]
        public string ModifiedBy { get; set; }
    }
}
