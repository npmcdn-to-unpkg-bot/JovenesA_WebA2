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
    public class ContactsController : ApiController
    {
        private IJovenesARepository _repo;

        public ContactsController(IJovenesARepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Contact> Get()
        {
            IQueryable<Contact> results = _repo.GetContacts();
            var contacts = results.OrderBy(t => t.LastNames).ThenBy(t => t.FirstNames)
                                .Take(1000)
                                .ToList();
            return contacts;
        }

        public HttpResponseMessage Get(int contactId)
        {
            IQueryable<Contact> results = _repo.GetContacts();
            var Contact = results.Where(t => t.ContactId == contactId).FirstOrDefault();
            if (Contact != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, Contact);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        public HttpResponseMessage Post([FromBody]Contact updContact)
        {
            if (_repo.SaveContact(updContact))
            {
                return Request.CreateResponse(HttpStatusCode.OK, updContact);
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }


    }
}
