using DDD.Infrastructure.EF.Models.PaymentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infrastructure.EF.Models.CourseManagement
{
    public class CourseReadModel : BaseReadModel
    {
       
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsFree { get; set; }
        public decimal Price { get; set; }
        public Guid InstructorId { get; set; }
        public InstructorReadModel Instructor { get; set; }
        public IReadOnlyList<CourseAttendeReadModel> CourseAttendees { get; set; }
        public IReadOnlyList<CourseCatalogReadModel> CourseCatalogs { get; set; }
        public IReadOnlyList<InvoiceReadMoodel> Invoices { get; set; }
    }
}
