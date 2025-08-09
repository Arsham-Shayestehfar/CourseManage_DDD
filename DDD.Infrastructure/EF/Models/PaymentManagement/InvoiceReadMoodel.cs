using DDD.Infrastructure.EF.Models.CourseManagement;
using DDD.Infrastructure.EF.Models.UserManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infrastructure.EF.Models.PaymentManagement
{
    public class InvoiceReadMoodel : BaseReadModel
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }
        public UserReadModel User { get; set; }
        public Guid CourseId { get; set; }
        public CourseReadModel Course { get; set; }
    }
}
