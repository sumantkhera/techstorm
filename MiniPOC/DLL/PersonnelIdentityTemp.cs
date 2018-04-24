namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PersonnelIdentityTemp")]
    public partial class PersonnelIdentityTemp
    {
        [Key]
        public int PersonIdentityID { get; set; }

        public int? PersonalInfoId { get; set; }

        public int? SequenceNo { get; set; }

        [StringLength(25)]
        public string IdentityVal { get; set; }

        public DateTime? Issue_Dt { get; set; }

        public DateTime? Expiry_Dt { get; set; }

        public int? PolicyDocId { get; set; }

        public bool? IsActive { get; set; }

        public int? PersonalInfoLicType { get; set; }

        public int? PersonalInfoLicenceClassId { get; set; }

        [StringLength(50)]
        public string Permit { get; set; }

        [StringLength(50)]
        public string Class { get; set; }

        [StringLength(4)]
        public string Country { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(500)]
        public string ClassValue { get; set; }

        public DateTime? Renew_Dt { get; set; }

        public virtual PersonalInfoTemp PersonalInfoTemp { get; set; }
    }
}
