using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using jw414515MIS4200.Models;
using System.Data.Entity;

namespace jw414515MIS4200.DAL
{
    public class Context2 : DbContext
    {
        public Context2() : base ("name=DefaultConnection")
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<CourseDetail> CourseDetails { get; set; }
    }
}