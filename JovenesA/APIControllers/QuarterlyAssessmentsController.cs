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
    public class QuarterlyAssessmentsController : ApiController
    {
        private IJovenesARepository _repo;

        public QuarterlyAssessmentsController(IJovenesARepository repo)
        {
            _repo = repo;
        }

        //public IEnumerable<QuarterlyAssessment> Get(int psychologistId, int studentId)
        //{
        //    IQueryable<QuarterlyAssessment> results;

        //    System.Diagnostics.Debug.WriteLine("QuarterlyAssessments API Controller Get QuarterlyAssessment");
        //    results = _repo.GetQuarterlyAssessments(psychologistId, studentId);

        //    var quarterlyAssessments = results.OrderByDescending(t => t.ReportDateTime)//.First() as IEnumerable<QuarterlyAssessment>;
        //                        .Take(1)
        //                        .ToList();

        //    return quarterlyAssessments; // Request.CreateResponse(HttpStatusCode.OK, QuarterlyAssessment);

        //}


        public HttpResponseMessage Get(int psychologistId, int studentId)
        {
            IQueryable<QuarterlyAssessment> results = _repo.GetQuarterlyAssessments();

            IEnumerable<QuarterlyAssessment> quarterlyAssessments;

            if (psychologistId == 0)
            {
                quarterlyAssessments = results.Where(t => t.StudentId == studentId)
                                   .OrderByDescending(t => t.ReportDateTime)
                                   .Take(100)
                                   .ToList();

            }
            else if (studentId == 0)
            {
                quarterlyAssessments = results.Where(t => t.PsychologistId == psychologistId)
                                   .OrderByDescending(t => t.ReportDateTime)
                                   .Take(100)
                                   .ToList();

            }
            else
            {
                quarterlyAssessments = results.Where(t => t.PsychologistId == psychologistId && t.StudentId == studentId)
                                   .OrderByDescending(t => t.ReportDateTime)
                                   .Take(100)
                                   .ToList();
            }

            if (quarterlyAssessments != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, quarterlyAssessments);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }


        public HttpResponseMessage Post(QuarterlyAssessment newQuarterlyAssessment)
        {
            if (_repo.AddQuarterlyAssessment(newQuarterlyAssessment))
            {
                return Request.CreateResponse(HttpStatusCode.OK, newQuarterlyAssessment);
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }

    }
}
