namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_TrinreDetail
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string ModuleName { get; set; }

        [StringLength(50)]
        public string SubModuleName { get; set; }

        [StringLength(200)]
        public string CompanyName { get; set; }

        [Column(TypeName = "image")]
        public byte[] CompanyLogo { get; set; }

        [StringLength(200)]
        public string CompanyLogoPath { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        public bool? IsActive { get; set; }

        [StringLength(100)]
        public string ModifyBy { get; set; }

        public DateTime? ModifyDate { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        [StringLength(100)]
        public string CreatedDate { get; set; }
    }
}
