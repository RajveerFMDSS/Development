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

    // tbl_TicketBooking
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class Citizen_TblTicketBooking
    {
        public long TicketId { get; set; } // TicketID (Primary key)
        public string RequestId { get; set; } // RequestID (length: 50)
        public long PlaceId { get; set; } // PlaceID
        public long ZoneId { get; set; } // ZoneID
        public string ShiftTime { get; set; } // ShiftTime (length: 20)
        public System.DateTime DateOfArrival { get; set; } // DateOfArrival
        public int TotalMembers { get; set; } // TotalMembers
        public decimal TotalFees { get; set; } // TotalFees
        public decimal TaxRate { get; set; } // TaxRate
        public decimal AmountTobePaid { get; set; } // AmountTobePaid
        public int? TrnStatusCode { get; set; } // Trn_Status_Code
        public long? EmitraTransactionId { get; set; } // EmitraTransactionID
        public int? Isactive { get; set; } // Isactive
        public System.DateTime? EnteredOn { get; set; } // EnteredOn
        public long? EnteredBy { get; set; } // EnteredBy
        public System.DateTime? UpdatedOn { get; set; } // UpdatedOn
        public long? UpdatedBy { get; set; } // UpdatedBy
        public long? KioskUserId { get; set; } // KioskUserId
        public string IpAddress { get; set; } // IP_ADDRESS (length: 20)
        public bool? ManualStatus { get; set; } // Manual_Status
        public string ManualRemarks { get; set; } // Manual_Remarks (length: 500)
        public double? AmountWithServiceCharges { get; set; } // AmountWithServiceCharges
        public double? EMitraAmount { get; set; } // EMitraAmount
        public decimal EmitraCharges { get; set; } // EmitraCharges
        public decimal Tax { get; set; } // tax
        public string ReserveStatus { get; set; } // Reserve_Status (length: 10)
        public string SsoToken { get; set; } // SsoToken (length: 100)
        public short TotalMemberBeforeBoarding { get; set; } // TotalMemberBeforeBoarding
        public string EmitraCalculationType { get; set; } // EmitraCalculationType (length: 20)

        public Citizen_TblTicketBooking()
        {
            RequestId = "";
            PlaceId = 0;
            ZoneId = 0;
            ShiftTime = "0";
            TotalMembers = 0;
            TotalFees = 0m;
            TaxRate = 0m;
            AmountTobePaid = 0m;
            Isactive = 1;
            EnteredOn = System.DateTime.Now;
            EmitraCharges = 0m;
            Tax = 0m;
            ReserveStatus = "R";
            TotalMemberBeforeBoarding = 0;
            EmitraCalculationType = "Flat";
        }
    }

}
// </auto-generated>
