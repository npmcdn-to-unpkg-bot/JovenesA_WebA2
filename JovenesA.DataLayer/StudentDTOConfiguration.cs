// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;
using JovenesA.DomainClasses;

namespace JovenesA.DataAccess
{
  // Students
  internal class StudentDTOConfiguration : EntityTypeConfiguration<StudentDTO>
    {
        public StudentDTOConfiguration()
            : this("dbo")
        {
        }
 
        public StudentDTOConfiguration(string schema)
        {
            ToTable(schema + ".StudentDTOs");
            HasKey(x => x.StudentDTOId);

            Property(x => x.StudentDTOId).HasColumnName("StudentDTOID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.StudentName).HasColumnName("StudentName").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.Email).HasColumnName("Email").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.StatusID).HasColumnName("StatusID").IsOptional().HasColumnType("int");
            Property(x => x.YearJoinedJa).HasColumnName("YearJoinedJA").IsOptional().HasColumnType("int");
            Property(x => x.GradYear).HasColumnName("GradYear").IsOptional().HasColumnType("int");
            Property(x => x.GradeRptStatus).HasColumnName("GradeRptStatus").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.GPAStatus).HasColumnName("GPAStatus").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.TimelyMentorMeetingStatus).HasColumnName("TimelyMentorMeetingStatus").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.TimelyMentorReportStatus).HasColumnName("TimelyMentorReportStatus").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.StudentAssessmentStatus).HasColumnName("StudentAssessmentStatus").IsOptional().HasColumnType("int");
            Property(x => x.StudentSnapshotStatus).HasColumnName("StudentSnapshotStatus").IsOptional().HasColumnType("int");

            Property(x => x.MentorId).HasColumnName("MentorID").IsOptional().HasColumnType("int");
            Property(x => x.MentorName).HasColumnName("MentorName").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.Gender).HasColumnName("Gender").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.Status).HasColumnName("Status").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
        }
    }

}
