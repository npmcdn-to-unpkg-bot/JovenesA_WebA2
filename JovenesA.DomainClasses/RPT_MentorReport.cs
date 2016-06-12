// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.ComponentModel.DataAnnotations;

namespace JovenesA.DomainClasses
{
  // MentorReports
  public class RPT_MentorReport
    {
        [Key]
        public int MentorReportId { get; set; } // MentorReportID
        public int? MentorId { get; set; } // MentorID
        public int? StudentId { get; set; } // StudentID
        public string MentorName { get; set; } // MentorName
        public string StudentName { get; set; } // StudentName
        public DateTime? ReportDateTime { get; set; } // ReportDate
        public DateTime? LastContactDate { get; set; } // LastCommunicationDate
        public int? MentorReportSnapshot { get; set; } // MentorReportSnapshot
        public string ReasonForDelay { get; set; } // ReasonForDelay
        public string FollowUpNeeded { get; set; } // FollowUpNeeded
        public string RecentSuccess { get; set; } // RecentSuccess
        public string RecentSetback { get; set; } // RecentSetback
    }

}
