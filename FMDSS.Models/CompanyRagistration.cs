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

    // CompanyRagistration
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class CompanyRagistration
    {
        public long CompanyId { get; set; } // CompanyID (Primary key)
        public string CompanyName { get; set; } // CompanyName (length: 500)
        public string CompanyUrl { get; set; } // CompanyUrl (length: 2000)
        public int? CompanyStatus { get; set; } // CompanyStatus
        public string PrivateConnectionString { get; set; } // PrivateConnectionString (length: 500)
    }

}
// </auto-generated>