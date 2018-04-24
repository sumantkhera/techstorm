namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExcelInformation")]
    public partial class ExcelInformation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExcelInformation()
        {
            PersonalInfoTemps = new HashSet<PersonalInfoTemp>();
            PolicyInfoTemps = new HashSet<PolicyInfoTemp>();
        }

        public int Id { get; set; }

        [StringLength(250)]
        public string FileName { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? Active { get; set; }

        public string Description { get; set; }

        [StringLength(150)]
        public string User { get; set; }

        public int? QuoteNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonalInfoTemp> PersonalInfoTemps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyInfoTemp> PolicyInfoTemps { get; set; }
    }
}
