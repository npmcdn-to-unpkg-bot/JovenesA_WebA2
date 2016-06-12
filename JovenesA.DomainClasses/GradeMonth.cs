// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
//using System.Data.Entity.ModelConfiguration;
using System.Threading;
using System.Threading.Tasks;
//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace JovenesA.DomainClasses
{
    // GradeMonths
    public class GradeMonth
    {
        public int GradeMonthsId { get; set; } // GradeMonthsID (Primary key)
        public int? AcademicYearTypeId { get; set; } // AcademicYearTypeID
        public string GradeMonths { get; set; } // GradeMonths
        public byte? Jan { get; set; } // Jan
        public byte? Feb { get; set; } // Feb
        public byte? Mar { get; set; } // Mar
        public byte? Apr { get; set; } // Apr
        public byte? May { get; set; } // May
        public byte? Jun { get; set; } // Jun
        public byte? Jul { get; set; } // Jul
        public byte? Aug { get; set; } // Aug
        public byte? Sep { get; set; } // Sep
        public byte? Oct { get; set; } // Oct
        public byte? Nov { get; set; } // Nov
        public byte? Dec { get; set; } // Dec
        
        public GradeMonth()
        {
            GradeMonths = "0";
            Jan = 0;
            Feb = 0;
            Mar = 0;
            Apr = 0;
            May = 0;
            Jun = 0;
            Jul = 0;
            Aug = 0;
            Sep = 0;
            Oct = 0;
            Nov = 0;
            Dec = 0;
        }
    }

}
