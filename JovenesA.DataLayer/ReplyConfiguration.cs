// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;
using JovenesA.DomainClasses;

namespace JovenesA.DataAccess
{
  // Replies
  internal class ReplyConfiguration : EntityTypeConfiguration<Reply>
    {
        public ReplyConfiguration()
            : this("dbo")
        {
        }
 
        public ReplyConfiguration(string schema)
        {
            ToTable(schema + ".Replies");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Body).HasColumnName("Body").IsOptional().HasColumnType("nvarchar");
            Property(x => x.Created).HasColumnName("Created").IsRequired().HasColumnType("datetime");
            Property(x => x.TopicId).HasColumnName("TopicId").IsRequired().HasColumnType("int");

            // Foreign keys
            //HasRequired(a => a.Topic).WithMany(b => b.Replies).HasForeignKey(c => c.TopicId); // FK_dbo.Replies_dbo.Topics_TopicId
        }
    }

}
