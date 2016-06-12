// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;
using JovenesA.DomainClasses;

namespace JovenesA.DataAccess
{
  // Prepas
  internal class PrepaConfiguration : EntityTypeConfiguration<Prepa>
    {
        public PrepaConfiguration()
            : this("dbo")
        {
        }
 
        public PrepaConfiguration(string schema)
        {
            ToTable(schema + ".Prepas");
            HasKey(x => x.PrepaId);

            Property(x => x.PrepaId).HasColumnName("PrepaID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PrepaAbbrev).HasColumnName("PrepaAbbrev").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.PrepaName).HasColumnName("PrepaName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.PrepaCity).HasColumnName("PrepaCity").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.UpdtDtTm).HasColumnName("UpdtDtTm").IsOptional().HasColumnType("datetime");
            Property(x => x.Timestamp).HasColumnName("Timestamp").IsOptional().HasColumnType("timestamp").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
        }
    }

}
