using ClearArchDemo.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClearArchDemo.Application.Interface
{
   public interface ICourseService
    {
        CourseViewModel GetCourses();
    }
}
