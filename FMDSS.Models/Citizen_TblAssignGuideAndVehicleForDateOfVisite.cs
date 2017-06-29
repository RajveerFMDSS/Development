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

    // tbl_AssignGuideAndVehicleForDateOfVisite
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class Citizen_TblAssignGuideAndVehicleForDateOfVisite
    {
        public long Id { get; set; } // ID (Primary key)
        public System.DateTime DateOfVisite { get; set; } // DateOfVisite
        public int PlaceId { get; set; } // PlaceID
        public int ShiftType { get; set; } // ShiftType
        public string GuideName { get; set; } // GuideName (length: 200)
        public string VehicleNumber { get; set; } // VehicleNumber (length: 20)
        public string VehicalEqptName { get; set; } // VehicalEqptName (length: 20)
        public bool Isactive { get; set; } // Isactive
        public System.DateTime? EnteredOn { get; set; } // EnteredOn
        public long? EnteredBy { get; set; } // EnteredBy
        public System.DateTime? UpdatedOn { get; set; } // UpdatedOn
        public long? UpdatedBy { get; set; } // UpdatedBy
        public string Gvid { get; set; } // GVID (length: 10)
    }

}
// </auto-generated>