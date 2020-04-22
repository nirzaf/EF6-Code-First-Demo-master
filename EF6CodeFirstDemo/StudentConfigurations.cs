using System.Data.Entity.ModelConfiguration;

namespace EF6CodeFirstDemo
{
    public class StudentConfigurations : EntityTypeConfiguration<Student>
    {
        public StudentConfigurations()
        {
            Property(s => s.StudentName)
                .IsRequired()
                .HasMaxLength(50);

            Property(s => s.StudentName)
                .IsConcurrencyToken();

            // Configure a one-to-one relationship between Student & StudentAddress
            HasOptional(s => s.Address) // Mark Student.Address property optional (nullable)
                .WithRequired(ad => ad.Student); // Mark StudentAddress.Student property as required (NotNull).
        }
    }
}