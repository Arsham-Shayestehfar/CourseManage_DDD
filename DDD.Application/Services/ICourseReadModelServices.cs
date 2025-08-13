using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Services
{
    public interface ICourseReadModelServices
    {
         Task<bool> IsCourseExistsByName (string courseName);
    }
}
