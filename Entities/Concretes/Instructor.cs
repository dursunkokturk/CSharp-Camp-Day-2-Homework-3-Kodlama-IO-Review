﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;

public class Instructor
{
    public int InstructorId { get; set; }
    public string InstructorName { get; set; }

    public Course FirstOrDefault(Func<object, bool> value)
    {
        throw new NotImplementedException();
    }
}