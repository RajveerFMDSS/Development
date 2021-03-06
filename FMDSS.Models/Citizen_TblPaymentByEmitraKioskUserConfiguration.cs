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

    // tbl_PaymentByEmitraKioskUser
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class Citizen_TblPaymentByEmitraKioskUserConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Citizen_TblPaymentByEmitraKioskUser>
    {
        public Citizen_TblPaymentByEmitraKioskUserConfiguration()
            : this("Citizen")
        {
        }

        public Citizen_TblPaymentByEmitraKioskUserConfiguration(string schema)
        {
            ToTable("tbl_PaymentByEmitraKioskUser", schema);
            HasKey(x => x.RowId);

            Property(x => x.RowId).HasColumnName(@"RowId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ModuleId).HasColumnName(@"ModuleId").HasColumnType("int").IsOptional();
            Property(x => x.ServiceTypeId).HasColumnName(@"ServiceTypeId").HasColumnType("int").IsOptional();
            Property(x => x.PermissionId).HasColumnName(@"PermissionId").HasColumnType("int").IsOptional();
            Property(x => x.SubpermissionId).HasColumnName(@"SubpermissionId").HasColumnType("int").IsOptional();
            Property(x => x.RequestedId).HasColumnName(@"RequestedId").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.TotalPaidAmount).HasColumnName(@"TotalPaidAmount").HasColumnType("decimal").IsOptional().HasPrecision(18,0);
            Property(x => x.EmitraAmount).HasColumnName(@"EmitraAmount").HasColumnType("decimal").IsOptional().HasPrecision(18,0);
            Property(x => x.EnteredDate).HasColumnName(@"EnteredDate").HasColumnType("datetime").IsOptional();
        }
    }

}
// </auto-generated>
