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

    // tbl_mst_Eqpt_SanctuariesFee
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class Master_TblMstEqptSanctuariesFee
    {
        public long Id { get; set; } // ID (Primary key)
        public long PlaceId { get; set; } // PlaceID
        public long ZoneId { get; set; } // ZoneID
        public string ShiftTypeId { get; set; } // ShiftTypeID (length: 50)
        public long VehicleCategoryId { get; set; } // VehicleCategoryID
        public long VehicleCategoryNameId { get; set; } // VehicleCategoryNameID
        public int TotalEqptAvailability { get; set; } // TotalEqptAvailability
        public int SeatsPerEqpt { get; set; } // SeatsPerEqpt
        public int IsActive { get; set; } // IsActive
        public int TotalSeats { get; set; } // TotalSeats
        public int SeatsForCitizen { get; set; } // seatsForCitizen
        public System.DateTime EnteredOn { get; set; } // EnteredOn
        public long EnteredBy { get; set; } // EnteredBy

        // Foreign keys

        /// <summary>
        /// Parent Master_TblMstPlace pointed by [tbl_mst_Eqpt_SanctuariesFee].([PlaceId]) (FK_Place)
        /// </summary>
        public virtual Master_TblMstPlace Master_TblMstPlace { get; set; } // FK_Place
        /// <summary>
        /// Parent Master_TblMstVehicleEquipment pointed by [tbl_mst_Eqpt_SanctuariesFee].([VehicleCategoryId]) (FK_VehicleCategoryID)
        /// </summary>
        public virtual Master_TblMstVehicleEquipment Master_TblMstVehicleEquipment { get; set; } // FK_VehicleCategoryID
        /// <summary>
        /// Parent Master_TblMstVehicleEquipmentFee pointed by [tbl_mst_Eqpt_SanctuariesFee].([Id]) (FK_VehicleCategoryNameID)
        /// </summary>
        public virtual Master_TblMstVehicleEquipmentFee Master_TblMstVehicleEquipmentFee { get; set; } // FK_VehicleCategoryNameID

        public Master_TblMstEqptSanctuariesFee()
        {
            PlaceId = 0;
            ZoneId = 0;
            ShiftTypeId = "";
            VehicleCategoryId = 0;
            VehicleCategoryNameId = 0;
            TotalEqptAvailability = 0;
            SeatsPerEqpt = 0;
            IsActive = 1;
            TotalSeats = 0;
            SeatsForCitizen = 0;
            EnteredOn = System.DateTime.Now;
            EnteredBy = 0;
        }
    }

}
// </auto-generated>
