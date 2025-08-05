using DDD.Domain.Entities.CourseManagement;
using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Factories.CourseManagement
{
    public interface ICourseCatalogFactory
    {
        CourseCatalog Create(BaseId id, Title title, Description description, BaseId courseId);
    }
}
