using DDD.Sahred.Absraction.Exceptions;

namespace DDD.Domain.Exception.CourseManagementException;

internal class InvalidTitleLenghtException : Sahred.Absraction.Exceptions.CourseManagementException
{
    public InvalidTitleLenghtException(int validLenght) : base($"Title Can not be More Than {validLenght} Characters")
    {
    }
}
