// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace JovenesA.DomainClasses
{
  // UniversityTermTypes
  public class UniversityTermType
    {
        public int UniversityTermTypeId { get; set; } // UniversityTermTypeID (Primary key)
        public int? UniversityId { get; set; } // UniversityID
        public int? TermTypeId { get; set; } // TermTypeID
    }

}
