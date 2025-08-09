using DDD.Application.Dtos;
using DDD.Shared.Abstraction.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Queries.Course.Handlers
{
    public class SearchCourseByPhraseHandler : IQueryHandler<SearchCourseByPhrase, IEnumerable<CourseDto>>
    {
        public Task<IEnumerable<CourseDto>> HandleAsync(SearchCourseByPhrase query)
        {
            throw new NotImplementedException();
        }
    }
}
