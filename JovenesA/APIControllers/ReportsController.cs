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

    public class ThreeColumnReport
    {

        public ThreeColumnReport() { }

        public string Column1 { get; set; }
        public string Column2 { get; set; }
        public string Column3 { get; set; }

    }

    public class ReportsController : ApiController
    {

        private IJovenesARepository _repo;

        public ReportsController(IJovenesARepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<ThreeColumnReport> Get(string reportName)
        {
            IQueryable<StudentDTO> results = _repo.GetStudentDTOs();
            List<ThreeColumnReport> rptResults = null;

            if (reportName == "rptStudentsByGenderByStatus")
            {
                rptResults = results
                    .GroupBy(grp => new { grp.Gender, grp.Status })
                    .Select(s1 => new ThreeColumnReport
                    {
                        Column1 = s1.FirstOrDefault().Gender,
                        Column2 = s1.FirstOrDefault().Status,
                        Column3 = s1.Count().ToString()
                    }).ToList();
            } else if (reportName == "rptStudentsByGenderByYearJoined")
            {
                rptResults = results
                    .GroupBy(grp => new { grp.Gender, grp.YearJoinedJa })
                    .Select(s1 => new ThreeColumnReport
                    {
                        Column1 = s1.FirstOrDefault().Gender,
                        Column2 = s1.FirstOrDefault().YearJoinedJa.ToString(),
                        Column3 = s1.Count().ToString()
                    }).ToList();
            }
            else if (reportName == "rptStudentsByStatusByYearJoined")
            {
                rptResults = results
                    .GroupBy(grp => new { grp.Status, grp.YearJoinedJa })
                    .Select(s1 => new ThreeColumnReport
                    {
                        Column1 = s1.FirstOrDefault().Status,
                        Column2 = s1.FirstOrDefault().YearJoinedJa.ToString(),
                        Column3 = s1.Count().ToString()
                    }).ToList();
            }
            return rptResults as IEnumerable<ThreeColumnReport>;
        }

    }
}
