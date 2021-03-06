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

    // tbl_mst_TicketingFees
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class Master_TblMstTicketingFeeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Master_TblMstTicketingFee>
    {
        public Master_TblMstTicketingFeeConfiguration()
            : this("Master")
        {
        }

        public Master_TblMstTicketingFeeConfiguration(string schema)
        {
            ToTable("tbl_mst_TicketingFees", schema);
            HasKey(x => x.FeesId);

            Property(x => x.FeesId).HasColumnName(@"FeesID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.DistCode).HasColumnName(@"DIST_CODE").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.PlaceId).HasColumnName(@"PlaceID").HasColumnType("bigint").IsRequired();
            Property(x => x.Isactive).HasColumnName(@"Isactive").HasColumnType("int").IsOptional();
            Property(x => x.EnteredOn).HasColumnName(@"EnteredOn").HasColumnType("datetime").IsOptional();
            Property(x => x.EnteredBy).HasColumnName(@"EnteredBy").HasColumnType("bigint").IsOptional();
            Property(x => x.UpdatedOn).HasColumnName(@"UpdatedOn").HasColumnType("datetime").IsOptional();
            Property(x => x.UpdatedBy).HasColumnName(@"UpdatedBy").HasColumnType("bigint").IsOptional();

            // Foreign keys
            HasRequired(a => a.Master_TblMstDistrict).WithMany(b => b.Master_TblMstTicketingFees).HasForeignKey(c => c.DistCode).WillCascadeOnDelete(false); // FK_tbl_mst_TicketingFees_tbl_mst_Districts
            HasRequired(a => a.Master_TblMstPlace).WithMany(b => b.Master_TblMstTicketingFees).HasForeignKey(c => c.PlaceId).WillCascadeOnDelete(false); // FK_tbl_mst_TicketingFees_tbl_mst_Places
        }
    }

}
// </auto-generated>
