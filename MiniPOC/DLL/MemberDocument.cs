namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MemberDocument
    {
        [Key]
        public int DocumentId { get; set; }

        public int QuoteNo { get; set; }

        public int PersonalInfoId { get; set; }

        public int Doc_CodeId { get; set; }

        [StringLength(100)]
        public string Doc_Name { get; set; }

        public bool? Doc_IsChecked { get; set; }

        public DateTime? Doc_ReviewDate { get; set; }

        public DateTime? Doc_AcceptedDate { get; set; }

        [StringLength(500)]
        public string Doc_FilePath { get; set; }

        public DateTime? Doc_TransDate { get; set; }
    }
}
