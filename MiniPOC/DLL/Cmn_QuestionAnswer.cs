namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cmn_QuestionAnswer
    {
        [Key]
        public int AnsVID { get; set; }

        public int? Ans_QuoteNo { get; set; }

        public int? Ans_RelationId { get; set; }

        [StringLength(3)]
        public string Ans_RelationFlag { get; set; }

        public int? Ans_QuestionId { get; set; }

        [StringLength(10)]
        public string Ans_QuesCode { get; set; }

        public bool? Ans_YesNo { get; set; }

        [StringLength(200)]
        public string Ans_Details { get; set; }

        public int? Ans_ClaimNo { get; set; }

        public int? PersonalInfoId { get; set; }

        public virtual Mst_Question Mst_Question { get; set; }

        public virtual PolicyInfo PolicyInfo { get; set; }
    }
}
