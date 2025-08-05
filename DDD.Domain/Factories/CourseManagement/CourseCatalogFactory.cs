using DDD.Domain.Entities.CourseManagement;
using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Factories.CourseManagement
{
    public class CourseCatalogFactory : ICourseCatalogFactory
    {
        public CourseCatalog Create(BaseId id, Title title, Description description, BaseId courseId)
        {
           return new CourseCatalog(id, title, description, courseId);
        }
    }
}
