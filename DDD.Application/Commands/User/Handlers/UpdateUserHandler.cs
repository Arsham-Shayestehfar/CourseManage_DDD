using DDD.Application.Commands.Course;
using DDD.Application.Exception;
using DDD.Domain.Factories.UserManagement;
using DDD.Domain.Repositories.UserManagement;
using DDD.Shared.Abstraction.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Commands.User.Handlers
{
    public class UpdateUserHandler : ICommandHandler<UpdateUser>
    {

        private readonly IUserRepository _repository;
        private readonly IUserFactory _factory;

        public UpdateUserHandler(IUserRepository repository, IUserFactory factory)
        {
            _repository = repository;
            _factory = factory;
        }
        public async Task HandleAsync(UpdateUser command)
        {
            var user = await _repository.GetAsync(command.id);
            if (user == null)
            {
                throw new UserNotFoundException();
            }
            user = _factory.Create(user.Id,command.userName,command.password,command.email,command.isConfirmed);
            await _repository.UpdateAsync(user);
        }
    }
}
