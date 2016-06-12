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
    public class StudentDTOsController : ApiController
    {
        private IJovenesARepository _repo;

        public StudentDTOsController(IJovenesARepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<StudentDTO> Get()
        {
            IQueryable<StudentDTO> results = _repo.GetStudentDTOs();
            var students = results.OrderBy(t => t.StudentName)
                                .ToList();
            return students;
        }

        public IEnumerable<StudentDTO> Get(int? statusId, int? gradYear, int? yearJoinedJA)
        {
            IQueryable<StudentDTO> results = _repo.GetStudentDTOs();
            IEnumerable<StudentDTO> studentDTOs;
            if (gradYear == 0 && yearJoinedJA == 0)
            {
                studentDTOs = results.Where(s => s.StatusID == statusId)
                    .OrderBy(t => t.StudentName)
                    .ToList();
            }
            else if (gradYear != 0 && yearJoinedJA == 0)
            {
                studentDTOs = results.Where(s => s.StatusID == statusId 
                                            && s.GradYear == gradYear)
                    .OrderBy(t => t.StudentName)
                    .ToList();
            }
            else if (gradYear == 0 && yearJoinedJA != 0)
            {
                studentDTOs = results.Where(s => s.StatusID == statusId 
                                            && s.YearJoinedJa == yearJoinedJA)
                    .OrderBy(t => t.StudentName)
                    .ToList();
            }
            else // if  (gradYear != 0 && yearJoinedJA != 0)
            {
                studentDTOs = results.Where(s => s.StatusID == statusId 
                                            && s.GradYear == gradYear
                                            && s.YearJoinedJa == yearJoinedJA)
                    .OrderBy(t => t.StudentName)
                    .ToList();
            }
            return studentDTOs;
        }

        //public class StudentsByGenderByYearJoined
        //{

        //    public StudentsByGenderByYearJoined() { }

        //    public string Gender { get; set; }
        //    public int Count { get; set; }
        //    public string Status { get; set; }
        //}

        //public IEnumerable<StudentsByGenderByYearJoined> Get(string reportName)
        //{
        //    IQueryable<StudentDTO> results = _repo.GetStudentDTOs();
        //    //IEnumerable<StudentDTO> groupedResults = null;

        //    //if (reportName == "rptStudentsByGenderByYearJoined")
        //    //{
        //    List<StudentsByGenderByYearJoined> rptResults = results
        //            .GroupBy(grp => grp.Gender)
        //            .Select(s1 => new StudentsByGenderByYearJoined
        //            {
        //                Gender = s1.FirstOrDefault().Gender,
        //                Count = s1.Count()//,
        //                //Status = s1.Status
        //            }).ToList();
        //    //}
        //    return rptResults as IEnumerable<StudentsByGenderByYearJoined>;
        //}
    }
}
