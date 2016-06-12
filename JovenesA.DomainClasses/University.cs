// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;

namespace JovenesA.DomainClasses
{
  // Universities
  public class University
    {
        public int UniversityId { get; set; } // UniversityID (Primary key)
        public string UniversityAbbrev { get; set; } // UniversityAbbrev
        public string UniversityName { get; set; } // UniversityName
        public string UniversityCity { get; set; } // UniversityCity
        public int AcademicYearTypeId { get; set; } // AcademicYearTypeID (Primary key)
        public int? GradeMonthsId { get; set; } // GradeMonthsID
        public DateTime? UpdtDtTm { get; set; } // UpdtDtTm
        public byte[] Timestamp { get; set; } // Timestamp
        
        public University()
        {
            UpdtDtTm = System.DateTime.Now;
        }
    }

}
