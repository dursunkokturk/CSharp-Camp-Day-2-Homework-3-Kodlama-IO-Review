using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts;

public interface ICourseDal
{
    List<Course> GetAll();
    void AddCourse(Course course);
    void UpdateCourse(Course course);
    void DeleteCourse(Course course);
}