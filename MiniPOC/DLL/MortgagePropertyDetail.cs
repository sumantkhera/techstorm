namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MortgagePropertyDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QuoteNo { get; set; }

        [StringLength(500)]
        public string PurposeOfLoan { get; set; }

        [StringLength(500)]
        public string HouseNumber { get; set; }

        [StringLength(50)]
        public string Area { get; set; }

        [StringLength(50)]
        public string Block { get; set; }

        [StringLength(50)]
        public string Zone { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(50)]
        public string Risk { get; set; }

        [StringLength(50)]
        public string ZipCode { get; set; }

        [StringLength(5)]
        public string NoOfBedrooms { get; set; }

        [StringLength(5)]
        public string NoOfDiningrooms { get; set; }

        [StringLength(5)]
        public string NoofLivingrooms { get; set; }

        [StringLength(5)]
        public string OtherRooms { get; set; }

        [StringLength(5)]
        public string NoOfFloors { get; set; }

        [StringLength(2)]
        public string PropertyType { get; set; }

        [StringLength(50)]
        public string LeasedTerm { get; set; }

        [StringLength(50)]
        public string UnexpiredTerm { get; set; }

        [StringLength(50)]
        public string LeasedRent { get; set; }

        [StringLength(50)]
        public string RestrictiveCovenents { get; set; }

        public bool? LeasedRenew { get; set; }

        [StringLength(50)]
        public string RenewTerm { get; set; }

        public bool? PesentlyMortgaged { get; set; }

        [StringLength(50)]
        public string MortgagedBank { get; set; }

        public decimal? MortgagedAmtOutstanding { get; set; }

        public decimal? MortgagedROI { get; set; }

        public decimal? MortgagedEMI { get; set; }

        public DateTime? MortgagedMaturityDate { get; set; }

        [StringLength(50)]
        public string MortgagedTitleHolder { get; set; }

        [StringLength(2)]
        public string BudlingGive { get; set; }

        [StringLength(50)]
        public string AreaLot { get; set; }

        [StringLength(50)]
        public string AreaBuilding { get; set; }

        public decimal? ProposedPurchasePrice { get; set; }

        public decimal? TotalCostBuilding { get; set; }

        public decimal? CashPaid { get; set; }

        public decimal? TotalLotCost { get; set; }

        [StringLength(5)]
        public string LandTaxPaidYear { get; set; }

        [StringLength(5)]
        public string WaterTaxPaidYear { get; set; }

        public DateTime? CompletionDateOfContract { get; set; }

        public decimal? CostOfLotPsf { get; set; }

        public decimal? EstimatedCostBuildingPsf { get; set; }

        public decimal? TotalEstimatedCost { get; set; }

        public bool? BuildingPlan { get; set; }

        [StringLength(50)]
        public string BuildingPlanNo { get; set; }

        [StringLength(50)]
        public string PlanAuthorityName { get; set; }

        public DateTime? PlanAprovalDate { get; set; }

        public bool? FixedPriceContract { get; set; }

        [StringLength(50)]
        public string ArchitectName { get; set; }

        [StringLength(500)]
        public string ArchitectAddress { get; set; }

        [StringLength(200)]
        public string Engineers { get; set; }

        [StringLength(50)]
        public string Builders { get; set; }

        [StringLength(10)]
        public string SurveyorQuantity { get; set; }

        public DateTime? EstimatedCompletionDate { get; set; }

        public bool? OccupyBuilding { get; set; }

        [StringLength(50)]
        public string BuildingtobeUsed { get; set; }

        public decimal? EstimatedMOnthlyRental { get; set; }

        public decimal? EstimatedInsuredValue { get; set; }

        [StringLength(5)]
        public string Bathrooms { get; set; }
    }
}
