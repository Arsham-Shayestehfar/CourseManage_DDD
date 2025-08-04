using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Exception.CourseManagementException
{
    public class CourseCatalogNotFoundException : Sahred.Absraction.Exceptions.CourseManagementException
    {
        public CourseCatalogNotFoundException() : base("Course Catalog Not Found...!")
        {
        }
    }
}
