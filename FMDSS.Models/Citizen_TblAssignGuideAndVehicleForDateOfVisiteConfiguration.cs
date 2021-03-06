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
    public class Citizen_TblAssignGuideAndVehicleForDateOfVisiteConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Citizen_TblAssignGuideAndVehicleForDateOfVisite>
    {
        public Citizen_TblAssignGuideAndVehicleForDateOfVisiteConfiguration()
            : this("Citizen")
        {
        }

        public Citizen_TblAssignGuideAndVehicleForDateOfVisiteConfiguration(string schema)
        {
            ToTable("tbl_AssignGuideAndVehicleForDateOfVisite", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.DateOfVisite).HasColumnName(@"DateOfVisite").HasColumnType("datetime").IsRequired();
            Property(x => x.PlaceId).HasColumnName(@"PlaceID").HasColumnType("int").IsRequired();
            Property(x => x.ShiftType).HasColumnName(@"ShiftType").HasColumnType("int").IsRequired();
            Property(x => x.GuideName).HasColumnName(@"GuideName").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.VehicleNumber).HasColumnName(@"VehicleNumber").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.VehicalEqptName).HasColumnName(@"VehicalEqptName").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Isactive).HasColumnName(@"Isactive").HasColumnType("bit").IsRequired();
            Property(x => x.EnteredOn).HasColumnName(@"EnteredOn").HasColumnType("datetime").IsOptional();
            Property(x => x.EnteredBy).HasColumnName(@"EnteredBy").HasColumnType("bigint").IsOptional();
            Property(x => x.UpdatedOn).HasColumnName(@"UpdatedOn").HasColumnType("datetime").IsOptional();
            Property(x => x.UpdatedBy).HasColumnName(@"UpdatedBy").HasColumnType("bigint").IsOptional();
            Property(x => x.Gvid).HasColumnName(@"GVID").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(10);
        }
    }

}
// </auto-generated>
