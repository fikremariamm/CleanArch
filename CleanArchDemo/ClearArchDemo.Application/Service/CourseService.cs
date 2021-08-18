using CleanArchDemo.Domain.Interface;
using ClearArchDemo.Application.Interface;
using ClearArchDemo.Application.ViewModel;

namespace ClearArchDemo.Application.Service
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;
        public CourseService(ICourseRepository course)
        {
            this._courseRepository = course;
        }
        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                courses = _courseRepository.GetCourses()
            };
        }
    }
}
