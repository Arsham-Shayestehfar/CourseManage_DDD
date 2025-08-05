using DDD.Application.Exception;
using DDD.Domain.Factories.CourseManagement;
using DDD.Domain.Repositories.CourseManagement;
using DDD.Shared.Abstraction.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Commands.Course.Handlers
{
    public class UpdateCourseHandler : ICommandHandler<UpdateCourse>
    {
        private readonly ICourseRepository _repository;
        private readonly ICourseFactory _factory;

        public UpdateCourseHandler(ICourseRepository repository, ICourseFactory factory)
        {
            _repository = repository;
            _factory = factory;
        }
        public async Task HandleAsync(UpdateCourse command)
        {
            var course =await _repository.GetAsync(command.id);
            if (course == null)
            {
                throw new CourseNullException();
            }
            course =  _factory.Create(course.Id,command.title,command.description,command.isFree,command.price,command.instructorId);
            await _repository.UpdateAsync(course);
        }
    }
}
