﻿using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class CourseDal:ICourseDal
{
    List<Course> courses;

    public CourseDal()
    {
        Course course1 = new Course();
        course1.CourseId = 1;
        course1.CourseName = "Java + React - Yazilim Gelistirici Yetistirme Kampi";
        course1.CourseDescription = "Java 15 Version";

        Course course2 = new Course();
        course2.CourseId = 2;
        course2.CourseName = "Java - Yazilim Gelistirici Yetistirme Kampi";
        course2.CourseDescription = "Java 17 Version";

        Course course3 = new Course();
        course3.CourseId = 3;
        course3.CourseName = "Python & Selenium - Yazilim Gelistirici Yetistirme Kampi";
        course3.CourseDescription = "Python 3.12 Version";

        Course course4 = new Course();
        course4.CourseId = 4;
        course4.CourseName = "C# - Yazilim Gelistirici Yetistirme Kampi";
        course4.CourseDescription = "Python 3.12 Version";

        Course course5 = new Course();
        course5.CourseId = 5;
        course5.CourseName = "Programlamaya Giris icin Temel Kurs";
        course5.CourseDescription = "Programlamaya Giris";

        courses = new List<Course> { course1, course2, course3 };
    }
    public List<Course> GetAll()
    {
        return courses;
    }

    public void AddCourse(Course course)
    {
        courses.Add(course);
    }

    public void UpdateCourse(Course course)
    {
        Course updatedCourse = courses.FirstOrDefault(crs => crs.CourseId == course.CourseId);
        updatedCourse.CourseName = course.CourseName;
        updatedCourse.CourseDescription = course.CourseDescription;
    }

    public void DeleteCourse(Course course)
    {
        courses.Remove(course);
    }
}