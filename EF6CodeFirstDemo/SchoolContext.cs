using System.Data.Entity;

namespace EF6CodeFirstDemo
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolDB")
        {
            Database.SetInitializer(new SchoolDBInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentConfigurations());

            modelBuilder.Entity<Teacher>()
                .ToTable("TeacherInfo");

            modelBuilder.Entity<Teacher>()
                .MapToStoredProcedures();
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
    }
}