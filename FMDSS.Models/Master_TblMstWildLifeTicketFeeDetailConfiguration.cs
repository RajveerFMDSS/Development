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

    // tbl_Mst_WildLifeTicketFeeDetails
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class Master_TblMstWildLifeTicketFeeDetailConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Master_TblMstWildLifeTicketFeeDetail>
    {
        public Master_TblMstWildLifeTicketFeeDetailConfiguration()
            : this("Master")
        {
        }

        public Master_TblMstWildLifeTicketFeeDetailConfiguration(string schema)
        {
            ToTable("tbl_Mst_WildLifeTicketFeeDetails", schema);
            HasKey(x => x.Rowid);

            Property(x => x.Rowid).HasColumnName(@"ROWID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.FeesId).HasColumnName(@"FeesID").HasColumnType("bigint").IsRequired();
            Property(x => x.WildLifeHeadDetailId).HasColumnName(@"WildLifeHeadDetailID").HasColumnType("int").IsRequired();
            Property(x => x.Price).HasColumnName(@"Price").HasColumnType("float").IsRequired();
            Property(x => x.IsActive).HasColumnName(@"isActive").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.Master_TblMstTicketingFee).WithMany(b => b.Master_TblMstWildLifeTicketFeeDetails).HasForeignKey(c => c.FeesId).WillCascadeOnDelete(false); // FEESIDPK
            HasRequired(a => a.Master_TblMstWildLifeHeadDetail).WithMany(b => b.Master_TblMstWildLifeTicketFeeDetails).HasForeignKey(c => c.WildLifeHeadDetailId).WillCascadeOnDelete(false); // WildLifeHeadDetailsFK
        }
    }

}
// </auto-generated>
