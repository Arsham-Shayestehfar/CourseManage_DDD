using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Exception.CourseManagementException
{
    public class CourseCatalogAlreadyExistsException : Sahred.Absraction.Exceptions.CourseManagementException
    {
        public CourseCatalogAlreadyExistsException() : base("Course Catalog Already Exists...!")
        {
        }
    }
}
