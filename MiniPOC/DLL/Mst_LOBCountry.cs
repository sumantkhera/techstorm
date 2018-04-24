namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_LOBCountry
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string Country_LOB { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string Country_LOBCountry { get; set; }

        public virtual Mst_LOB Mst_LOB { get; set; }
    }
}
