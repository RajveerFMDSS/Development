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

    // tbl_ZooPlaceWiseHead
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class Master_TblZooPlaceWiseHeadConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Master_TblZooPlaceWiseHead>
    {
        public Master_TblZooPlaceWiseHeadConfiguration()
            : this("Master")
        {
        }

        public Master_TblZooPlaceWiseHeadConfiguration(string schema)
        {
            ToTable("tbl_ZooPlaceWiseHead", schema);
            HasKey(x => x.ZooPlaceWiseHeadId);

            Property(x => x.ZooPlaceWiseHeadId).HasColumnName(@"ZooPlaceWiseHeadId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PlaceId).HasColumnName(@"PlaceId").HasColumnType("bigint").IsRequired();
            Property(x => x.FeeChargedOn).HasColumnName(@"FeeChargedOn").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.HeadId).HasColumnName(@"HeadId").HasColumnType("int").IsRequired();
            Property(x => x.HeadAmount).HasColumnName(@"HeadAmount").HasColumnType("decimal").IsOptional().HasPrecision(16,0);
            Property(x => x.Type).HasColumnName(@"Type").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(10);
            Property(x => x.IsActive).HasColumnName(@"isActive").HasColumnType("bit").IsRequired();
            Property(x => x.ParentFeeChangeOn).HasColumnName(@"ParentFeeChangeON").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
        }
    }

}
// </auto-generated>
