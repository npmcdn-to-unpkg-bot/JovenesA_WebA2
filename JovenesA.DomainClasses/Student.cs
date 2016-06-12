// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace JovenesA.DomainClasses
{
  // Students
  public class Student
    {
        public int StudentId { get; set; } // StudentID (Primary key)
        public string JaId { get; set; } // JA_ID
        public string LastNames { get; set; } // LastNames
        public string FirstNames { get; set; } // FirstNames
        public string NickName { get; set; } // NickName
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public string FullName { get; set; } // FullName
        public string Curp { get; set; } // CURP
        public string Rfc { get; set; } // RFC
        public string BankAccount { get; set; } // BankAccount
        public string Gender { get; set; } // Gender
        public string CellPhone { get; set; } // CellPhone
        public string HomePhone { get; set; } // HomePhone
        public string OtherPhone { get; set; } // OtherPhone
        public string Email { get; set; } // Email
        public string EnglishLevel { get; set; } // EnglishLevel
        public string Sponsor { get; set; } // Sponsor
        public int? PrepaId { get; set; } // PrepaID
        public string Major { get; set; } // Major
        public int? MentorId { get; set; } // MentorID
        public string AgeWhenJoined { get; set; } // AgeWhenJoined
        public int? YearJoinedJa { get; set; } // YearJoinedJA
        public int? UniversityId { get; set; } // UniversityID
        public string GradMonth { get; set; } // GradMonth
        public int? GradYear { get; set; } // GradYear
        public DateTime? Dob { get; set; } // DOB
        public string Addresss { get; set; } // Addresss
        public string Colonia { get; set; } // Colonia
        public string InitialInterview { get; set; } // InitialInterview
        public int? SponsorId { get; set; } // SponsorID
        public int? StatusId { get; set; } // StatusID
        public int? EnglishSkillLevelId { get; set; } // EnglishSkillLevelID
        public string PhotoUrl { get; set; } // PhotoURL
        public DateTime? UpdateDtTm { get; set; } // UpdateDtTm
        public byte[] Timestamp { get; set; } // Timestamp
        public string EmergencyContactName { get; set; } // EmergencyContactName
        public string EmergencyContactPhone { get; set; } // EmergencyContactPhone
        public string PostalCode { get; set; } // PostalCode
        public int? AcademicYearTypeId { get; set; } // AcademicYearTypeID
        public int? GradeMonthsId { get; set; } // GradeMonthsID
        public int? JoinedFromId { get; set; } // JoinedFromID
        public string StudentStory { get; set; } // StudentStory
                
        public Student()
        {
            UpdateDtTm = System.DateTime.Now;
        }
    }

}
