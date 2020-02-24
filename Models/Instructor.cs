using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jw414515MIS4200.Models
{
    public class Instructor
    {
        public int instructorID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string subject { get; set; }
        public decimal salary { get; set; }
        public ICollection<CourseDetail> CourseDetail { get; set; }

    }
}