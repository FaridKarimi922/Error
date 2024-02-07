using api1.EntityMaps;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using TaavSchool.Entitis.Entitis;

namespace api1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly EfDataContext _context;
        public StudentController(EfDataContext context)
        {
            _context = context;
        }
        [HttpPost]
        public int Add(AddStudentDto dto)

        {
            var student = new Student
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                CreateAt = DateTime.UtcNow,
                Latitude = dto.Latitude,
                Longitude = dto.Longitude,
                Gender = dto.Gender,
                GroupId = dto.GroupId

            };
            _context.Students.Add(student);
            //_context.SaveChanges();
            return student.Id;
        }
        [HttpGet]
        public List<GetStudentDto> Get()
        {
            return (from std in _context.Students
                    join gp in _context.groups
                    on std.GroupId equals gp.Id
                    into temp
                    from gp in temp.DefaultIfEmpty()
                    select new GetStudentDto
                    {
                        Id = std.Id,
                        FirstName = std.FirstName,
                        LastName = std.LastName,
                        GroupName = gp != null ? gp.Name : null,
                        Latitude = std.Latitude,
                        Longitude = std.Longitude,
                        Gender = std.Gender
                    }
                     ).ToList();





            //return _context.Set<Student>().
            //    Include(_ => _.Group).
            //    Select(_ => new GetStudentDto
            //    {
            //        FirstName = _.FirstName,
            //        LastName = _.LastName,
            //        GroupName = _.Group != null ? _.Group.Name : null,
            //        Latitude = _.Latitude,
            //        Longitude = _.Longitude,
            //        Gender = _.Gender

            //    }).ToList();
        }
    }
    public class AddStudentDto
    {
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]

        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int GroupId { get; set; }
    }
    public class GetStudentDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string? GroupName { get; set; }
    }
}
