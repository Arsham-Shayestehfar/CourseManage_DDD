using DDD.Sahred.Absraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Exception
{
    public class CourseNullException : CourseManagementException
    {
        public CourseNullException() : base("Course can not be empty")
        {
        }
    }
}
