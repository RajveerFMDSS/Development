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

    // tbl_ZooVehicleDetails
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class Citizen_TblZooVehicleDetail
    {
        public long ZooVehicleId { get; set; } // ZooVehicleId (Primary key)
        public long BookingId { get; set; } // BookingId
        public string VehicleType { get; set; } // VehicleType (length: 50)
        public int? FeePerVehicle { get; set; } // FeePerVehicle
        public int? NoOfVehicle { get; set; } // NoOfVehicle
        public decimal? TotalVehicleFee { get; set; } // TotalVehicleFee

        public Citizen_TblZooVehicleDetail()
        {
            BookingId = 0;
            VehicleType = "0";
            FeePerVehicle = 0;
            NoOfVehicle = 0;
            TotalVehicleFee = 0m;
        }
    }

}
// </auto-generated>
