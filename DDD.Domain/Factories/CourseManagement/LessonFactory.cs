using DDD.Domain.Entities.CourseManagement;
using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Factories.CourseManagement
{
    public class LessonFactory : ILessonFactory
    {
        public Lesson Create(BaseId id, Title title, VideoUrl videoUrl, BaseId courseCatalogId)
        {
          return new Lesson (id, title, videoUrl, courseCatalogId);
        }
    }
}
