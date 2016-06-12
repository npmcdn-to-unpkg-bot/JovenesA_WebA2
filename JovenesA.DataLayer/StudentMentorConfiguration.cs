// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;
using JovenesA.DomainClasses;

namespace JovenesA.DataAccess
{
  // StudentsMentors
  internal class StudentMentorConfiguration : EntityTypeConfiguration<StudentMentor>
    {
        public StudentMentorConfiguration()
            : this("dbo")
        {
        }
 
        public StudentMentorConfiguration(string schema)
        {
            ToTable(schema + ".StudentsMentors");
            HasKey(x => new { x.MentorId, x.StudentId });

            Property(x => x.StudentId).HasColumnName("StudentID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.MentorId).HasColumnName("MentorID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.StartDate).HasColumnName("StartDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.StopDate).HasColumnName("StopDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.UpdateDtTm).HasColumnName("UpdateDtTm").IsOptional().HasColumnType("datetime");
            Property(x => x.Timestamp).HasColumnName("Timestamp").IsOptional().HasColumnType("timestamp").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

        }
    }

}
