using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CollegeManagementCore.Concrete;
using static CollegeManagementCore.Utils.Enumerators;

namespace CollegeManagementCore.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01"), Birthday=DateTime.Parse("1997-09-01")},
            new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01"),Birthday=DateTime.Parse("1997-09-01")},
            new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01"),Birthday=DateTime.Parse("1998-09-01")},
            new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01"),Birthday=DateTime.Parse("1999-09-01")},
            new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01"),Birthday=DateTime.Parse("1996-09-01")},
            new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01"),Birthday=DateTime.Parse("1995-09-01")},
            new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01"),Birthday=DateTime.Parse("1994-09-01")},
            new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01"),Birthday=DateTime.Parse("1992-09-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{ID=1050,Title="Informatics",Credits=3,},
            new Course{ID=4022,Title="Computer Science",Credits=3,},
            new Course{ID=4041,Title="Mathematics",Credits=3,},
            new Course{ID=1045,Title="Information of Technology",Credits=4,},
            new Course{ID=3141,Title="Economics",Credits=4,}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,SubjectID=1,Grade=Grade.A},
            new Enrollment{StudentID=1,SubjectID=4,Grade=Grade.C},

            new Enrollment{StudentID=2,SubjectID=1,Grade=Grade.B},
            new Enrollment{StudentID=2,SubjectID=2,Grade=Grade.F},
            new Enrollment{StudentID=2,SubjectID=4,Grade=Grade.C},

            new Enrollment{StudentID=7,SubjectID=3,Grade=Grade.A}
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}