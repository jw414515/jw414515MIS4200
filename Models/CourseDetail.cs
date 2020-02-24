using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jw414515MIS4200.Models
{
    public class CourseDetail
    {
        public int coursedetailID { get; set; }
        public decimal price { get; set; }

        public int courseID { get; set; }
        public virtual Course Course { get; set; }
        public int instructorID { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}