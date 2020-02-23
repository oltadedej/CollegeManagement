
using CollegeManagementCore.Concrete;
using CollegeManagementCore.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using static CollegeManagementCore.Utils.Enumerators;

namespace CollegeManagementCore.Migrations
{
    

    internal sealed class Configuration : DbMigrationsConfiguration<SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
           // AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student { FirstMidName = "Carson",   LastName = "Alexander", 
                    EnrollmentDate = DateTime.Parse("2010-09-01"),
                    Birthday = DateTime.Parse("1997-09-01"),
                    RegistrationNumber = "AC2020",
                },
                new Student { FirstMidName = "Meredith", LastName = "Alonso",    
                    EnrollmentDate = DateTime.Parse("2012-09-01"),
                    Birthday = DateTime.Parse("1998-09-01"),
                    RegistrationNumber = "MA2020",

                },
                new Student { FirstMidName = "Arturo",   LastName = "Anand",     
                    EnrollmentDate = DateTime.Parse("2013-09-01"),
                    Birthday = DateTime.Parse("1997-09-01"),
                    RegistrationNumber = "AA2020"
                },
                new Student { FirstMidName = "Gytis",    LastName = "Barzdukas", 
                    EnrollmentDate = DateTime.Parse("2012-09-01"),
                    Birthday = DateTime.Parse("1998-09-01"),
                    RegistrationNumber = "GB2020"
                },
                new Student { FirstMidName = "Yan",      LastName = "Li",        
                    EnrollmentDate = DateTime.Parse("2012-09-01"),
                    Birthday = DateTime.Parse("1995-09-01"),
                    RegistrationNumber = "YL2020"
                },
                new Student { FirstMidName = "Peggy",    LastName = "Justice",   
                    EnrollmentDate = DateTime.Parse("2011-09-01") ,
                    Birthday = DateTime.Parse("1997-09-01") ,
                    RegistrationNumber = "PJ2020"
                },
                new Student { FirstMidName = "Laura",    LastName = "Norman",    
                    EnrollmentDate = DateTime.Parse("2013-09-01") ,
                    Birthday = DateTime.Parse("1996-09-01") ,
                    RegistrationNumber = "LN2020"
                },
                new Student { FirstMidName = "Nino",     LastName = "Olivetto",  
                    EnrollmentDate = DateTime.Parse("2005-09-01"),
                    Birthday = DateTime.Parse("1994-09-01"),
                    RegistrationNumber = "NO2020"
                }
            };


            students.ForEach(s => context.Students.AddOrUpdate(p => p.LastName, s));
            context.SaveChanges();

            var teachers = new List<Teacher>
            {
                new Teacher { FirstMidName = "Kim",     LastName = "Abercrombie", 
                    Birthday = DateTime.Parse("1985-03-11"),
                    Salary=Convert.ToDecimal("1185.5")},
                new Teacher { FirstMidName = "Fadi",    LastName = "Fakhouri",
                    Birthday = DateTime.Parse("1986-07-06"),
                Salary=Convert.ToDecimal("1196.5")},
                new Teacher { FirstMidName = "Roger",   LastName = "Harui",
                    Birthday = DateTime.Parse("1965-07-01") ,
                Salary=Convert.ToDecimal("1254.5")},
                new Teacher { FirstMidName = "Candace", LastName = "Kapoor",
                    Birthday = DateTime.Parse("1987-01-15"),
                Salary=Convert.ToDecimal("1897.5")},
                new Teacher { FirstMidName = "Roger",   LastName = "Zheng",
                    Birthday = DateTime.Parse("1978-02-12"),
                Salary=Convert.ToDecimal("1254.5")}
            };
            teachers.ForEach(s => context.Teachers.AddOrUpdate(p => p.LastName, s));
            context.SaveChanges();

            var courses = new List<Course>
            {
                new Course {ID = 1050, Title = "Informatics",      Credits = 3,
                   Subjects = new List<Subject>()
                },
                new Course {ID = 4022, Title = "Computer Science", Credits = 3,
                  Subjects = new List<Subject>()
                },
                new Course {ID = 4041, Title = "Mathematics", Credits = 3,
                  Subjects = new List<Subject>()
                },
                new Course {ID = 1045, Title = "Information of Technology",       Credits = 4,
                 Subjects = new List<Subject>()
                },
                new Course {ID = 3141, Title = "Economics",   Credits = 4,
                  Subjects = new List<Subject>()
                },

            };
            courses.ForEach(s => context.Courses.AddOrUpdate(p => p.ID, s));
            context.SaveChanges();


            var subjects = new List<Subject>
            {
                new Subject { ID=1,
                    TeacherId = teachers.Single( i => i.LastName == "Fakhouri").ID, 
                    SubjectName = "Linear Algebra",
                    CourseId=1050
                    
                },
                    
                new Subject { 
                    ID=2,
                    TeacherId = teachers.Single( i => i.LastName == "Harui").ID, 
                    SubjectName = "C# Programming",
                     CourseId=1050
                },
                new Subject { 
                    ID=3,
                    TeacherId = teachers.Single( i => i.LastName == "Kapoor").ID, 
                    SubjectName = "Calcus" ,
                 CourseId=3141},
             new Subject { 
                    ID=4,
                    TeacherId = teachers.Single( i => i.LastName == "Zheng").ID, 
                    SubjectName = "JAVA Progrmaming",
              CourseId=1050},
            };
            subjects.ForEach(s => context.Subjects.AddOrUpdate(p => p.ID, s));
            context.SaveChanges();

            //    var enrollments = new List<Enrollment>
            //    {
            //        new Enrollment { 
            //            ID=1,
            //            StudentID = students.Single(s => s.LastName.Equals("Alexander")).ID, 
            //            SubjectID = subjects.Single(c => c.SubjectName.Equals("Linear Algebra")).ID, 
            //            Grade = Grade.A 
            //        },
            //         new Enrollment {
            //             ID=2,
            //            StudentID = students.Single(s => s.LastName.Equals("Alexander")).ID,
            //            SubjectID = subjects.Single(c => c.SubjectName.Equals("JAVA Programming") ).ID, 
            //            Grade = Grade.C 
            //         },                            
            //         new Enrollment { 
            //             ID=3,
            //            StudentID = students.Single(s => s.LastName == "Norman").ID,
            //            SubjectID = subjects.Single(c => c.SubjectName.Equals("Calucus")).ID, 
            //            Grade = Grade.B
            //         },

            //          new Enrollment {
            //              ID=4,
            //            StudentID = students.Single(s => s.LastName.Equals("Alonso")).ID,
            //            SubjectID = subjects.Single(c => c.SubjectName.Equals("Linear Algebra")).ID,
            //            Grade = Grade.A
            //        },
            //         new Enrollment {
            //             ID=5,
            //            StudentID = students.Single(s => s.LastName.Equals("Alonso")).ID,
            //            SubjectID = subjects.Single(c => c.SubjectName.Equals("JAVA Programming") ).ID,
            //            Grade = Grade.C
            //         },
            //         new Enrollment {
            //             ID=6,
            //            StudentID = students.Single(s => s.LastName == "Alonso").ID,
            //            SubjectID = subjects.Single(c => c.SubjectName.Equals("C# Programming")).ID,
            //            Grade = Grade.B
            //         },


            //    };



            //enrollments.ForEach(s => context.Enrollments.AddOrUpdate(p => p.ID, s));
            //    context.SaveChanges();


            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,SubjectID=1,Grade=Grade.A},
            new Enrollment{StudentID=1,SubjectID=4,Grade=Grade.C},

            new Enrollment{StudentID=2,SubjectID=1,Grade=Grade.B},
            new Enrollment{StudentID=2,SubjectID=2,Grade=Grade.F},
            new Enrollment{StudentID=2,SubjectID=4,Grade=Grade.C},

            new Enrollment{StudentID=7,SubjectID=3,Grade=Grade.A}
            };
            enrollments.ForEach(s => context.Enrollments.AddOrUpdate(p=>p.ID,s));
            context.SaveChanges();




        }

    }
}