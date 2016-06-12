// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;
using JovenesA.DomainClasses;

namespace JovenesA.DataAccess
{
  // GradeMonths
  internal class GradeMonthConfiguration : EntityTypeConfiguration<GradeMonth>
    {
        public GradeMonthConfiguration()
            : this("dbo")
        {
        }
 
        public GradeMonthConfiguration(string schema)
        {
            ToTable(schema + ".GradeMonths");
            HasKey(x => x.GradeMonthsId);

            Property(x => x.GradeMonthsId).HasColumnName("GradeMonthsID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AcademicYearTypeId).HasColumnName("AcademicYearTypeID").IsOptional().HasColumnType("int");
            Property(x => x.GradeMonths).HasColumnName("GradeMonths").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Jan).HasColumnName("Jan").IsOptional().HasColumnType("tinyint");
            Property(x => x.Feb).HasColumnName("Feb").IsOptional().HasColumnType("tinyint");
            Property(x => x.Mar).HasColumnName("Mar").IsOptional().HasColumnType("tinyint");
            Property(x => x.Apr).HasColumnName("Apr").IsOptional().HasColumnType("tinyint");
            Property(x => x.May).HasColumnName("May").IsOptional().HasColumnType("tinyint");
            Property(x => x.Jun).HasColumnName("Jun").IsOptional().HasColumnType("tinyint");
            Property(x => x.Jul).HasColumnName("Jul").IsOptional().HasColumnType("tinyint");
            Property(x => x.Aug).HasColumnName("Aug").IsOptional().HasColumnType("tinyint");
            Property(x => x.Sep).HasColumnName("Sep").IsOptional().HasColumnType("tinyint");
            Property(x => x.Oct).HasColumnName("Oct").IsOptional().HasColumnType("tinyint");
            Property(x => x.Nov).HasColumnName("Nov").IsOptional().HasColumnType("tinyint");
            Property(x => x.Dec).HasColumnName("Dec").IsOptional().HasColumnType("tinyint");
        }
    }

}
