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

    // tbl_WildLifeSafariBookingDetails
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class Citizen_TblWildLifeSafariBookingDetailConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Citizen_TblWildLifeSafariBookingDetail>
    {
        public Citizen_TblWildLifeSafariBookingDetailConfiguration()
            : this("Citizen")
        {
        }

        public Citizen_TblWildLifeSafariBookingDetailConfiguration(string schema)
        {
            ToTable("tbl_WildLifeSafariBookingDetails", schema);
            HasKey(x => x.Rowid);

            Property(x => x.Rowid).HasColumnName(@"ROWID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.MemberId).HasColumnName(@"MemberID").HasColumnType("bigint").IsRequired();
            Property(x => x.FeesId).HasColumnName(@"FeesID").HasColumnType("bigint").IsRequired();
            Property(x => x.WildLifeHeadDetailId).HasColumnName(@"WildLifeHeadDetailID").HasColumnType("int").IsRequired();
            Property(x => x.Price).HasColumnName(@"Price").HasColumnType("float").IsRequired();
            Property(x => x.Counts).HasColumnName(@"Counts").HasColumnType("smallint").IsRequired();
            Property(x => x.IsActive).HasColumnName(@"isActive").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.Citizen_TblTicketBookingMember).WithMany(b => b.Citizen_TblWildLifeSafariBookingDetails).HasForeignKey(c => c.MemberId).WillCascadeOnDelete(false); // 0MemberIDPK
            HasRequired(a => a.Master_TblMstTicketingFee).WithMany(b => b.Citizen_TblWildLifeSafariBookingDetails).HasForeignKey(c => c.FeesId).WillCascadeOnDelete(false); // 0FEESIDPK
            HasRequired(a => a.Master_TblMstWildLifeHeadDetail).WithMany(b => b.Citizen_TblWildLifeSafariBookingDetails).HasForeignKey(c => c.WildLifeHeadDetailId).WillCascadeOnDelete(false); // 0WildLifeHeadDetailsFK
        }
    }

}
// </auto-generated>