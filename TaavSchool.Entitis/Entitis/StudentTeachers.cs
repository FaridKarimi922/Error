using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaavSchool.Entitis.Entitis
{
    public class StudentTeachers
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

    }
}
