// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;
using JovenesA.DomainClasses;

namespace JovenesA.DataAccess
{
  // Universities
  internal class UniversityConfiguration : EntityTypeConfiguration<University>
    {
        public UniversityConfiguration()
            : this("dbo")
        {
        }
 
        public UniversityConfiguration(string schema)
        {
            ToTable(schema + ".Universities");
            HasKey(x => new { x.UniversityId, x.AcademicYearTypeId });

            Property(x => x.UniversityId).HasColumnName("UniversityID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.UniversityAbbrev).HasColumnName("UniversityAbbrev").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.UniversityName).HasColumnName("UniversityName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.UniversityCity).HasColumnName("UniversityCity").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.AcademicYearTypeId).HasColumnName("AcademicYearTypeID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.GradeMonthsId).HasColumnName("GradeMonthsID").IsOptional().HasColumnType("int");
            Property(x => x.UpdtDtTm).HasColumnName("UpdtDtTm").IsOptional().HasColumnType("datetime");
            Property(x => x.Timestamp).HasColumnName("Timestamp").IsOptional().HasColumnType("timestamp").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
        }
    }

}
