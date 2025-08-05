using DDD.Domain.Factories.CourseManagement;
using DDD.Domain.Factories.UserManagement;
using DDD.Domain.Repositories.CourseManagement;
using DDD.Domain.Repositories.UserManagement;
using DDD.Shared.Abstraction.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Commands.User.Handlers
{
    public class CreateUserHandler : ICommandHandler<CreateUser>
    {
        private readonly IUserRepository _repository;
        private readonly IUserFactory _factory;

        public CreateUserHandler(IUserRepository repository, IUserFactory factory)
        {
            _repository = repository;
            _factory = factory;
        }

        public async Task HandleAsync(CreateUser command)
        {
           var User = _factory.Create(command.id,command.userName,command.password,command.email,command.isConfirmed);
            await _repository.CreateAsync(User);
        }
    }
}
