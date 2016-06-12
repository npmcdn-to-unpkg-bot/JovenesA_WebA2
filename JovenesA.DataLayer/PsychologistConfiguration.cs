// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;
using JovenesA.DomainClasses;

namespace JovenesA.DataAccess
{
    // Psychologists
    internal class PsychologistConfiguration : EntityTypeConfiguration<Psychologist>
    {
        public PsychologistConfiguration()
            : this("dbo")
        {
        }
 
        public PsychologistConfiguration(string schema)
        {
            ToTable(schema + ".Psychologists");
            HasKey(x => x.PsychologistId);

            Property(x => x.PsychologistId).HasColumnName("PsychologistID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.LastNames).HasColumnName("LastNames").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.FirstNames).HasColumnName("FirstNames").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.FullName).HasColumnName("FullName").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.PsychologistStatusId).HasColumnName("PsychologistStatusID").IsOptional().HasColumnType("int");
            Property(x => x.YearJoinedJa).HasColumnName("YearJoinedJA").IsOptional().HasColumnType("int");
            Property(x => x.SmaAddress).HasColumnName("SMA_Address").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.SmaPhone).HasColumnName("SMA_Phone").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Email).HasColumnName("Email").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.BestWayToContactId).HasColumnName("BestWayToContactID").IsOptional().HasColumnType("int");
            Property(x => x.EnglishSkillLevelId).HasColumnName("EnglishSkillLevelID").IsOptional().HasColumnType("int");
            Property(x => x.UpdateDtTm).HasColumnName("UpdateDtTm").IsOptional().HasColumnType("datetime");
            Property(x => x.Timestamp).HasColumnName("Timestamp").IsOptional().HasColumnType("timestamp").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
        }
    }

}
