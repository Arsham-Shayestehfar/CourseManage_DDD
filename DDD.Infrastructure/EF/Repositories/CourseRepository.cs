using DDD.Domain.Entities.CourseManagement;
using DDD.Domain.Repositories.CourseManagement;
using DDD.Domain.ValueObjects;
using DDD.Infrastructure.EF.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infrastructure.EF.Repositories
{
    public class CourseRepository : ICourseRepository
    {

        private readonly WriteDbContext _context;

        public CourseRepository(WriteDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Course entity)
        {
           await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Course entity)
        {
             _context.Courses.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<Course>> GetAllAsync()
        {
          return  await _context.Courses.Include("_courseAttendees").ToListAsync();
        }

        public async Task<Course> GetAsync(BaseId id)
        {
          return await _context.Courses.SingleOrDefaultAsync(x=>x.Id == id);
        }

        public async Task UpdateAsync(Course entity)
        {

            _context.Courses.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
