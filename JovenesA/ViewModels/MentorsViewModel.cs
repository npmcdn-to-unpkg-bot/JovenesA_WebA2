using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using JovenesA.DomainClasses;

namespace JovenesA.Models
{
    public class MentorsViewModel
    {

        public int mentorId { get;
            set; }
        public int studentId { get;
            set; }

        public IEnumerable<RPT_StudentMentor> rpt_StudentMentors { get;
            set; }

    }

}
