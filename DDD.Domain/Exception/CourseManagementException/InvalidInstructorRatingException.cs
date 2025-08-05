using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Exception.CourseManagementException
{
    public class InvalidInstructorRatingException : Sahred.Absraction.Exceptions.CourseManagementException
    {
        public InvalidInstructorRatingException() : base("Rating can not be less than 0 ")
        {
        }
    }
}
