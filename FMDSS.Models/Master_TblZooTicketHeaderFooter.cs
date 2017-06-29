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

    // tblZooTicketHeaderFooter
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class Master_TblZooTicketHeaderFooter
    {
        public int Id { get; set; } // Id (Primary key)
        public string HeadeText { get; set; } // HeadeText (length: 2000)
        public string FooterText { get; set; } // FooterText (length: 2000)
        public bool IsActive { get; set; } // isActive
        public long PlaceId { get; set; } // PlaceID

        public Master_TblZooTicketHeaderFooter()
        {
            IsActive = true;
            PlaceId = 0;
        }
    }

}
// </auto-generated>
