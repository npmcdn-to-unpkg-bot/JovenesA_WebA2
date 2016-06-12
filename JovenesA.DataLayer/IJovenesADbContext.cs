// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.Data.Entity;

using JovenesA.DomainClasses;

namespace JovenesA.DataAccess
{
  public interface IJovenesADbContext : IDisposable
    {
        IDbSet<CodeValue> CodeValues { get; set; } // CodeValues
        IDbSet<GradeMonth> GradeMonths { get; set; } // GradeMonths
        IDbSet<Member> Members { get; set; } // Members
        IDbSet<Mentor> Mentors { get; set; } // Mentors
        IDbSet<Admin> Admins { get; set; } // Admins
        IDbSet<Contact> Contacts { get; set; } // Contacts
        IDbSet<MentorReport> MentorReports { get; set; } // MentorReports
        IDbSet<Prepa> Prepas { get; set; } // Prepas
        IDbSet<Student> Students { get; set; } // Students
        IDbSet<StudentMentor> StudentsMentors { get; set; } // StudentsMentors
        IDbSet<StudentTransaction> StudentTransactions { get; set; } // StudentTransactions
        IDbSet<University> Universities { get; set; } // Universities
        IDbSet<UniversityTermType> UniversityTermTypes { get; set; } // UniversityTermTypes

        IDbSet<RPT_MentorReport> RPT_MentorReports { get; set; } // RPT_MentorReports
        IDbSet<RPT_StudentMentor> RPT_StudentMentors { get; set; } // RPT_StudentMentors
        //int SaveChanges();
        //Task<int> SaveChangesAsync();
        //Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        // Stored Procedures
    }

}
