// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;
using JovenesA.DomainClasses;

namespace JovenesA.DataAccess
{
    // CodeValues
    internal class CodeValueConfiguration : EntityTypeConfiguration<CodeValue>
    {
        public CodeValueConfiguration()
            : this("dbo")
        {
        }
 
        public CodeValueConfiguration(string schema)
        {
            ToTable(schema + ".CodeValues");
            HasKey(x => x.CodeValueId);

            Property(x => x.CodeValueId).HasColumnName("CodeValueID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CodeSet).HasColumnName("CodeSet").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.KeyValue).HasColumnName("KeyValue").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.StringValue).HasColumnName("StringValue").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.EsStringValue).HasColumnName("EsStringValue").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IntValue).HasColumnName("IntValue").IsOptional().HasColumnType("int");
            Property(x => x.DateTimeValue).HasColumnName("DateTimeValue").IsOptional().HasColumnType("datetime");
        }
    }

}
