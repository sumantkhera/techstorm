namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PolicyInfoTemp")]
    public partial class PolicyInfoTemp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PolicyInfoTemp()
        {
            PersonalInfoTemps = new HashSet<PersonalInfoTemp>();
            PolicyCoverTemps = new HashSet<PolicyCoverTemp>();
        }

        public int Id { get; set; }

        [StringLength(100)]
        public string PolicyHolder { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [StringLength(200)]
        public string EmailAddress { get; set; }

        [StringLength(100)]
        public string BrokerName { get; set; }

        public int ExcelId { get; set; }

        [StringLength(50)]
        public string PolicyNumber { get; set; }

        public virtual ExcelInformation ExcelInformation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonalInfoTemp> PersonalInfoTemps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyCoverTemp> PolicyCoverTemps { get; set; }
    }
}
