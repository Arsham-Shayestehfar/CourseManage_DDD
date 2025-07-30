using DDD.Sahred.Absraction.Exceptions;

namespace DDD.Domain.Exception.CourseManagementException;

internal class BiographyNullOrEmptyException :Sahred.Absraction.Exceptions.CourseManagementException 
{
    public BiographyNullOrEmptyException() : base("Biography Can Not be Empty...!")
    {
    }
}
