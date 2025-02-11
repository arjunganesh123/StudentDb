// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using StudentDb.Data;
using StudentDb.Models;

using (var context = new AppDataContext())
{
    // Insert Data

    //Student s1 = new()
    //{
    //    Name = "Suresh",
    //    age = 24,
    //    DOB = new DateTime(2001,01,01),
    //    Hobby = "Swimming",
    //    Address = new Address()
    //    {
    //        DoorNo = 1,
    //        Street = "KR.Road",
    //        City = "Bangalore",
    //        State = "Karnataka",
    //        Pin = 560001
    //    }
    //};

    //Student s2 = new()
    //{
    //    Name = "Ramesh",
    //    age = 25,
    //    DOB = new DateTime(2000, 01, 01),
    //    Hobby = "Chess",
    //    Address = new Address()
    //    {
    //        DoorNo = 1,
    //        Street = "KR.Road",
    //        City = "Bangalore",
    //        State = "Karnataka",
    //        Pin = 560001
    //    }
    //};

    //context.Students.Add(s1);
    //context.Students.Add(s2);

    //Course c1 = new()
    //{
    //    Name = "PCMB",
    //};

    //Course c2 = new()
    //{
    //    Name = "PCMC",
    //};

    //context.Courses.Add(c1);
    //context.Courses.Add(c2);


    // Insert Data

    //Lecturer l1 = new()
    //{
    //    Name = "Prasanth",
    //    StudentId = 1,
    //};

    //Lecturer l2 = new()
    //{
    //    Name = "Praveen",
    //    StudentId = 1,
    //};
    //context.Lecturers.Add(l1);
    //context.Lecturers.Add(l2);

    //insert data

    //Subject s1 = new()
    //{
    //    Name = "Physics",
    //    LecturerId = 1,
    //    CourseId = 1,
    //};

    //Subject s2 = new()
    //{
    //    Name = "Chemistry",
    //    LecturerId = 2,
    //    CourseId = 1,
    //};

    //Subject s3 = new()
    //{
    //    Name = "ComputerScience",
    //    LecturerId = 3,
    //    CourseId = 2,
    //};

    //context.Subjects.Add(s1);
    //context.Subjects.Add(s2);
    //context.Subjects.Add(s3);

    //context.SaveChanges();






    //eager loading
    var stu = context.Lecturers
            .Include(e => e.Subjects)
            .ThenInclude(e => e.Course).ToList();

    var lecturer = context.Lecturers;
    var lecturer1 = context.Lecturers.Include(e=>e.Subjects);




    // explicit loading
    var sub = context.Subjects.First();

    context.Entry(sub).Reference(e=>e.Lecturers).Load();

    var cor = context.Courses.First();
    context.Entry(cor).Collection(e=>e.Subjects).Load();


    // Lazy Loading
    // lazy loading with proxie nuget package efcore proxies
    // onconfig methos add .uselazyloadingpros()
    // efcore with lazy load for any property which is virtual

    var lect1 = context.Lecturers;
}