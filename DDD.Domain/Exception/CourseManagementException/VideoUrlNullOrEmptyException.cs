using DDD.Sahred.Absraction.Exceptions;

namespace DDD.Domain.Exception.CourseManagementException;

internal class VideoUrlNullOrEmptyException : Sahred.Absraction.Exceptions.CourseManagementException
{
    public VideoUrlNullOrEmptyException() : base("Video Name Can Not be Empty...!")
    {
    }
}
