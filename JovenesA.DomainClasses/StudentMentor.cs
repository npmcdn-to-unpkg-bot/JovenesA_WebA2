// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;

namespace JovenesA.DomainClasses
{
  // StudentMentors
  public class StudentMentor
    {
        public int StudentId { get; set; } // StudentID (Primary key)
        public int MentorId { get; set; } // MentorID (Primary key)
        public DateTime? StartDate { get; set; } // StartDate
        public DateTime? StopDate { get; set; } // StopDate
        public DateTime? UpdateDtTm { get; set; } // UpdateDtTm
        public byte[] Timestamp { get; set; } // Timestamp
        
        public StudentMentor()
        {
            UpdateDtTm = System.DateTime.Now;
        }
    }

}
