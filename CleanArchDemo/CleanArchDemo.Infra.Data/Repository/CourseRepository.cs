using CleanArchDemo.Domain;
using CleanArchDemo.Domain.Interface;
using CleanArchDemo.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchDemo.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        readonly UniversityDBContext _ctx;
        public CourseRepository(UniversityDBContext ctx )
        {
            _ctx = ctx;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
