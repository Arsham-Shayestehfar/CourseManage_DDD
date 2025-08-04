using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Exception.CourseManagementException
{
    public class CourseAttendeeAlreadyExistsException : Sahred.Absraction.Exceptions.CourseManagementException
    {
        public CourseAttendeeAlreadyExistsException() : base("Course Attendee Already Exists...!")
        {
        }
    }
}
