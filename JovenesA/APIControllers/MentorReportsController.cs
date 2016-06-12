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
    public class MentorReportsController : ApiController
    {
        private IJovenesARepository _repo;

        public MentorReportsController(IJovenesARepository repo)
        {
            _repo = repo;
        }

        public HttpResponseMessage Get(int? mentorId, int? studentId)
        {
            IQueryable<MentorReport> results = _repo.GetMentorReports();
            IQueryable<RPT_MentorReport> results2 = _repo.GetRPT_MentorReports();

            IEnumerable<MentorReport> mentorReports  = null;
            IEnumerable<RPT_MentorReport> mentorReports2 = null;

            if (mentorId == 0 && studentId == 0)
            {
                mentorReports2 = results2
                                   .Take(50)
                                   .OrderByDescending(t => t.ReportDateTime)
                                   .ToList();

            }
            else if (mentorId == 0)
            {
                mentorReports = results.Where(t => t.StudentId == studentId)
                                   .OrderByDescending(t => t.ReportDateTime)
                                   .ToList();

            }
            else
            {
                mentorReports = results.Where(t => t.MentorId == mentorId && t.StudentId == studentId)
                                   .OrderByDescending(t => t.ReportDateTime)
                                   .ToList();
            }

            if (mentorReports != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, mentorReports);
            }
            else if (mentorReports2 != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, mentorReports2);
            }
            else
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }


        public HttpResponseMessage Post(MentorReport newMentorReport)
        {
            if (_repo.AddMentorReport(newMentorReport))
            {
                return Request.CreateResponse(HttpStatusCode.OK, newMentorReport);
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }

    }
}
