namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_Expense
    {
        public int ID { get; set; }

        [StringLength(2)]
        public string ExpenseCode { get; set; }

        [StringLength(100)]
        public string ExpenseDesc { get; set; }

        [StringLength(1)]
        public string Status { get; set; }

        [StringLength(100)]
        public string LastModifyBy { get; set; }

        public DateTime? LastModifyDate { get; set; }
    }
}
