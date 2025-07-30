using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Entities.CourseManagement
{
    public class Lesson
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string videoUrl { get; set; }
        public Guid CourseCatalogId { get; set; }
        public CourseCatalog CourseCatalog { get; set; }
    }
}
