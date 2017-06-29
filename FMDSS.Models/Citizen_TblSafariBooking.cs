// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.5
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace FMDSS.Models
{

    // tbl_SafariBooking
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class Citizen_TblSafariBooking
    {
        public long Id { get; set; } // ID (Primary key)
        public long? TicketId { get; set; } // TicketID
        public long? VehicleCatId { get; set; } // VehicleCatID
        public long? VehicleId { get; set; } // VehicleID
        public int? TotalBookedSeat { get; set; } // TotalBookedSeat
        public System.DateTime? ArrivalDate { get; set; } // ArrivalDate
        public decimal? TotalFees { get; set; } // TotalFees
        public int? IsActive { get; set; } // IsActive
        public System.DateTime? EnteredOn { get; set; } // EnteredOn
        public long? EnteredBy { get; set; } // EnteredBy
        public System.DateTime? UpdatedOn { get; set; } // UpdatedOn
        public long? UpdatedBy { get; set; } // UpdatedBy

        // Foreign keys

        /// <summary>
        /// Parent Master_TblMstVehicleEquipment pointed by [tbl_SafariBooking].([VehicleCatId]) (FK_VehicleCatID)
        /// </summary>
        public virtual Master_TblMstVehicleEquipment Master_TblMstVehicleEquipment { get; set; } // FK_VehicleCatID
        /// <summary>
        /// Parent Master_TblMstVehicleEquipmentFee pointed by [tbl_SafariBooking].([VehicleId]) (FK_VehicleID)
        /// </summary>
        public virtual Master_TblMstVehicleEquipmentFee Master_TblMstVehicleEquipmentFee { get; set; } // FK_VehicleID

        public Citizen_TblSafariBooking()
        {
            IsActive = 1;
            EnteredOn = System.DateTime.Now;
        }
    }

}
// </auto-generated>