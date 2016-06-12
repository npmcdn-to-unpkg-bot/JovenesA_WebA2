using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using JovenesA.DomainClasses;

namespace JovenesA.Models
{
    public class StudentsViewModel
    {

        public int studentMemberId
        {
            get;
            set;
        }
        public int studentId
        {
            get;
            set;
        }
        public Student student
        {
            get;
            set;
        }

    }

}
