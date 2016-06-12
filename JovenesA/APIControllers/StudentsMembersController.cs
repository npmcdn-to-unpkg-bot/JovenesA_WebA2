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
    public class StudentsMembersController : ApiController
    {
        private IJovenesARepository _repo;

        public StudentsMembersController(IJovenesARepository repo)
        {
            _repo = repo;
        }

        //public HttpResponseMessage Get(int memberId)
        //{
        //    IQueryable<Student> results = _repo.GetStudentFromMember();
        //    var student = results.FirstOrDefault();
        //    if (student != null)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.OK, student);
        //    }
        //    return Request.CreateResponse(HttpStatusCode.NotFound);
        //}

    }
}
