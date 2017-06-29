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

    // tbl_PaymentByEmitraKioskUser
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class Citizen_TblPaymentByEmitraKioskUser
    {
        public int RowId { get; set; } // RowId (Primary key)
        public int? ModuleId { get; set; } // ModuleId
        public int? ServiceTypeId { get; set; } // ServiceTypeId
        public int? PermissionId { get; set; } // PermissionId
        public int? SubpermissionId { get; set; } // SubpermissionId
        public string RequestedId { get; set; } // RequestedId (length: 50)
        public decimal? TotalPaidAmount { get; set; } // TotalPaidAmount
        public decimal? EmitraAmount { get; set; } // EmitraAmount
        public System.DateTime? EnteredDate { get; set; } // EnteredDate
    }

}
// </auto-generated>
