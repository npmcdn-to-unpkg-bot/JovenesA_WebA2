// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;
using JovenesA.DomainClasses;

namespace JovenesA.DataAccess
{
  // UniversityTermTypes
  internal class UniversityTermTypeConfiguration : EntityTypeConfiguration<UniversityTermType>
    {
        public UniversityTermTypeConfiguration()
            : this("dbo")
        {
        }
 
        public UniversityTermTypeConfiguration(string schema)
        {
            ToTable(schema + ".UniversityTermTypes");
            HasKey(x => x.UniversityTermTypeId);

            Property(x => x.UniversityTermTypeId).HasColumnName("UniversityTermTypeID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.UniversityId).HasColumnName("UniversityID").IsOptional().HasColumnType("int");
            Property(x => x.TermTypeId).HasColumnName("TermTypeID").IsOptional().HasColumnType("int");
        }
    }

}
