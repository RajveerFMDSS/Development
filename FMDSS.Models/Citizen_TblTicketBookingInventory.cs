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

    // tbl_TicketBooking_Inventory
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class Citizen_TblTicketBookingInventory
    {
        public long Id { get; set; } // ID (Primary key)
        public System.DateTime? SDate { get; set; } // sDate
        public int? VehicalId { get; set; } // VehicalID
        public int? ShiftTime { get; set; } // ShiftTime
        public int? CitizenMaxSeat { get; set; } // CitizenMaxSeat
        public int? CitizenBookedSeat { get; set; } // CitizenBookedSeat
        public int? KioskMaxSeat { get; set; } // KioskMaxSeat
        public int? KioskBookedSeat { get; set; } // KioskBookedSeat
    }

}
// </auto-generated>