namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mnu_Authority
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string Usr_Grp { get; set; }

        [StringLength(10)]
        public string Mnu_ProdCode { get; set; }

        [StringLength(10)]
        public string Mnu_ProdName { get; set; }

        [StringLength(10)]
        public string Mnu_Id { get; set; }

        [StringLength(10)]
        public string Mnu_Chgusr { get; set; }

        public DateTime? Mnu_Chgtime { get; set; }

        [StringLength(10)]
        public string UserID { get; set; }
    }
}
