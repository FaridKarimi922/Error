using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaavSchool.Entitis.Entitis
{
    public class TeacherCourses
    {
        public int Id { get; set; }
        public Teacher Teacher { get; set; }
        [ForeignKey("TeacherId")]
        public int TeacherId { get; set; }
        public Course Course { get; set; }

        public int CourseId { get; set; }


    }
}
