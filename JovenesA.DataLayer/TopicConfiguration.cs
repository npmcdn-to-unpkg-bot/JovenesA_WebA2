// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;
using JovenesA.DomainClasses;

namespace JovenesA.DataAccess
{
  // Topics
  internal class TopicConfiguration : EntityTypeConfiguration<Topic>
    {
        public TopicConfiguration()
            : this("dbo")
        {
        }
 
        public TopicConfiguration(string schema)
        {
            ToTable(schema + ".Topics");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Title).HasColumnName("Title").IsOptional().HasColumnType("nvarchar");
            Property(x => x.Body).HasColumnName("Body").IsOptional().HasColumnType("nvarchar");
            Property(x => x.Created).HasColumnName("Created").IsRequired().HasColumnType("datetime");
            Property(x => x.Flagged).HasColumnName("Flagged").IsRequired().HasColumnType("bit");
        }
    }

}
