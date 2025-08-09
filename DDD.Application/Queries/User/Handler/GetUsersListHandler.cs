using DDD.Application.Dtos;
using DDD.Shared.Abstraction.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Queries.User.Handler
{
    public class GetUsersListHandler : IQueryHandler<GetUsersList, IEnumerable<UserDto>>
    {
        public Task<IEnumerable<UserDto>> HandleAsync(GetUsersList query)
        {
            throw new NotImplementedException();
        }
    }
}
