using DDD.Infrastructure.EF.Models.CourseManagement;
using DDD.Infrastructure.EF.Models.PaymentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infrastructure.EF.Models.UserManagement
{
    public class UserReadModel :BaseReadModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsConfirmed { get; set; }
        public IReadOnlyList<CourseAttendeReadModel> CourseAttendes { get; set; }
        public IReadOnlyList<UserRoleReadModel> UserRoles { get; set; }
        public IReadOnlyList<InvoiceReadMoodel> Invoices { get; set; }
    }
}
