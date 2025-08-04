using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Exception.CourseManagementException
{
    public class CourseAttendeeFoundException : Sahred.Absraction.Exceptions.CourseManagementException
    {
        public CourseAttendeeFoundException() : base("Course Attendee Not Found...!")
        {
        }
    }
}
