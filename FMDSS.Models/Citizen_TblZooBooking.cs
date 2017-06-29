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

    // tbl_ZooBooking
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class Citizen_TblZooBooking
    {
        public long ZooBookingId { get; set; } // ZooBookingId (Primary key)
        public string RequestId { get; set; } // RequestId (length: 100)
        public string BookingTypeId { get; set; } // BookingTypeId (length: 50)
        public long PlaceId { get; set; } // PlaceId
        public string InstitutionalNameofInstitute { get; set; } // Institutional_NameofInstitute (length: 200)
        public string InstitutionalAddressofInstitute { get; set; } // Institutional_AddressofInstitute (length: 500)
        public string InstitutionalPhoneofInstitute { get; set; } // Institutional_PhoneofInstitute (length: 20)
        public string InstitutionalNameofHead { get; set; } // Institutional_NameofHead (length: 50)
        public string InstitutionalHeadPhoneNo { get; set; } // Institutional_HeadPhoneNo (length: 12)
        public string InstitutionalDocumentofTour { get; set; } // Institutional_DocumentofTour (length: 200)
        public string InstitutionalHeadIdType { get; set; } // Institutional_HeadIdType (length: 100)
        public string InstitutionalHeadIdNumber { get; set; } // Institutional_HeadIdNumber (length: 100)
        public string InstitutionalHeadIdProof { get; set; } // Institutional_HeadIdProof (length: 100)
        public System.DateTime? InstitutionalDateofVisit { get; set; } // Institutional_DateofVisit
        public decimal? InstitutionalTotalCameraFees { get; set; } // Institutional_TotalCameraFees
        public string InstitutionalTotalMemberFees { get; set; } // Institutional_TotalMemberFees (length: 10)
        public bool? IsPrivateVehical { get; set; } // isPrivateVehical
        public decimal? InstitutionalTotalVehicalFees { get; set; } // Institutional_TotalVehicalFees
        public decimal? StandardTotalCameraFees { get; set; } // Standard_TotalCameraFees
        public decimal? StandardTotalMemberFees { get; set; } // Standard_TotalMemberFees
        public decimal? StandardTotalVehicalFees { get; set; } // Standard_TotalVehicalFees
        public int? TrnStatusCode { get; set; } // Trn_Status_Code
        public string EmitraTransactionId { get; set; } // EmitraTransactionId (length: 100)
        public decimal? EmitraAmount { get; set; } // EmitraAmount
        public string IpAddress { get; set; } // IP_Address (length: 20)
        public long EnteredBy { get; set; } // EnteredBy
        public System.DateTime EnteredOn { get; set; } // EnteredOn
        public System.DateTime? UpdatedOn { get; set; } // UpdatedOn
        public long? KioskUserId { get; set; } // KioskUserId
        public decimal AmountTobepayForEmitra { get; set; } // AmountTobepayForEmitra
        public bool ZooTicketBoardingVerificationStatus { get; set; } // ZooTicketBoardingVerificationStatus
        public System.DateTime? BoardingVerificationDateTime { get; set; } // BoardingVerificationDateTime
        public string InstitutionalDocumentofTourRepoDocId { get; set; } // Institutional_DocumentofTour_RepoDocID (length: 100)
        public string InstitutionalDocumentofTourName { get; set; } // Institutional_DocumentofTour_Name (length: 100)
        public string InstitutionalDocumentofTourDocStatus { get; set; } // Institutional_DocumentofTour_DocStatus (length: 100)
        public string InstitutionalHeadIdProofRepoDocId { get; set; } // Institutional_HeadIdProof_RepoDocID (length: 100)
        public string IInstitutionalHeadIdProofName { get; set; } // IInstitutional_HeadIdProof_Name (length: 100)
        public string InstitutionalHeadIdProofDocStatus { get; set; } // Institutional_HeadIdProof_DocStatus (length: 100)
        public byte? ShiftTypeId { get; set; } // ShiftTypeID

        public Citizen_TblZooBooking()
        {
            BookingTypeId = "1";
            PlaceId = 0;
            IsPrivateVehical = false;
            InstitutionalTotalVehicalFees = 0m;
            StandardTotalVehicalFees = 0m;
            EnteredOn = System.DateTime.Now;
            AmountTobepayForEmitra = 0m;
            ZooTicketBoardingVerificationStatus = false;
            InstitutionalDocumentofTourRepoDocId = "";
            InstitutionalDocumentofTourName = "";
            InstitutionalDocumentofTourDocStatus = "0";
            InstitutionalHeadIdProofRepoDocId = "";
            IInstitutionalHeadIdProofName = "";
            InstitutionalHeadIdProofDocStatus = "0";
            ShiftTypeId = 0;
        }
    }

}
// </auto-generated>