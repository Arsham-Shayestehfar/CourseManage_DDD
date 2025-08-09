using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infrastructure.EF.Models.CourseManagement
{
    public class InstructorReadModel : BaseReadModel

    {
        public string FullName { get; set; }
        public string Bio { get; set; }
        public int Experience { get; set; }
        public double Rating { get; set; }
        public IReadOnlyList<CourseReadModel> Courses { get; set; }
    }
}
