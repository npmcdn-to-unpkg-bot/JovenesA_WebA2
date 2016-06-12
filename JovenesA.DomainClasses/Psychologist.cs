// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace JovenesA.DomainClasses
{
  // Members
  public class Psychologist
    {
        public int PsychologistId { get; set; } // MemberID (Primary key)
        public string LastNames { get; set; } // LastNames
        public string FirstNames { get; set; } // FirstNames
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string FullName { get; set; } // FullName
        public int? PsychologistStatusId { get; set; } // PsychologistStatusID
        public int? YearJoinedJa { get; set; } // YearJoinedJA
        public string SmaAddress { get; set; } // SMA_Address
        public string SmaPhone { get; set; } // SMA_Phone
        public string Email { get; set; } // Email
        public int? BestWayToContactId { get; set; } // BestWayToContactID
        public int? EnglishSkillLevelId { get; set; } // EnglishSkillLevelID
        public DateTime? UpdateDtTm { get; set; } // UpdateDtTm
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public byte[] Timestamp { get; set; } // Timestamp
        
        public Psychologist()
        {
            UpdateDtTm = System.DateTime.Now;
        }
    }

}
