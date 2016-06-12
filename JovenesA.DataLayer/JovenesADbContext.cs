// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using JovenesA.DomainClasses;

namespace JovenesA.DataAccess
{
  public class JovenesADbContext : IdentityDbContext<IdentityUser>, IJovenesADbContext
    {
        public IDbSet<CodeValue> CodeValues { get; set; } // CodeValues
        public IDbSet<GradeMonth> GradeMonths { get; set; } // GradeMonths
        public IDbSet<Member> Members { get; set; } // Members
        public IDbSet<Mentor> Mentors { get; set; } // Mentors
        public IDbSet<Admin> Admins { get; set; } // Admins
        public IDbSet<Contact> Contacts { get; set; } // Contacts
        public IDbSet<Psychologist> Psychologists { get; set; } // Psychologists
        public IDbSet<QuarterlyAssessment> QuarterlyAssessments { get; set; } // QuarterlyAssessments
        public IDbSet<MentorReport> MentorReports { get; set; } // MentorReports
        public IDbSet<Prepa> Prepas { get; set; } // Prepas
        public IDbSet<Student> Students { get; set; } // Students
        public IDbSet<StudentDTO> StudentDTOs { get; set; } // StudentDTOs
        public IDbSet<StudentMentor> StudentsMentors { get; set; } // StudentsMentors
        public IDbSet<StudentTransaction> StudentTransactions { get; set; } // StudentTransactions
        public IDbSet<University> Universities { get; set; } // Universities
        public IDbSet<UniversityTermType> UniversityTermTypes { get; set; } // UniversityTermTypes

        public IDbSet<RPT_MentorReport> RPT_MentorReports { get; set; } // MentorReports
        public IDbSet<RPT_StudentMentor> RPT_StudentMentors { get; set; } // StudentMentors

        static JovenesADbContext()
        {
            System.Data.Entity.Database.SetInitializer<JovenesADbContext>(null);
        }

        public JovenesADbContext()
            : base("Name=JovenesADbContext") // web.config connectionstring
        {
        }

        public JovenesADbContext(string connectionString) : base(connectionString)
        {
        }

        public JovenesADbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CodeValueConfiguration());
            modelBuilder.Configurations.Add(new GradeMonthConfiguration());
            modelBuilder.Configurations.Add(new MemberConfiguration());
            modelBuilder.Configurations.Add(new AdminConfiguration());
            modelBuilder.Configurations.Add(new ContactConfiguration());
            modelBuilder.Configurations.Add(new MentorConfiguration());
            modelBuilder.Configurations.Add(new PsychologistConfiguration());
            modelBuilder.Configurations.Add(new MentorReportConfiguration());
            modelBuilder.Configurations.Add(new QuarterlyAssessmentConfiguration());
            modelBuilder.Configurations.Add(new PrepaConfiguration());
            modelBuilder.Configurations.Add(new StudentConfiguration());
            modelBuilder.Configurations.Add(new StudentDTOConfiguration());
            modelBuilder.Configurations.Add(new StudentMentorConfiguration());
            modelBuilder.Configurations.Add(new StudentTransactionConfiguration());
            modelBuilder.Configurations.Add(new UniversityConfiguration());
            modelBuilder.Configurations.Add(new UniversityTermTypeConfiguration());
            modelBuilder.Configurations.Add(new RPT_MentorReportConfiguration());
            modelBuilder.Configurations.Add(new RPT_StudentMentorConfiguration());
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new CodeValueConfiguration(schema));
            modelBuilder.Configurations.Add(new GradeMonthConfiguration(schema));
            modelBuilder.Configurations.Add(new MemberConfiguration(schema));
            modelBuilder.Configurations.Add(new AdminConfiguration(schema));
            modelBuilder.Configurations.Add(new ContactConfiguration(schema));
            modelBuilder.Configurations.Add(new MentorConfiguration(schema));
            modelBuilder.Configurations.Add(new PsychologistConfiguration(schema));
            modelBuilder.Configurations.Add(new MentorReportConfiguration(schema));
            modelBuilder.Configurations.Add(new QuarterlyAssessmentConfiguration(schema));
            modelBuilder.Configurations.Add(new PrepaConfiguration(schema));
            modelBuilder.Configurations.Add(new StudentConfiguration(schema));
            modelBuilder.Configurations.Add(new StudentDTOConfiguration(schema));
            modelBuilder.Configurations.Add(new StudentMentorConfiguration(schema));
            modelBuilder.Configurations.Add(new StudentTransactionConfiguration(schema));
            modelBuilder.Configurations.Add(new UniversityConfiguration(schema));
            modelBuilder.Configurations.Add(new UniversityTermTypeConfiguration(schema));
            modelBuilder.Configurations.Add(new RPT_MentorReportConfiguration(schema));
            modelBuilder.Configurations.Add(new RPT_StudentMentorConfiguration(schema));
            return modelBuilder;
        }
        
        // Stored Procedures
    }
}
