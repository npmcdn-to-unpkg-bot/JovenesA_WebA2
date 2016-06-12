// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;

namespace JovenesA.DomainClasses
{
  // StudentMentors
  public class RPT_StudentMentor
    {
        public int StudentId { get; set; } // StudentID (Primary key)
        public int MentorId { get; set; } // MentorID (Primary key)
        //public DateTime? StartDate { get; set; } // StartDate
        //public DateTime? StopDate { get; set; } // StopDate
        //public DateTime? UpdateDtTm { get; set; } // UpdateDtTm
        public string StudentLastNames { get; set; } // LastNames
        public string StudentFirstNames { get; set; } // FirstNames
        public string MentorLastNames { get; set; } // LastNames
        public string MentorFirstNames { get; set; } // FirstNames
        public int? GradYear { get; set; } // GradYear
        public string GradeRptStatus { get; set; } // GradeRptStatus
        public string GPAStatus { get; set; } // GPAStatus
        public string TimelyMentorMeetingStatus { get; set; }
        public string TimelyMentorReportStatus { get; set; }
        public int? StudentSnapshotStatus { get; set; }
        public string UniversityName { get; set; } // UniversityName
        public string StudentEmail { get; set; }
        public string StudentPhone { get; set; }
        public string MentorEmail { get; set; }

        //public RPT_StudentMentor()
        //{
        //    UpdateDtTm = System.DateTime.Now;
        //}
    }

}
