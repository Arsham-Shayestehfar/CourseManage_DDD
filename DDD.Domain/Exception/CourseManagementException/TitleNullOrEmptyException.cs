using DDD.Sahred.Absraction.Exceptions;

namespace DDD.Domain.Exception.CourseManagementException;

internal class TitleNullOrEmptyException : Sahred.Absraction.Exceptions.CourseManagementException
{
    public TitleNullOrEmptyException() : base("Title Can not be Empty...!")
    {
    }
}
