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
    public class MembersController : ApiController
    {
        private IJovenesARepository _repo;

        public MembersController(IJovenesARepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Member> Get()
        {
            IQueryable<Member> results = _repo.GetMembers();
            var members = results.OrderBy(t => t.LastNames).ThenBy(t => t.FirstNames)
                                .Take(1000)
                                .ToList();
            return members;
        }

    }
}
