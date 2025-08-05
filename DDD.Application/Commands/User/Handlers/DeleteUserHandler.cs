using DDD.Application.Exception;
using DDD.Domain.Repositories.UserManagement;
using DDD.Shared.Abstraction.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Commands.User.Handlers
{
    public class DeleteUserHandler : ICommandHandler<DeleteUser>
    {
        private readonly IUserRepository _repository;

        public DeleteUserHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task HandleAsync(DeleteUser command)
        {
            var user = await _repository.GetAsync(command.id);
            if (user == null)
            {
                throw new UserNotFoundException();
            }
            await _repository.DeleteAsync(user);
        }
    }
}
