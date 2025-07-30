using DDD.Sahred.Absraction.Exceptions;

namespace DDD.Domain.Exception.CourseManagementException;

internal class InvalidVideoExtensionException : Sahred.Absraction.Exceptions.CourseManagementException
{
    public InvalidVideoExtensionException() : base("Only .mp4 is Valid Extension For Videos...")
    {
    }
}
