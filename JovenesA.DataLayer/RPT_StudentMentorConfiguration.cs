// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;
using JovenesA.DomainClasses;

namespace JovenesA.DataAccess
{
  // StudentsMentors
  internal class RPT_StudentMentorConfiguration : EntityTypeConfiguration<RPT_StudentMentor>
    {
        public RPT_StudentMentorConfiguration()
            : this("dbo")
        {
        }
 
        public RPT_StudentMentorConfiguration(string schema)
        {
            ToTable(schema + ".RPT_StudentMentors");
            HasKey(x => new { x.MentorId, x.StudentId });

            Property(x => x.StudentId).HasColumnName("StudentID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.MentorId).HasColumnName("MentorID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            //Property(x => x.StartDate).HasColumnName("StartDate").IsOptional().HasColumnType("smalldatetime");
            //Property(x => x.StopDate).HasColumnName("StopDate").IsOptional().HasColumnType("smalldatetime");
            //Property(x => x.UpdateDtTm).HasColumnName("UpdateDtTm").IsOptional().HasColumnType("datetime");
            Property(x => x.GradYear).HasColumnName("GradYear").IsOptional().HasColumnType("int");
            Property(x => x.GradeRptStatus).HasColumnName("GradeRptStatus").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.GPAStatus).HasColumnName("GPAStatus").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.TimelyMentorMeetingStatus).HasColumnName("TimelyMentorMeetingStatus").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.TimelyMentorReportStatus).HasColumnName("TimelyMentorReportStatus").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.StudentSnapshotStatus).HasColumnName("StudentSnapshotStatus").IsOptional().HasColumnType("int");

            Property(x => x.StudentLastNames).HasColumnName("StudentLastNames").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.StudentFirstNames).HasColumnName("StudentFirstNames").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.StudentEmail).HasColumnName("StudentEmail").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.StudentPhone).HasColumnName("StudentPhone").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);

            Property(x => x.MentorLastNames).HasColumnName("MentorLastNames").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.MentorFirstNames).HasColumnName("MentorFirstNames").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.MentorEmail).HasColumnName("MentorEmail").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);


            Property(x => x.UniversityName).HasColumnName("UniversityName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);

        }
    }

}
