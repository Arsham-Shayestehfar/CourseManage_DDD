using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infrastructure.EF.Models.UserManagement
{
    public class UserRoleReadModel
    {
        public Guid UserId { get; set; }
        public UserReadModel User { get; set; }
        public Guid RoleId { get; set; }
        public RoleReadModel Role { get; set; }
    }
}
