// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.ComponentModel.DataAnnotations;

namespace JovenesA.DomainClasses
{
  // QuarterlyAssessments
  public class QuarterlyAssessment
    {
        [Key]
        public int QuarterlyAssessmentId { get; set; } // QuarterlyAssessmentID
        public int? PsychologistId { get; set; } // PsychologistID
        public int? StudentId { get; set; } // StudentID
        public DateTime? ReportDateTime { get; set; } // ReportDate
        public int? AssessmentSnapshot { get; set; }
        public DateTime? AssessmentDate { get; set; } // AssessmentDate
        public string AssessmentText { get; set; }

    }

}
