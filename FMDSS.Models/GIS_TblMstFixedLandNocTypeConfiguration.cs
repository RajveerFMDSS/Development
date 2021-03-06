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

    // tbl_mst_FixedLand_NOCTypes
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class GIS_TblMstFixedLandNocTypeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<GIS_TblMstFixedLandNocType>
    {
        public GIS_TblMstFixedLandNocTypeConfiguration()
            : this("GIS")
        {
        }

        public GIS_TblMstFixedLandNocTypeConfiguration(string schema)
        {
            ToTable("tbl_mst_FixedLand_NOCTypes", schema);
            HasKey(x => x.NocTypeId);

            Property(x => x.NocTypeId).HasColumnName(@"NOCTypeId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NocTypeName).HasColumnName(@"NOCTypeName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.IsActive).HasColumnName(@"IsActive").HasColumnType("bit").IsOptional();
        }
    }

}
// </auto-generated>
