using System.Collections.Generic;
using System.Data.Entity;

namespace EF6CodeFirstDemo
{
    public class SchoolDBInitializer : DropCreateDatabaseAlways<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            IList<Grade> grades = new List<Grade>
            {
                new Grade() { GradeName = "Grade 1", Section = "A" },
                new Grade() { GradeName = "Grade 1", Section = "B" },
                new Grade() { GradeName = "Grade 1", Section = "C" },
                new Grade() { GradeName = "Grade 2", Section = "A" },
                new Grade() { GradeName = "Grade 3", Section = "A" }
            };

            context.Grades.AddRange(grades);
            base.Seed(context);
        }
    }
}