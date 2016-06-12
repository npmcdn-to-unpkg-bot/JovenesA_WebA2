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
    public class MentorsController : ApiController
    {
        private IJovenesARepository _repo;

        public MentorsController(IJovenesARepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Mentor> Get()
        {
            IQueryable<Mentor> results = _repo.GetMentors();
            var mentors = results.OrderBy(t => t.LastNames).ThenBy(t => t.FirstNames)
                                .Take(1000)
                                .ToList();
            return mentors;
        }

        public HttpResponseMessage Get(int id)
        {
            IQueryable<Mentor> results = _repo.GetMentors();
            var Mentor = results.Where(t => t.MentorId == id).FirstOrDefault();
            if (Mentor != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, Mentor);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        public HttpResponseMessage Post([FromBody]Mentor updMentor)
        {
            if (_repo.SaveMentor(updMentor))
            {
                return Request.CreateResponse(HttpStatusCode.OK, updMentor);
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }


    }
}
