using DDD.Application.Dtos;
using DDD.Domain.Entities.CourseManagement;
using DDD.Shared.Abstraction.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Queries.Course.Handlers
{
    public class GetCoursesListHandler : IQueryHandler<GetCoursesList, IEnumerable<CourseDto>>
    {
        public Task<IEnumerable<CourseDto>> HandleAsync(GetCoursesList query)
        {
            throw new NotImplementedException();
        }
    }
}
