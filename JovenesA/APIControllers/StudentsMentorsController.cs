using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JovenesA.DataAccess;
using JovenesA.DomainClasses;


namespace JovenesA.Controllers
{
    public class StudentsMentorsController : ApiController
    {
        private IJovenesARepository _repo;

        public StudentsMentorsController(IJovenesARepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<RPT_StudentMentor> Get()
        {
            IQueryable<RPT_StudentMentor> results = _repo.GetRPT_StudentMentors();
            var studentMentors = results.OrderBy(t => t.MentorLastNames).ThenBy(t => t.MentorFirstNames)
                               .Take(25)
                               .ToList();
            return studentMentors;
        }

        public HttpResponseMessage Get(int studentId)
        {
            IQueryable<RPT_StudentMentor> results = _repo.GetRPT_StudentMentors();
            var studentMentor = results.Where(t => t.StudentId == studentId).FirstOrDefault();
            if (studentMentor != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, studentMentor);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        public HttpResponseMessage Post(StudentMentor newStudentMentor)
        {
            if (_repo.SaveStudentMentor(newStudentMentor))
            {
                return Request.CreateResponse(HttpStatusCode.OK, newStudentMentor);
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }

    }
}
