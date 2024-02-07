using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaavSchool.Entitis.Entitis
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public HashSet<Student> Students { get; set; }
        public HashSet<Teacher> Teachers { get; set; }
        public HashSet<Course> Courses { get; set; }
        public GroupManager GroupManager { get; set; }



    }
}
