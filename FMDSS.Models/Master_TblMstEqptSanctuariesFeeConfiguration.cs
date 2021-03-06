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

    // tbl_mst_Eqpt_SanctuariesFee
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class Master_TblMstEqptSanctuariesFeeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Master_TblMstEqptSanctuariesFee>
    {
        public Master_TblMstEqptSanctuariesFeeConfiguration()
            : this("Master")
        {
        }

        public Master_TblMstEqptSanctuariesFeeConfiguration(string schema)
        {
            ToTable("tbl_mst_Eqpt_SanctuariesFee", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PlaceId).HasColumnName(@"PlaceID").HasColumnType("bigint").IsRequired();
            Property(x => x.ZoneId).HasColumnName(@"ZoneID").HasColumnType("bigint").IsRequired();
            Property(x => x.ShiftTypeId).HasColumnName(@"ShiftTypeID").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.VehicleCategoryId).HasColumnName(@"VehicleCategoryID").HasColumnType("bigint").IsRequired();
            Property(x => x.VehicleCategoryNameId).HasColumnName(@"VehicleCategoryNameID").HasColumnType("bigint").IsRequired();
            Property(x => x.TotalEqptAvailability).HasColumnName(@"TotalEqptAvailability").HasColumnType("int").IsRequired();
            Property(x => x.SeatsPerEqpt).HasColumnName(@"SeatsPerEqpt").HasColumnType("int").IsRequired();
            Property(x => x.IsActive).HasColumnName(@"IsActive").HasColumnType("int").IsRequired();
            Property(x => x.TotalSeats).HasColumnName(@"TotalSeats").HasColumnType("int").IsRequired();
            Property(x => x.SeatsForCitizen).HasColumnName(@"seatsForCitizen").HasColumnType("int").IsRequired();
            Property(x => x.EnteredOn).HasColumnName(@"EnteredOn").HasColumnType("datetime").IsRequired();
            Property(x => x.EnteredBy).HasColumnName(@"EnteredBy").HasColumnType("bigint").IsRequired();

            // Foreign keys
            HasRequired(a => a.Master_TblMstPlace).WithMany(b => b.Master_TblMstEqptSanctuariesFees).HasForeignKey(c => c.PlaceId).WillCascadeOnDelete(false); // FK_Place
            HasRequired(a => a.Master_TblMstVehicleEquipment).WithMany(b => b.Master_TblMstEqptSanctuariesFees).HasForeignKey(c => c.VehicleCategoryId).WillCascadeOnDelete(false); // FK_VehicleCategoryID
            HasRequired(a => a.Master_TblMstVehicleEquipmentFee).WithOptional(b => b.Master_TblMstEqptSanctuariesFee).WillCascadeOnDelete(false); // FK_VehicleCategoryNameID
        }
    }

}
// </auto-generated>
