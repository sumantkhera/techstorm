namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Audit_History
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string TableName { get; set; }

        public string OldValue { get; set; }

        public string NewValue { get; set; }

        public DateTime? DateModified { get; set; }

        [StringLength(1)]
        public string ModeOfOperation { get; set; }

        [StringLength(50)]
        public string ColumnName { get; set; }

        [StringLength(50)]
        public string UserId { get; set; }
    }
}
