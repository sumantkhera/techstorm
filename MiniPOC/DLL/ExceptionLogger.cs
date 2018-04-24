namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExceptionLogger")]
    public partial class ExceptionLogger
    {
        public int Id { get; set; }

        public int? UserId { get; set; }

        [StringLength(50)]
        public string IP { get; set; }

        [StringLength(100)]
        public string Type { get; set; }

        public string ExceptionMessage { get; set; }

        [StringLength(200)]
        public string ControllerName { get; set; }

        public string ExceptionStackTrace { get; set; }

        public DateTime? LogTime { get; set; }
    }
}
