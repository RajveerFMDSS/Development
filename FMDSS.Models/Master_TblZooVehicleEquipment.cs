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

    // tbl_Zoo_VehicleEquipment
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class Master_TblZooVehicleEquipment
    {
        public int ZooVehicleId { get; set; } // ZooVehicleID (Primary key)
        public long CategoryId { get; set; } // CategoryID
        public string VehicleName { get; set; } // VehicleName (length: 200)
        public bool Isactive { get; set; } // Isactive

        // Reverse navigation

        /// <summary>
        /// Child Master_TblZooVehicleFees where [tbl_ZooVehicleFees].[ZooVehicleID] point to this entity (FK_tbl_ZooVehicleFees_tbl_Zoo_VehicleEquipment)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Master_TblZooVehicleFee> Master_TblZooVehicleFees { get; set; } // tbl_ZooVehicleFees.FK_tbl_ZooVehicleFees_tbl_Zoo_VehicleEquipment

        public Master_TblZooVehicleEquipment()
        {
            CategoryId = 0;
            Isactive = false;
            Master_TblZooVehicleFees = new System.Collections.Generic.List<Master_TblZooVehicleFee>();
        }
    }

}
// </auto-generated>
