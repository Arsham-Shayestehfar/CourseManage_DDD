using DDD.Domain.Entities.PaymentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Repositories.PaymentManagement
{
    public interface IInvoiceRepository  : IGenericRepository<Invoice>
    {
    }
}
