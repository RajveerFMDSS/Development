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

    // tbl_mst_Vehicle_EquipmentFee
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class Master_TblMstVehicleEquipmentFeeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Master_TblMstVehicleEquipmentFee>
    {
        public Master_TblMstVehicleEquipmentFeeConfiguration()
            : this("Master")
        {
        }

        public Master_TblMstVehicleEquipmentFeeConfiguration(string schema)
        {
            ToTable("tbl_mst_Vehicle_EquipmentFee", schema);
            HasKey(x => x.VehicleId);

            Property(x => x.VehicleId).HasColumnName(@"VehicleID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CategoryId).HasColumnName(@"CategoryID").HasColumnType("bigint").IsOptional();
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Fees).HasColumnName(@"Fees").HasColumnType("decimal").IsOptional().HasPrecision(18,2);
            Property(x => x.Isactive).HasColumnName(@"Isactive").HasColumnType("int").IsOptional();
            Property(x => x.EnteredOn).HasColumnName(@"EnteredOn").HasColumnType("datetime").IsOptional();
            Property(x => x.EnteredBy).HasColumnName(@"EnteredBy").HasColumnType("bigint").IsOptional();
            Property(x => x.UpdatedOn).HasColumnName(@"UpdatedOn").HasColumnType("datetime").IsOptional();
            Property(x => x.UpdatedBy).HasColumnName(@"UpdatedBy").HasColumnType("bigint").IsOptional();

            // Foreign keys
            HasOptional(a => a.Master_TblMstVehicleEquipment).WithMany(b => b.Master_TblMstVehicleEquipmentFees).HasForeignKey(c => c.CategoryId).WillCascadeOnDelete(false); // FK_tbl_mst_Vehicle_EquipmentFee_tbl_mst_Vehicle_Equipment
        }
    }

}
// </auto-generated>
