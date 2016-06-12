using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JovenesA.DomainClasses;

namespace JovenesA.DataAccess
{
    public class JovenesARepository : IJovenesARepository
    {
        JovenesADbContext _ctx;

        public JovenesARepository()
        {
            _ctx = new JovenesADbContext();
        }

        public JovenesARepository(JovenesADbContext ctx)
        {
            _ctx = ctx;
        }

        public IQueryable<Admin> GetAdmins()
        {
            return _ctx.Admins;
        }
        public IQueryable<Mentor> GetMentors()
        {
            return _ctx.Mentors;
        }
        public IQueryable<Member> GetMembers()
        {
            return _ctx.Members;
        }

        public IQueryable<Student> GetStudents()
        {
            return _ctx.Students;
        }

        public IQueryable<Psychologist> GetPsychologists()
        {
            return _ctx.Psychologists;
        }

        public IQueryable<StudentDTO> GetStudentDTOs()
        {
            return _ctx.StudentDTOs;
        }

        public IQueryable<Contact> GetContacts()
        {
            return _ctx.Contacts;
        }

        public IQueryable<RPT_MentorReport> GetRPT_MentorReports()
        {
            return _ctx.RPT_MentorReports;
        }
        public IQueryable<RPT_StudentMentor> GetRPT_StudentMentors()
        {
            return _ctx.RPT_StudentMentors;
        }

        public bool Save()
        {
            try
            {
                int i;
                i = _ctx.SaveChanges();
                return i > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool SaveMentor(Mentor mentor)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("REPO: SaveMentor()");
                _ctx.Entry(mentor).State = System.Data.Entity.EntityState.Modified;
                return _ctx.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public bool SaveAdmin(Admin admin)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("REPO: SaveAdmin()");
                _ctx.Entry(admin).State = System.Data.Entity.EntityState.Modified;
                return _ctx.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public bool SaveStudent(Student student)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("REPO: SaveStudent()");
                _ctx.Entry(student).State = System.Data.Entity.EntityState.Modified;
                return _ctx.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return false;
            }
        }
        public bool SaveContact(Contact contact)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("REPO: SaveContactt()");
                _ctx.Entry(contact).State = System.Data.Entity.EntityState.Modified;
                return _ctx.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public bool SavePsychologist(Psychologist psychologist)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("REPO: SavePsychologist()");
                _ctx.Entry(psychologist).State = System.Data.Entity.EntityState.Modified;
                return _ctx.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return false;
            }
        }
        //
        // MentorReports
        //
        public IQueryable<MentorReport> GetMentorReports()
        {
            System.Diagnostics.Debug.WriteLine("REPO: GetMentorReports()");
            return _ctx.MentorReports;
        }

        public bool AddMentorReport(MentorReport newMentorReport)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("REPO: addMentorReports()");
                _ctx.MentorReports.Add(newMentorReport);
                return _ctx.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool SaveStudentMentor(StudentMentor studentMentor)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("REPO: SaveStudentMentor()");
                _ctx.Entry(studentMentor).State = System.Data.Entity.EntityState.Modified;
                return _ctx.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return false;
            }
        }
        //
        // QuarterlyAssessments
        //
        public IQueryable<QuarterlyAssessment> GetQuarterlyAssessments()
        {
            System.Diagnostics.Debug.WriteLine("REPO: GetQuarterlyAssessments()");
            return _ctx.QuarterlyAssessments;
        }

        public bool AddQuarterlyAssessment(QuarterlyAssessment newQuarterlyAssessment)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("REPO: addQuarterlyAssessments()");
                _ctx.QuarterlyAssessments.Add(newQuarterlyAssessment);
                return _ctx.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

    }
}