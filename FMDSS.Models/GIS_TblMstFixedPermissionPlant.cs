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

    // tbl_Mst_FixedPermission_Plant
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class GIS_TblMstFixedPermissionPlant
    {
        public int Id { get; set; } // ID (Primary key)
        public string PlantName { get; set; } // Plant_Name (length: 10)
        public bool? IsActive { get; set; } // IsActive

        // Reverse navigation

        /// <summary>
        /// Child GIS_TblMstFixedPermissionPlantMappings where [tbl_Mst_FixedPermission_PlantMapping].[PlantID] point to this entity (FK_tbl_Mst_FixedPermission_PlantMapping_tbl_Mst_FixedPermission_Plant)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<GIS_TblMstFixedPermissionPlantMapping> GIS_TblMstFixedPermissionPlantMappings { get; set; } // tbl_Mst_FixedPermission_PlantMapping.FK_tbl_Mst_FixedPermission_PlantMapping_tbl_Mst_FixedPermission_Plant

        public GIS_TblMstFixedPermissionPlant()
        {
            IsActive = true;
            GIS_TblMstFixedPermissionPlantMappings = new System.Collections.Generic.List<GIS_TblMstFixedPermissionPlantMapping>();
        }
    }

}
// </auto-generated>
