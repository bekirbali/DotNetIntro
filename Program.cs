// See https://aka.ms/new-console-template for more information
using kodlamaioLesson1.Business;
using kodlamaioLesson1.Entities;

Console.WriteLine("Hello, World!");


string message1 = "krediler";
int term = 12;
double amount = 100000;
bool isAuth = false;

if (isAuth = false)
{
    
    Console.WriteLine("could not logged in");
}
else
{
    Console.WriteLine("logged in succesfully");
}

string[] loans = ["loan1", "loan2", "loan3", "loan4", "loan5", "loan6"];

for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}


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

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name);
}


CourseManager courseManager = new CourseManager();

courseManager.GetAll();

Console.WriteLine("code ended");