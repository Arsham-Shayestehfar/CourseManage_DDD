using DDD.Application.Exception;
using DDD.Domain.Repositories.CourseManagement;
using DDD.Shared.Abstraction.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Commands.Course.Handlers
{
    public class DeleteCourseHandler : ICommandHandler<DeleteCourse>
    {
        private readonly ICourseRepository _repository;

        public DeleteCourseHandler(ICourseRepository repository)
        {
            _repository = repository;
        }

        public async Task HandleAsync(DeleteCourse command)
        {
            var course = await _repository.GetAsync(command.id);
            if (course == null)
            {
                throw new CourseNullException();
            }
            await _repository.DeleteAsync(course);
        }
    }
}
