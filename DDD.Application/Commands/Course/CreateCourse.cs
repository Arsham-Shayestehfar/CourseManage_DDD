using DDD.Domain.ValueObjects;
using DDD.Shared.Abstraction.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ICommand = DDD.Shared.Abstraction.Commands.ICommand;

namespace DDD.Application.Commands.Course
{
    public record CreateCourse(BaseId id, Title title, Description description, bool isFree, Price price, BaseId instructorId) :ICommand;
    
}
