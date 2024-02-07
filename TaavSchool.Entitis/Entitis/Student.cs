using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaavSchool.Entitis.Entitis
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreateAt { get; set; }
        public Gender Gender { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }


        public Group? Group { get; set; }
        public int GroupId { get; set; }
        public HashSet<StudentCourses> StudentCourses { get; set; }
        public HashSet<StudentTeachers> StudentTeachers { get; set; }


    }
}
