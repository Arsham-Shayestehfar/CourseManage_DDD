using DDD.Sahred.Absraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Exception.CourseManagementException
{
    public class InvalidInstructorExperienceException : Sahred.Absraction.Exceptions.CourseManagementException
    {
        public InvalidInstructorExperienceException() : base("Experience can be less then 3 years")
        {
        }
    }
}
