﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaavSchool.Entitis.Entitis
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Credit { get; set; }
        public HashSet<TeacherCourses> TeacherCourses { get; set; }
        public HashSet<StudentCourses> StudentCourses { get; set; }
        public Group Group { get; set; }
        public int GroupId { get; set; }

    }
}
