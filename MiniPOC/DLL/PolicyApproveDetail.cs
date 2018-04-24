namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PolicyApproveDetail
    {
        public int Id { get; set; }

        public int QuoteNo { get; set; }

        [StringLength(20)]
        public string ApproveUserId { get; set; }

        [StringLength(2)]
        public string ApproveStatus { get; set; }

        [StringLength(1000)]
        public string ApproveComments { get; set; }

        [StringLength(20)]
        public string AgentId { get; set; }

        public DateTime ApproveDate { get; set; }
    }
}
