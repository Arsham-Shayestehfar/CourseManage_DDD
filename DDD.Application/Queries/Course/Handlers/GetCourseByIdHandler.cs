using DDD.Application.Dtos;
using DDD.Shared.Abstraction.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Queries.Course.Handlers
{
    public class GetCourseByIdHandler : IQueryHandler<GetCourseById, CourseDto>
    {
        public Task<CourseDto> HandleAsync(GetCourseById query)
        {
            throw new NotImplementedException();
        }
    }
}
