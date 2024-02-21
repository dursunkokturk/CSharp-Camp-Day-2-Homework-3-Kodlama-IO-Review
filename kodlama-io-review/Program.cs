
using Business.Concretes;
using DataAccess.Concretes;
using Entities.Concretes;
using System.Net.Http.Headers;


CourseManager courseManager = new(new CourseDal());
List<Course> courses = courseManager.GetAll();

Console.WriteLine("Kodlama.io Tum Kurs Bilgileri");
for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].CourseName+" - "+ courses[i].CourseDescription);
}

Console.WriteLine("");

InstructorManager instructorManager = new(new InstructorDal());
List<Instructor> instructors = instructorManager.GetAll();

Console.WriteLine("Kodlama.io Tum Egitmen Bilgileri");
for (int i = 0; i < instructors.Count; i++)
{
    Console.WriteLine(instructors[i].InstructorName);
}

Console.WriteLine("");

CategoryManager categoryManager = new(new CategoryDal());
List<Category> categories = categoryManager.GetAll();
Console.WriteLine("Kodlama.io Tum Kategori Bilgileri");
for (int i = 0; i < categories.Count; i++)
{
    Console.WriteLine(categories[i].CategoryName);
}







/*
 
Java + React - Yazılım Geliştirici Yetiştirme Kampı
Engin Demirog

Java - Yazılım Geliştirici Yetiştirme Kampı
Engin Demirog

Python & Selenium - Yazılım Geliştirici Yetiştirme Kampı
Halit Enes Kalaycı

C# - Yazılım Geliştirici Yetiştirme Kampı
Engin Demirog

Programlamaya Giriş için Temel Kurs
Engin Demirog
 
 */