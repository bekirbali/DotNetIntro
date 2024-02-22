using kodlamaioLesson1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlamaioLesson1.Business;

internal class CourseManager
{
    public CourseManager() {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "c#";
        course1.Description = ".Net8";
        course1.Price = 0;

        Course course2 = new Course();
        course1.Id = 2;
        course1.Name = "js";
        course1.Description = "React";
        course1.Price = 0;

        Course course3 = new Course();
        course1.Id = 3;
        course1.Name = "python";
        course1.Description = "Python 3.20";
        course1.Price = 0;

        Course[] courses = { course1, course2, course3 };
    }

    public void GetAll()
    {
        Console.WriteLine("courses listed");
    }
}
