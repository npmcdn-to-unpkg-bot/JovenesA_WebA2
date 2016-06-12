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
    public class StudentsController : ApiController
    {
        private IJovenesARepository _repo;

        public StudentsController(IJovenesARepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Student> Get()
        {
            IQueryable<Student> results = _repo.GetStudents();
            var students = results.OrderBy(t => t.LastNames).ThenBy(t => t.FirstNames)
                                .Take(25)
                                .ToList();
            return students;
        }

        public IEnumerable<Student> Get(int? gradYear, int? yearJoinedJA)
        {
            IQueryable<Student> results = _repo.GetStudents();
            IEnumerable<Student> students;
            if (gradYear != 0)
            {
                students = results.Where(t => t.GradYear == gradYear)
                    .OrderBy(t => t.LastNames).ThenBy(t => t.FirstNames)
                    .ToList();
            } 
            else
            {
                students = results.Where(t => t.YearJoinedJa == yearJoinedJA)
                    .OrderBy(t => t.LastNames).ThenBy(t => t.FirstNames)
                    .ToList();
            }
            return students;
        }

        public HttpResponseMessage Get(int id)
        {
            IQueryable<Student> results = _repo.GetStudents();
            var Student = results.Where(t => t.StudentId == id).FirstOrDefault();
            if (Student != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, Student);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        public HttpResponseMessage Post([FromBody]Student updStudent)
        {
            if (_repo.SaveStudent(updStudent))
            {
                return Request.CreateResponse(HttpStatusCode.OK, updStudent);
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }


    }
}
