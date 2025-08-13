using DDD.Domain.Entities.UserManagement;
using DDD.Domain.Repositories.UserManagement;
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
    public class UserRepository : IUserRepository
    {
        private readonly WriteDbContext _context;

        public UserRepository(WriteDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(User entity)
        {
            await _context.AddAsync(entity);
           await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(User entity)
        {
           _context.Users.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<User>> GetAllAsync()
        {
            return await _context.Users.Include("_userRoles").ToListAsync();
        }

        public async Task<User> GetAsync(BaseId id)
        {
          return await _context.Users.SingleOrDefaultAsync(x => x.Id == id);
            
        }

        public async Task UpdateAsync(User entity)
        {
            _context.Users.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
