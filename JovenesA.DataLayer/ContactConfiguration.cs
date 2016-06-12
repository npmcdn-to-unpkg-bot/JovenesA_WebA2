// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;
using JovenesA.DomainClasses;

namespace JovenesA.DataAccess
{
    // Contacts
    internal class ContactConfiguration : EntityTypeConfiguration<Contact>
    {
        public ContactConfiguration()
            : this("dbo")
        {
        }
 
        public ContactConfiguration(string schema)
        {
            ToTable(schema + ".Contacts");
            HasKey(x => x.ContactId);

            Property(x => x.ContactId).HasColumnName("ContactID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.LastNames).HasColumnName("LastNames").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.FirstNames).HasColumnName("FirstNames").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ContactStatusId).HasColumnName("ContactStatusID").IsOptional().HasColumnType("int");
            Property(x => x.SmaPhone).HasColumnName("SMA_Phone").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.NonSmaPhone).HasColumnName("NonSMA_Phone").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Email).HasColumnName("Email").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Comments).HasColumnName("Comments").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.UpdateDtTm).HasColumnName("UpdateDtTm").IsOptional().HasColumnType("datetime");
        }
    }

}
