// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace JovenesA.DomainClasses
{
  // Students
  public class StudentDTO
    {
        public int StudentDTOId { get; set; } // StudentDTOID (Primary key)
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string StudentName { get; set; } // StudentName
        public string Email { get; set; } // Email
        public int? YearJoinedJa { get; set; } // YearJoinedJA
        public int? StatusID { get; set; } // StatusID
        public int? GradYear { get; set; } // GradYear
        public string GradeRptStatus { get; set; } // GradeRptStatus
        public string GPAStatus { get; set; } // GPAStatus
        public string TimelyMentorMeetingStatus { get; set; }
        public string TimelyMentorReportStatus { get; set; }
        public int? StudentAssessmentStatus { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? StudentSnapshotStatus { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? MentorId { get; set; } // MentorID
        public string MentorName { get; set; } // MentorName  
        public string Gender { get; set; } // Gender    
        public string Status { get; set; } // Status

    }

}
