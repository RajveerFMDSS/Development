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

    // tbl_mst_Places
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class TblMstPlace
    {
        public long PlaceId { get; set; } // PlaceID (Primary key)
        public string DistCode { get; set; } // DIST_CODE (length: 10)
        public string PlaceName { get; set; } // PlaceName (length: 200)
        public string Category { get; set; } // Category (length: 50)
        public string MorningShiftFrom { get; set; } // MorningShiftFrom (length: 50)
        public string MorningShiftTo { get; set; } // MorningShiftTo (length: 50)
        public string EveningShiftFrom { get; set; } // EveningShiftFrom (length: 50)
        public string EveningShiftTo { get; set; } // EveningShiftTo (length: 50)
        public string FullDayShift { get; set; } // FullDayShift (length: 10)
        public int? TicketAllocatedPerShift { get; set; } // TicketAllocatedPerShift
        public string IsAccommodation { get; set; } // IsAccommodation (length: 50)
        public string IsSafari { get; set; } // IsSafari (length: 50)
        public int? Isactive { get; set; } // Isactive
        public System.DateTime? EnteredOn { get; set; } // EnteredOn
        public long? EnteredBy { get; set; } // EnteredBy
        public System.DateTime? UpdatedOn { get; set; } // UpdatedOn
        public long? UpdatedBy { get; set; } // UpdatedBy
        public bool? IsZone { get; set; } // IsZone
        public string ContactPerson { get; set; } // ContactPerson (length: 100)
        public string Address { get; set; } // Address (length: 500)
        public string PhoneNo { get; set; } // PhoneNo (length: 30)
        public string BoardingPoint { get; set; } // Boarding_Point (length: 500)
        public bool IsOnlineBooking { get; set; } // IsOnlineBooking
        public bool IsCamping { get; set; } // IsCamping
        public bool IsResearch { get; set; } // IsResearch
        public int MaxBookingDuration { get; set; } // MaxBookingDuration
        public bool? IsMorning { get; set; } // isMorning
        public bool? IsEvening { get; set; } // isEvening
        public bool? IsFullDay { get; set; } // isFullDay
        public bool? IsDptKiosk { get; set; } // isDptKiosk
        public bool? IsCitizen { get; set; } // isCitizen
        public decimal Tax { get; set; } // Tax
        public decimal EmitraCharges { get; set; } // EmitraCharges
        public string Code { get; set; } // Code (length: 10)
        public bool IsZooAvailable { get; set; } // isZooAvailable
        public bool IsFilmShootong { get; set; } // isFilmShootong

        // Foreign keys

        /// <summary>
        /// Parent TblMstDistrict pointed by [tbl_mst_Places].([DistCode]) (FK_tbl_mst_Places_tbl_mst_Districts)
        /// </summary>
        public virtual TblMstDistrict TblMstDistrict { get; set; } // FK_tbl_mst_Places_tbl_mst_Districts

        public TblMstPlace()
        {
            Isactive = 1;
            EnteredOn = System.DateTime.Now;
            IsOnlineBooking = false;
            IsCamping = false;
            IsResearch = false;
            MaxBookingDuration = 30;
            Tax = 15m;
            EmitraCharges = 2.25m;
            IsZooAvailable = false;
            IsFilmShootong = false;
        }
    }

}
// </auto-generated>