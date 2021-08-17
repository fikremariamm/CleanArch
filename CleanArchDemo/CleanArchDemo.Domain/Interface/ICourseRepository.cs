using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchDemo.Domain.Interface
{
  public  interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
