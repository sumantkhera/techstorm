namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AddressTemp")]
    public partial class AddressTemp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AddressTemp()
        {
            PersonalInfoTemps = new HashSet<PersonalInfoTemp>();
            PersonalInfoTemps1 = new HashSet<PersonalInfoTemp>();
        }

        public int Id { get; set; }

        public int? QuoteNo { get; set; }

        [StringLength(1000)]
        public string StreetNumber { get; set; }

        [StringLength(1000)]
        public string Address2 { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(50)]
        public string Zone { get; set; }

        [StringLength(50)]
        public string Area { get; set; }

        [StringLength(50)]
        public string Block { get; set; }

        [StringLength(50)]
        public string Risk { get; set; }

        [StringLength(50)]
        public string Zip { get; set; }

        public bool? IsActive { get; set; }

        public int? PersonalInfoId { get; set; }

        [StringLength(4)]
        public string CountryId { get; set; }

        public int? ZoneId { get; set; }

        public int? AreaId { get; set; }

        public int? BlockId { get; set; }

        public int? RiskId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonalInfoTemp> PersonalInfoTemps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonalInfoTemp> PersonalInfoTemps1 { get; set; }
    }
}
