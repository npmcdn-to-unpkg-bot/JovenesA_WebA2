using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using JovenesA.DomainClasses;

namespace JovenesA.Models
{
    public class PsychologistsViewModel
    {

        public int psychologistId
        {
            get;
            set;
        }
        public int studentId
        {
            get;
            set;
        }
    }

}
