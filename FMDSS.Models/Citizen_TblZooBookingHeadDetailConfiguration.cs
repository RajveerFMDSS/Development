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

    // tbl_ZooBookingHeadDetails
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class Citizen_TblZooBookingHeadDetailConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Citizen_TblZooBookingHeadDetail>
    {
        public Citizen_TblZooBookingHeadDetailConfiguration()
            : this("Citizen")
        {
        }

        public Citizen_TblZooBookingHeadDetailConfiguration(string schema)
        {
            ToTable("tbl_ZooBookingHeadDetails", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RequestId).HasColumnName(@"RequestId").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.HeadId).HasColumnName(@"HeadId").HasColumnType("int").IsRequired();
            Property(x => x.FeeChargedOn).HasColumnName(@"FeeChargedOn").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.ParentFeeChargeOn).HasColumnName(@"ParentFeeChargeOn").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.InsertDate).HasColumnName(@"InsertDate").HasColumnType("datetime").IsRequired();
            Property(x => x.HeadAmount).HasColumnName(@"HeadAmount").HasColumnType("decimal").IsRequired().HasPrecision(18,2);
            Property(x => x.Counts).HasColumnName(@"Counts").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
