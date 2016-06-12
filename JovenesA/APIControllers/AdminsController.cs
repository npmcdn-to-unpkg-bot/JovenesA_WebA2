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
    public class AdminsController : ApiController
    {
        private IJovenesARepository _repo;

        public AdminsController(IJovenesARepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Admin> Get()
        {
            IQueryable<Admin> results = _repo.GetAdmins();
            var admins = results.OrderBy(t => t.FullName)
                                .Take(25)
                                .ToList();
            return admins;
        }

        public HttpResponseMessage Get(int id)
        {
            IQueryable<Admin> results = _repo.GetAdmins();
            var Admin = results.Where(t => t.AdminId == id).FirstOrDefault();
            if (Admin != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, Admin);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        public HttpResponseMessage Post([FromBody]Admin updAdmin)
        {
            if (_repo.SaveAdmin(updAdmin))
            {
                return Request.CreateResponse(HttpStatusCode.OK, updAdmin);
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }


    }
}
