using Microsoft.EntityFrameworkCore;
using TaavSchool.Entitis.Entitis;

namespace api1.EntityMaps
{
    public class EfDataContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Group> groups { get; set; }
        public DbSet<TeacherCourses> teacherCourses { get; set; }
        public DbSet<StudentCourses> studentCourses { get; set; }
        public DbSet<StudentTeachers> studentTeachers { get; set; }
        public DbSet<GroupManager> groupManagers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=TestH1;User Id=sa;Password=Farid22922;TrustServerCertificate=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new StudentEntityMap());
            modelBuilder.ApplyConfiguration(new TeacherEntityMap());

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EfDataContext).Assembly);










            modelBuilder.Entity<Student>()
                 .Property(_ => _.FirstName)
                 .HasMaxLength(50)
                 .IsRequired();





            modelBuilder.Entity<Group>()
                 .HasMany(_ => _.Courses)
                 .WithOne(_ => _.Group)
                 .HasForeignKey(_ => _.GroupId)
                 .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Group>()
               .HasMany(_ => _.Teachers)
               .WithOne(_ => _.Group)
               .HasForeignKey(_ => _.GroupId)
               .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Group>()
               .HasMany(_ => _.Students)
               .WithOne(_ => _.Group)
               .HasForeignKey(_ => _.GroupId)
               .OnDelete(DeleteBehavior.NoAction);












        }







    }
}
