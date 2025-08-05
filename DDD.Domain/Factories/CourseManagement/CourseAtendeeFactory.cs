using DDD.Domain.Entities.CourseManagement;
using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Factories.CourseManagement
{
    public class CourseAtendeeFactory : ICourseAtendeeFactory
    {
        public CourseAttendee Create(BaseId id, BaseId courseId, BaseId userId)
        {
            return new CourseAttendee(id, courseId, userId);
        }
    }
}
