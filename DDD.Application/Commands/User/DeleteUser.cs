using DDD.Domain.ValueObjects;
using DDD.Shared.Abstraction.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Commands.User
{
   public record DeleteUser(BaseId id) : ICommand;
   
}
