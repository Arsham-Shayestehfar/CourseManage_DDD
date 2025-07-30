using DDD.Shared.Abstraction.Exceptions;

namespace DDD.Domain.Exception.CourseManagementException;

internal class DescriptionNullOrEmptyException : Sahred.Absraction.Exceptions.CourseManagementException
{
    public DescriptionNullOrEmptyException() : base("Description Can not be Null Or Empty..!")
    {
    }
}
