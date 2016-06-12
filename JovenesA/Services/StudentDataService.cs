using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JovenesA.DomainClasses;
using JovenesA.DataAccess;

namespace JovenesA.Services
{
    public class StudentDataService
    {
        JovenesARepository _repo;

        public StudentDataService()
        {
            _repo = new JovenesARepository();
        }

        public StudentDataService(IJovenesARepository repo)
        {
            _repo = repo as JovenesARepository;
        }

        public IEnumerable<RPT_StudentMentor> GetStudentsForThisMentor(int mentorId)
        {
            IQueryable<RPT_StudentMentor> results = _repo.GetRPT_StudentMentors();
            results = results.Where(r => r.MentorId == mentorId);
            var RPT_StudentMentors = results.ToList();
            return RPT_StudentMentors;
        }

        public int GetStudentId(int memberId)
        {
            IQueryable<Member> results = _repo.GetMembers();
            results = results.Where(r => r.MemberId == memberId);
            var member = results.ToList().FirstOrDefault();
            int studentId = member.StudentId ?? 0;
            return studentId;
        }
        public Student GetStudent(int id)
        {
            IQueryable<Student> results = _repo.GetStudents();
            var student = results.Where(t => t.StudentId == id).FirstOrDefault();
            return student;
        }


    }
}
