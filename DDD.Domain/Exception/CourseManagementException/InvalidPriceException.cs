using DDD.Sahred.Absraction.Exceptions;

namespace DDD.Domain.Exception.CourseManagementException;

internal class InvalidPriceException : Sahred.Absraction.Exceptions.CourseManagementException
{
    public InvalidPriceException() : base("Price Can not be Negative...!")
    {

    }
}
