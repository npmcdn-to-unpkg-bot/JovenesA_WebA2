// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;
using JovenesA.DomainClasses;

namespace JovenesA.DataAccess
{
  // Students
  internal class StudentConfiguration : EntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
            : this("dbo")
        {
        }
 
        public StudentConfiguration(string schema)
        {
            ToTable(schema + ".Students");
            HasKey(x => x.StudentId);

            Property(x => x.StudentId).HasColumnName("StudentID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.JaId).HasColumnName("JA_ID").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.LastNames).HasColumnName("LastNames").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.FirstNames).HasColumnName("FirstNames").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.NickName).HasColumnName("NickName").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            //Property(x => x.FullName).HasColumnName("FullName").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.Curp).HasColumnName("CURP").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.Rfc).HasColumnName("RFC").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.BankAccount).HasColumnName("BankAccount").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.Gender).HasColumnName("Gender").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.CellPhone).HasColumnName("CellPhone").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.HomePhone).HasColumnName("HomePhone").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.OtherPhone).HasColumnName("OtherPhone").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.Email).HasColumnName("Email").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.EnglishLevel).HasColumnName("EnglishLevel").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.Sponsor).HasColumnName("Sponsor").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.PrepaId).HasColumnName("PrepaID").IsOptional().HasColumnType("int");
            Property(x => x.Major).HasColumnName("Major").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.MentorId).HasColumnName("MentorID").IsOptional().HasColumnType("int");
            Property(x => x.AgeWhenJoined).HasColumnName("AgeWhenJoined").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.YearJoinedJa).HasColumnName("YearJoinedJA").IsOptional().HasColumnType("int");
            Property(x => x.UniversityId).HasColumnName("UniversityID").IsOptional().HasColumnType("int");
            Property(x => x.GradMonth).HasColumnName("GradMonth").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.GradYear).HasColumnName("GradYear").IsOptional().HasColumnType("int");
            Property(x => x.Dob).HasColumnName("DOB").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.Addresss).HasColumnName("Addresss").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.Colonia).HasColumnName("Colonia").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.InitialInterview).HasColumnName("InitialInterview").IsOptional().HasColumnType("ntext").HasMaxLength(1073741823);
            Property(x => x.SponsorId).HasColumnName("SponsorID").IsOptional().HasColumnType("int");
            Property(x => x.StatusId).HasColumnName("StatusID").IsOptional().HasColumnType("int");
            Property(x => x.EnglishSkillLevelId).HasColumnName("EnglishSkillLevelID").IsOptional().HasColumnType("int");
            Property(x => x.PhotoUrl).HasColumnName("PhotoURL").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.UpdateDtTm).HasColumnName("UpdateDtTm").IsOptional().HasColumnType("datetime");
            Property(x => x.Timestamp).HasColumnName("Timestamp").IsOptional().HasColumnType("timestamp").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.EmergencyContactName).HasColumnName("EmergencyContactName").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.EmergencyContactPhone).HasColumnName("EmergencyContactPhone").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.PostalCode).HasColumnName("PostalCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.AcademicYearTypeId).HasColumnName("AcademicYearTypeID").IsOptional().HasColumnType("int");
            Property(x => x.GradeMonthsId).HasColumnName("GradeMonthsID").IsOptional().HasColumnType("int");
            Property(x => x.JoinedFromId).HasColumnName("JoinedFromID").IsOptional().HasColumnType("int");
            Property(x => x.StudentStory).HasColumnName("StudentStory").IsOptional().HasColumnType("ntext").HasMaxLength(1073741823);
        }
    }

}
