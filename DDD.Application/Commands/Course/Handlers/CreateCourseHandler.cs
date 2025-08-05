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
    public class CreateCourseHandler : ICommandHandler<CreateCourse>
    {

        private readonly ICourseRepository _repository;
        private readonly ICourseFactory _factory;

        public CreateCourseHandler(ICourseRepository repository, ICourseFactory factory)
        {
            _repository = repository;
            _factory = factory;
        }

        public async Task  HandleAsync(CreateCourse command)
        {
            var course = _factory.Create(command.id,command.title,command.description,command.isFree,command.price,command.instructorId);
            await _repository.CreateAsync(course);
        }
    }
}
