using DDD.Sahred.Absraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Exception
{
    internal class BaseIdNullException : Sahred.Absraction.Exceptions.CourseManagementException
    {
        public BaseIdNullException() : base("Id can not be empty")
        {

        }
    }
}
