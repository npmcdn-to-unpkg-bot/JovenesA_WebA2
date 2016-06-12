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
    public class PsychologistsController : ApiController
    {
        private IJovenesARepository _repo;

        public PsychologistsController(IJovenesARepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Psychologist> Get()
        {
            IQueryable<Psychologist> results = _repo.GetPsychologists();
            var psychologists = results.OrderBy(t => t.LastNames).ThenBy(t => t.FirstNames)
                                .Take(1000)
                                .ToList();
            return psychologists;
        }

        public HttpResponseMessage Get(int id)
        {
            IQueryable<Psychologist> results = _repo.GetPsychologists();
            var Psychologist = results.Where(t => t.PsychologistId == id).FirstOrDefault();
            if (Psychologist != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, Psychologist);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        public HttpResponseMessage Post([FromBody]Psychologist updPsychologist)
        {
            if (_repo.SavePsychologist(updPsychologist))
            {
                return Request.CreateResponse(HttpStatusCode.OK, updPsychologist);
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }


    }
}
