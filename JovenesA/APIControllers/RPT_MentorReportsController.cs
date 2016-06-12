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
    public class RPT_MentorReportsController : ApiController
    {
        private IJovenesARepository _repo;

        public RPT_MentorReportsController(IJovenesARepository repo)
        {
            _repo = repo;
        }

        //public IEnumerable<MentorReport> Get(int mentorId, int studentId)
        //{
        //    IQueryable<MentorReport> results;

        //    System.Diagnostics.Debug.WriteLine("MentorReports API Controller Get MentorReport");
        //    results = _repo.GetMentorReports(mentorId, studentId);

        //    var mentorReports = results.OrderByDescending(t => t.ReportDateTime)//.First() as IEnumerable<MentorReport>;
        //                        .Take(1)
        //                        .ToList();

        //    return mentorReports; // Request.CreateResponse(HttpStatusCode.OK, MentorReport);

        //}


        public HttpResponseMessage Get(int? mentorId, int? studentId)
        {
            IQueryable<RPT_MentorReport> results = _repo.GetRPT_MentorReports();

            IEnumerable<RPT_MentorReport> mentorReports;

            if (mentorId == 0 && studentId == 0)
            {
                mentorReports = results
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
