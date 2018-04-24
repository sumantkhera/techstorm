namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_Receipt_Range
    {
        [Key]
        public int Rng_ID { get; set; }

        [StringLength(20)]
        public string Rng_Name { get; set; }

        [StringLength(2)]
        public string Rng_Code { get; set; }

        public int? Rng_Start { get; set; }

        public int? Rng_Current { get; set; }

        public int? Rng_End { get; set; }
    }
}
