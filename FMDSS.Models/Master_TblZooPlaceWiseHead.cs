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

    // tbl_ZooPlaceWiseHead
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class Master_TblZooPlaceWiseHead
    {
        public int ZooPlaceWiseHeadId { get; set; } // ZooPlaceWiseHeadId (Primary key)
        public long PlaceId { get; set; } // PlaceId
        public string FeeChargedOn { get; set; } // FeeChargedOn (length: 50)
        public int HeadId { get; set; } // HeadId
        public decimal? HeadAmount { get; set; } // HeadAmount
        public string Type { get; set; } // Type (length: 10)
        public bool IsActive { get; set; } // isActive
        public string ParentFeeChangeOn { get; set; } // ParentFeeChangeON (length: 100)

        public Master_TblZooPlaceWiseHead()
        {
            PlaceId = 0;
            HeadId = 0;
            HeadAmount = 0m;
            IsActive = true;
        }
    }

}
// </auto-generated>
