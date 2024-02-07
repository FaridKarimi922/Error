using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaavSchool.Entitis.Entitis
{
    public class StudentCourses
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public Course Course { get; set; }

        public int CourseId { get; set; }




    }
}
