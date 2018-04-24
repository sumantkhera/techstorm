namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClaimMortgage")]
    public partial class ClaimMortgage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ClaimNo { get; set; }

        [StringLength(200)]
        public string EmployerName { get; set; }

        [StringLength(200)]
        public string ClaimantName { get; set; }

        [StringLength(100)]
        public string HousNo { get; set; }

        [StringLength(100)]
        public string Country { get; set; }

        [StringLength(100)]
        public string Zone { get; set; }

        [StringLength(100)]
        public string Area { get; set; }

        [StringLength(100)]
        public string Block { get; set; }

        [StringLength(100)]
        public string Risk { get; set; }

        [StringLength(50)]
        public string Zip { get; set; }

        [StringLength(50)]
        public string EmploymentType { get; set; }

        public DateTime? EmploymentStartDate { get; set; }

        public DateTime? LastWorkingDate { get; set; }

        [StringLength(200)]
        public string ReasonForDiscontinue { get; set; }

        public DateTime? LayoffNotifyDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        [StringLength(5)]
        public string RecieveSurverance { get; set; }

        [StringLength(50)]
        public string Occupation { get; set; }

        [StringLength(20)]
        public string TypeOfPosition { get; set; }

        [StringLength(5)]
        public string HoursPerWeek { get; set; }

        public DateTime? SessionalFrom { get; set; }

        public DateTime? SessionalTo { get; set; }

        [StringLength(5)]
        public string WorkerCompensation { get; set; }

        [StringLength(500)]
        public string WorkerAddress { get; set; }

        [StringLength(50)]
        public string OtherPolicyNo { get; set; }

        [StringLength(100)]
        public string OtherCompName { get; set; }

        [StringLength(100)]
        public string OtherContactPerson { get; set; }

        [StringLength(20)]
        public string OtherTelephone { get; set; }

        [StringLength(500)]
        public string PrimaryDiagnosis { get; set; }

        [StringLength(500)]
        public string SecondaryDiagnosis { get; set; }

        [StringLength(5)]
        public string Complication { get; set; }

        [StringLength(500)]
        public string ComplicationDesc { get; set; }

        [StringLength(5)]
        public string Pregnancy { get; set; }

        public DateTime? ExpectedDate { get; set; }

        [StringLength(5)]
        public string TreatmentForDrugs { get; set; }

        [StringLength(500)]
        public string RehabilitationDesc { get; set; }

        [StringLength(500)]
        public string SurgeryDesc { get; set; }

        public DateTime? SurgeryDate { get; set; }

        [StringLength(4)]
        public string Disability { get; set; }

        [StringLength(500)]
        public string AnyFunctionalLimitaion { get; set; }

        [StringLength(5)]
        public string CapacityEvaluation { get; set; }

        [StringLength(500)]
        public string EvaluationTypeDesc { get; set; }

        public DateTime? EvaluationsDate { get; set; }

        public DateTime? SeveranceDate { get; set; }
    }
}
