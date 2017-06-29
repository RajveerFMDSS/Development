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

    // User
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class User
    {
        public int UserId { get; set; } // UserId (Primary key)
        public string UserName { get; set; } // UserName (length: 50)
        public string Password { get; set; } // Password (length: 50)
        public string Name { get; set; } // Name (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child Tokens where [Tokens].[UserId] point to this entity (FK_Tokens_User)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Token> Tokens { get; set; } // Tokens.FK_Tokens_User

        public User()
        {
            Tokens = new System.Collections.Generic.List<Token>();
        }
    }

}
// </auto-generated>
