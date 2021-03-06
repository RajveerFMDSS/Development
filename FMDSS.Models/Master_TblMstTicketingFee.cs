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
    public class Master_TblMstTicketingFee
    {
        public long FeesId { get; set; } // FeesID (Primary key)
        public string DistCode { get; set; } // DIST_CODE (length: 10)
        public long PlaceId { get; set; } // PlaceID
        public int? Isactive { get; set; } // Isactive
        public System.DateTime? EnteredOn { get; set; } // EnteredOn
        public long? EnteredBy { get; set; } // EnteredBy
        public System.DateTime? UpdatedOn { get; set; } // UpdatedOn
        public long? UpdatedBy { get; set; } // UpdatedBy

        // Reverse navigation

        /// <summary>
        /// Child Citizen_TblWildLifeSafariBookingDetails where [tbl_WildLifeSafariBookingDetails].[FeesID] point to this entity (0FEESIDPK)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Citizen_TblWildLifeSafariBookingDetail> Citizen_TblWildLifeSafariBookingDetails { get; set; } // tbl_WildLifeSafariBookingDetails.0FEESIDPK
        /// <summary>
        /// Child Citizen_TblWildLifeTicketBookingMemberDetails where [tbl_WildLifeTicketBookingMemberDetails].[FeesID] point to this entity (FEESIDPK)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Citizen_TblWildLifeTicketBookingMemberDetail> Citizen_TblWildLifeTicketBookingMemberDetails { get; set; } // tbl_WildLifeTicketBookingMemberDetails.FEESIDPK
        /// <summary>
        /// Child Master_TblMstWildLifeTicketFeeDetails where [tbl_Mst_WildLifeTicketFeeDetails].[FeesID] point to this entity (FEESIDPK)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Master_TblMstWildLifeTicketFeeDetail> Master_TblMstWildLifeTicketFeeDetails { get; set; } // tbl_Mst_WildLifeTicketFeeDetails.FEESIDPK

        // Foreign keys

        /// <summary>
        /// Parent Master_TblMstDistrict pointed by [tbl_mst_TicketingFees].([DistCode]) (FK_tbl_mst_TicketingFees_tbl_mst_Districts)
        /// </summary>
        public virtual Master_TblMstDistrict Master_TblMstDistrict { get; set; } // FK_tbl_mst_TicketingFees_tbl_mst_Districts
        /// <summary>
        /// Parent Master_TblMstPlace pointed by [tbl_mst_TicketingFees].([PlaceId]) (FK_tbl_mst_TicketingFees_tbl_mst_Places)
        /// </summary>
        public virtual Master_TblMstPlace Master_TblMstPlace { get; set; } // FK_tbl_mst_TicketingFees_tbl_mst_Places

        public Master_TblMstTicketingFee()
        {
            EnteredOn = System.DateTime.Now;
            Master_TblMstWildLifeTicketFeeDetails = new System.Collections.Generic.List<Master_TblMstWildLifeTicketFeeDetail>();
            Citizen_TblWildLifeSafariBookingDetails = new System.Collections.Generic.List<Citizen_TblWildLifeSafariBookingDetail>();
            Citizen_TblWildLifeTicketBookingMemberDetails = new System.Collections.Generic.List<Citizen_TblWildLifeTicketBookingMemberDetail>();
        }
    }

}
// </auto-generated>
