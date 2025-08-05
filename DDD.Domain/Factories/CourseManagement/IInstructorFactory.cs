using DDD.Domain.Entities.CourseManagement;
using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Factories.CourseManagement
{
    public interface IInstructorFactory
    {
        Instructor CreateWithoutExperienceAndRating(BaseId id, FullName fullName, Biography biography);
        Instructor CreateWithExperienceAndWithoutRating(BaseId id, FullName fullName, Biography biography, int experience);
        Instructor CreateWithExperienceAndRating(BaseId id, FullName fullName, Biography biography, int experience, double rating);

    }
}
