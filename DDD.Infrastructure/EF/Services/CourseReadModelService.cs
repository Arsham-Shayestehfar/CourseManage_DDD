using DDD.Application.Services;
using DDD.Infrastructure.EF.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infrastructure.EF.Services
{
    public class CourseReadModelService : ICourseReadModelServices
    {
        private readonly ReadDbContext _context;

        public CourseReadModelService(ReadDbContext context)
        {
            _context = context;
        }
        public async Task<bool> IsCourseExistsByName(string courseName)
        {
           return await _context.Courses.AnyAsync(x=>x.Title.Contains(courseName));
        }
    }
}
