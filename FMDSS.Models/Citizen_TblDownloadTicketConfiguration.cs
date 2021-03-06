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

    // tbl_DownloadTickets
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class Citizen_TblDownloadTicketConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Citizen_TblDownloadTicket>
    {
        public Citizen_TblDownloadTicketConfiguration()
            : this("Citizen")
        {
        }

        public Citizen_TblDownloadTicketConfiguration(string schema)
        {
            ToTable("tbl_DownloadTickets", schema);
            HasKey(x => new { x.Id, x.RequestedId, x.TableName });

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RequestedId).HasColumnName(@"RequestedID").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TableName).HasColumnName(@"TableName").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ModuleId).HasColumnName(@"ModuleId").HasColumnType("smallint").IsOptional();
            Property(x => x.ServiceTypeId).HasColumnName(@"ServiceTypeId").HasColumnType("smallint").IsOptional();
            Property(x => x.PermissionId).HasColumnName(@"PermissionId").HasColumnType("smallint").IsOptional();
            Property(x => x.SubPermissionId).HasColumnName(@"SubPermissionId").HasColumnType("smallint").IsOptional();
            Property(x => x.Path).HasColumnName(@"Path").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.PathRepoDocId).HasColumnName(@"Path_RepoDocID").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.PathName).HasColumnName(@"Path_Name").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.PathDocStatus).HasColumnName(@"Path_DocStatus").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.IsPdfStatus).HasColumnName(@"IsPDFStatus").HasColumnType("bit").IsOptional();
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("bit").IsOptional();
        }
    }

}
// </auto-generated>
