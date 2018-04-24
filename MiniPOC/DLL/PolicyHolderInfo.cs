namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PolicyHolderInfo")]
    public partial class PolicyHolderInfo
    {
        public int PolicyHolderInfoId { get; set; }

        public int QuoteNo { get; set; }

        [StringLength(4)]
        public string Salutation { get; set; }

        [StringLength(100)]
        public string FName { get; set; }

        [StringLength(100)]
        public string MName { get; set; }

        [StringLength(100)]
        public string LName { get; set; }

        public DateTime? Dob { get; set; }

        [StringLength(1)]
        public string Sex { get; set; }

        [StringLength(1)]
        public string Marital { get; set; }

        public int? NationalityId { get; set; }

        [StringLength(1)]
        public string InfoType { get; set; }

        [StringLength(4)]
        public string Occupation { get; set; }

        public int? CountryOfBirth { get; set; }

        public virtual Mst_Nationality Mst_Nationality { get; set; }

        public virtual Mst_Nationality Mst_Nationality1 { get; set; }

        public virtual Mst_Salutation Mst_Salutation { get; set; }

        public virtual PolicyInfo PolicyInfo { get; set; }
    }
}
