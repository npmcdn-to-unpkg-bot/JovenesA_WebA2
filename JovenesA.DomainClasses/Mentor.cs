// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace JovenesA.DomainClasses
{
  // Members
  public class Mentor
    {
        public int MentorId { get; set; } // MemberID (Primary key)
        public string LastNames { get; set; } // LastNames
        public string FirstNames { get; set; } // FirstNames
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string FullName { get; set; } // FullName
        public int? MentorStatusId { get; set; } // MentorStatusID
        public int? YearJoinedJa { get; set; } // YearJoinedJA
        public string SmaAddress { get; set; } // SMA_Address
        public string SmaPhone { get; set; } // SMA_Phone
        public string NonSmaAddress { get; set; } // NonSMA_Address
        public string NonSmaCity { get; set; } // NonSMA_City
        public string NonSmaStateProvince { get; set; } // NonSMA_State_Province
        public string NonSmaPostalCode { get; set; } // NonSMA_PostalCode
        public int? NonSmaCountryId { get; set; } // NonSMA_CountryID
        public string NonSmaPhone { get; set; } // NonSMA_Phone
        public string Email { get; set; } // Email
        public int? BestWayToContactId { get; set; } // BestWayToContactID
        public int? CountryOfResidenceID { get; set; } // CountryOfResidenceID
        public string MonthsinSma { get; set; } // MonthsinSMA
        public string CareerExperience { get; set; } // CareerExperience
        public string MentoringExperience { get; set; } // MentoringExperience
        public string OtherRelevantLifeExperience { get; set; } // OtherRelevantLifeExperience
        public int? SpanishSkillLevelId { get; set; } // SpanishSkillLevelID
        public int? EnglishSkillLevelId { get; set; } // EnglishSkillLevelID
        public int? StudentPreferenceId { get; set; } // StudentPreferenceID
        public DateTime? UpdateDtTm { get; set; } // UpdateDtTm
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public byte[] Timestamp { get; set; } // Timestamp
        
        public Mentor()
        {
            UpdateDtTm = System.DateTime.Now;
        }
    }

}
