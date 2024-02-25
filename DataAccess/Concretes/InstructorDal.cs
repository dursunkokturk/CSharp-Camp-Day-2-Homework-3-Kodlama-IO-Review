using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class InstructorDal:IInstructorDal
{
    List<Instructor> instructors;

    public InstructorDal()
    {
        Instructor instructor1 = new Instructor();
        instructor1.InstructorId = 1;
        instructor1.InstructorName = "Engin Demirog";

        Instructor instructor2 = new Instructor();
        instructor2.InstructorId = 2;
        instructor2.InstructorName = "Halit Enes Kalayci";

        instructors = new List<Instructor> { instructor1, instructor2 };
    }

    public List<Instructor> GetAll()
    {
        return instructors;
    }
    public void Add(Instructor instructor)
    {
        instructors.Add(instructor);
    }

    public void Update(Instructor instructor)
    {
        Course updatedInstructor = instructor.FirstOrDefault(ins => ins.InstructorId == instructor.InstructorId);
        updatedInstructor.InstructorName = instructor.InstructorName;
    }

    public void Delete(Instructor instructor)
    {
        instructor.Remove(instructor);
    }
}