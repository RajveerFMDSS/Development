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

    // tbl_Mst_FixedPermission_PlantMapping
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class GIS_TblMstFixedPermissionPlantMappingConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<GIS_TblMstFixedPermissionPlantMapping>
    {
        public GIS_TblMstFixedPermissionPlantMappingConfiguration()
            : this("GIS")
        {
        }

        public GIS_TblMstFixedPermissionPlantMappingConfiguration(string schema)
        {
            ToTable("tbl_Mst_FixedPermission_PlantMapping", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RequestedId).HasColumnName(@"RequestedID").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.PlantId).HasColumnName(@"PlantID").HasColumnType("int").IsOptional();
            Property(x => x.NumberTrees).HasColumnName(@"Number_Trees").HasColumnType("int").IsOptional();
            Property(x => x.EnteredOn).HasColumnName(@"EnteredOn").HasColumnType("datetime").IsOptional();

            // Foreign keys
            HasOptional(a => a.GIS_TblMstFixedPermissionPlant).WithMany(b => b.GIS_TblMstFixedPermissionPlantMappings).HasForeignKey(c => c.PlantId).WillCascadeOnDelete(false); // FK_tbl_Mst_FixedPermission_PlantMapping_tbl_Mst_FixedPermission_Plant
        }
    }

}
// </auto-generated>