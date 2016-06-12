// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;
using JovenesA.DomainClasses;

namespace JovenesA.DataAccess
{
    // Mentors
    internal class AdminConfiguration : EntityTypeConfiguration<Admin>
    {
        public AdminConfiguration()
            : this("dbo")
        {
        }
 
        public AdminConfiguration(string schema)
        {
            ToTable(schema + ".Admins");
            HasKey(x => x.AdminId);

            Property(x => x.AdminId).HasColumnName("AdminID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.LastNames).HasColumnName("LastNames").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.FirstNames).HasColumnName("FirstNames").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.FullName).HasColumnName("FullName").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.AdminStatusId).HasColumnName("AdminStatusID").IsOptional().HasColumnType("int");
            Property(x => x.YearJoinedJa).HasColumnName("YearJoinedJA").IsOptional().HasColumnType("int");
            Property(x => x.SmaAddress).HasColumnName("SMA_Address").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.SmaPhone).HasColumnName("SMA_Phone").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.NonSmaAddress).HasColumnName("NonSMA_Address").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.NonSmaCity).HasColumnName("NonSMA_City").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.NonSmaStateProvince).HasColumnName("NonSMA_State_Province").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.NonSmaPostalCode).HasColumnName("NonSMA_PostalCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.NonSmaCountryId).HasColumnName("NonSMA_CountryID").IsOptional().HasColumnType("int");
            Property(x => x.NonSmaPhone).HasColumnName("NonSMA_Phone").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Email).HasColumnName("Email").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.BestWayToContactId).HasColumnName("BestWayToContactID").IsOptional().HasColumnType("int");
            Property(x => x.CountryOfResidenceID).HasColumnName("CountryOfResidenceID").IsOptional().HasColumnType("int");
            Property(x => x.MonthsinSma).HasColumnName("MonthsinSMA").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.CareerExperience).HasColumnName("CareerExperience").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.MentoringExperience).HasColumnName("MentoringExperience").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.OtherRelevantLifeExperience).HasColumnName("OtherRelevantLifeExperience").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.SpanishSkillLevelId).HasColumnName("SpanishSkillLevelID").IsOptional().HasColumnType("int");
            Property(x => x.EnglishSkillLevelId).HasColumnName("EnglishSkillLevelID").IsOptional().HasColumnType("int");
            Property(x => x.StudentPreferenceId).HasColumnName("StudentPreferenceID").IsOptional().HasColumnType("int");
            Property(x => x.UpdateDtTm).HasColumnName("UpdateDtTm").IsOptional().HasColumnType("datetime");
            Property(x => x.Timestamp).HasColumnName("Timestamp").IsOptional().HasColumnType("timestamp").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
        }
    }

}
