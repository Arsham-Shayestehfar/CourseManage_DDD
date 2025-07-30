using DDD.Domain.Entities.CourseManagement;
using DDD.Domain.Entities.UserManagement;

namespace DDD.Domain.Entities.PaymentManagement;

public class Invoice
{
    public Guid Id { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
    public Guid CourseId { get; set; }
    public Course Course { get; set; }
}
