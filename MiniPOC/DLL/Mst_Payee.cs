namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_Payee
    {
        [Key]
        public int PayeeID { get; set; }

        [StringLength(100)]
        public string Pye_Name { get; set; }

        public bool? Pye_IsActive { get; set; }

        [StringLength(4)]
        public string Pye_PayeeCode { get; set; }
    }
}
