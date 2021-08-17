using CleanArchDemo.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClearArchDemo.Application.ViewModel
{
  public  class CourseViewModel
    {
        public IEnumerable<Course> courses { get; set; }
    }
}
