using DDD.Shared.Abstraction.Exceptions;

namespace DDD.Domain.Exception.CourseManagementException;

internal class InvalidFullNameLenghtException : Sahred.Absraction.Exceptions.CourseManagementException
{
    public InvalidFullNameLenghtException(int validLenght) : base($"Full Name Can Not be More Than {validLenght} Characters")
    {
    }
}
