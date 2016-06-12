// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;
using JovenesA.DomainClasses;

namespace JovenesA.DataAccess
{
  // MentorReports
  internal class RPT_MentorReportConfiguration : EntityTypeConfiguration<RPT_MentorReport>
    {
        public RPT_MentorReportConfiguration()
            : this("dbo")
        {
        }
 
        public RPT_MentorReportConfiguration(string schema)
        {
            ToTable(schema + ".RPT_MentorReports");
            HasKey(x => x.MentorReportId);

            Property(x => x.MentorReportId).HasColumnName("MentorReportID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.MentorId).HasColumnName("MentorID").IsRequired().HasColumnType("int");
            Property(x => x.StudentId).HasColumnName("StudentID").IsRequired().HasColumnType("int");
            Property(x => x.MentorName).HasColumnName("MentorName").IsRequired().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.StudentName).HasColumnName("StudentName").IsRequired().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.ReportDateTime).HasColumnName("ReportDateTime").IsOptional().HasColumnType("datetime");
            Property(x => x.LastContactDate).HasColumnName("LastContactDate").IsOptional().HasColumnType("date");
            Property(x => x.MentorReportSnapshot).HasColumnName("MentorReportSnapshot").IsOptional().HasColumnType("int");
            Property(x => x.ReasonForDelay).HasColumnName("ReasonForDelay").IsOptional().HasColumnType("nvarchar").HasMaxLength(2000);
            Property(x => x.FollowUpNeeded).HasColumnName("FollowUpNeeded").IsOptional().HasColumnType("nvarchar").HasMaxLength(2000);
            Property(x => x.RecentSuccess).HasColumnName("RecentSuccess").IsOptional().HasColumnType("nvarchar").HasMaxLength(2000);
            Property(x => x.RecentSetback).HasColumnName("RecentSetback").IsOptional().HasColumnType("nvarchar").HasMaxLength(2000);
        }
    }

}
