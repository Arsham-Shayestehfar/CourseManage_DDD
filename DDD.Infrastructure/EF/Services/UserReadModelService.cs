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
    public class UserReadModelService : IUserReadModelServices
    {

        private readonly ReadDbContext _context;

        public UserReadModelService(ReadDbContext context)
        {
            _context = context;
        }

        public async Task<bool> IsUserExistsByEmial(string email)
        {
           return await _context.Users.AnyAsync(u => u.Email == email);
        }
    }
}
