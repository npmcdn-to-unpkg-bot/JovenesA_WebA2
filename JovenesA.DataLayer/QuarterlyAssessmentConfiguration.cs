// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;
using JovenesA.DomainClasses;

namespace JovenesA.DataAccess
{
  // QuarterlyAssessments
  internal class QuarterlyAssessmentConfiguration : EntityTypeConfiguration<QuarterlyAssessment>
    {
        public QuarterlyAssessmentConfiguration()
            : this("dbo")
        {
        }
 
        public QuarterlyAssessmentConfiguration(string schema)
        {
            ToTable(schema + ".QuarterlyAssessments");
            HasKey(x => x.QuarterlyAssessmentId);

            Property(x => x.QuarterlyAssessmentId).HasColumnName("QuarterlyAssessmentID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.PsychologistId).HasColumnName("PsychologistID").IsRequired().HasColumnType("int");
            Property(x => x.StudentId).HasColumnName("StudentID").IsRequired().HasColumnType("int");
            Property(x => x.ReportDateTime).HasColumnName("ReportDateTime").IsOptional().HasColumnType("datetime");
            Property(x => x.AssessmentSnapshot).HasColumnName("AssessmentSnapshot").IsOptional().HasColumnType("int");
            Property(x => x.AssessmentDate).HasColumnName("AssessmentDate").IsOptional().HasColumnType("date");
            Property(x => x.AssessmentText).HasColumnName("AssessmentText").IsOptional().HasColumnType("nvarchar").HasMaxLength(20000);
        }
    }

}
