using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JovenesA.DomainClasses;

namespace JovenesA.DataAccess
{
  public interface IJovenesARepository
  {
    IQueryable<Admin> GetAdmins();
    IQueryable<Mentor> GetMentors();
    IQueryable<Student> GetStudents();
    IQueryable<Member> GetMembers();
    IQueryable<StudentDTO> GetStudentDTOs();
    IQueryable<Contact> GetContacts();
    IQueryable<Psychologist> GetPsychologists();

    IQueryable<RPT_MentorReport> GetRPT_MentorReports();
    IQueryable<RPT_StudentMentor> GetRPT_StudentMentors();
    IQueryable<MentorReport> GetMentorReports();
    IQueryable<QuarterlyAssessment> GetQuarterlyAssessments();

    bool Save();
    bool SaveAdmin(Admin admin);
    bool SaveMentor(Mentor mentor);
    bool SaveStudent(Student student);
    bool SaveContact(Contact contact);
    bool SavePsychologist(Psychologist psychologist);
    bool AddMentorReport(MentorReport newMentorReport);
    bool AddQuarterlyAssessment(QuarterlyAssessment newQuarterlyAssessment);
    bool SaveStudentMentor(StudentMentor studentMentor);
  }
}
