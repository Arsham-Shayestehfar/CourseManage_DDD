using DDD.Domain.Entities.CourseManagement;
using DDD.Shared.Abstraction.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.DomainEvents
{
    public record NewCourseCreatedEvent(Course Course):IDomainEvent;
    
}
