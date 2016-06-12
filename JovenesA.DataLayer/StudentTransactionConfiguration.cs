// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;
using JovenesA.DomainClasses;

namespace JovenesA.DataAccess
{
  // StudentTransactions
  internal class StudentTransactionConfiguration : EntityTypeConfiguration<StudentTransaction>
    {
        public StudentTransactionConfiguration()
            : this("dbo")
        {
        }
 
        public StudentTransactionConfiguration(string schema)
        {
            ToTable(schema + ".StudentTransactions");
            HasKey(x => x.StudentTransactionId);

            Property(x => x.StudentTransactionId).HasColumnName("StudentTransactionID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.StudentId).HasColumnName("StudentID").IsRequired().HasColumnType("int");
            Property(x => x.TransctionTypeId).HasColumnName("TransctionTypeID").IsOptional().HasColumnType("int");
            Property(x => x.TransactionAmount).HasColumnName("TransactionAmount").IsOptional().HasColumnType("money").HasPrecision(19,4);
            Property(x => x.UpdateDtTm).HasColumnName("UpdateDtTm").IsOptional().HasColumnType("datetime");
            Property(x => x.Timestamp).HasColumnName("Timestamp").IsOptional().HasColumnType("timestamp").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
        }
    }

}
