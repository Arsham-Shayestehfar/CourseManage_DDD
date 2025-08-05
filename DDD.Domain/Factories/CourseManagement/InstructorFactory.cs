using DDD.Domain.Entities.CourseManagement;
using DDD.Domain.Exception.CourseManagementException;
using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Factories.CourseManagement
{
    public class InstructorFactory : IInstructorFactory
    {
        public Instructor CreateWithExperienceAndRating(BaseId id, FullName fullName, Biography biography, int experience, double rating)
        {
            if (experience < 3)
            {
                throw new InvalidInstructorExperienceException();
            }
            if(rating < 0 )
            {
                throw new InvalidInstructorRatingException();
            }
            return new Instructor(id, fullName, biography, experience, rating);
        }

        public Instructor CreateWithExperienceAndWithoutRating(BaseId id, FullName fullName, Biography biography, int experience)
        {
           if(experience < 3)
            {
                throw new InvalidInstructorExperienceException();
            }
           return new Instructor(id, fullName, biography, experience);
        }

        public Instructor CreateWithoutExperienceAndRating(BaseId id, FullName fullName, Biography biography)
        {
            return new Instructor(id, fullName, biography);
        }
    }
}
