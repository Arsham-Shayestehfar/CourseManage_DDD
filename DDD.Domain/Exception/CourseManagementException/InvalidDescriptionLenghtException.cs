using DDD.Sahred.Absraction.Exceptions;

namespace DDD.Domain.Exception.CourseManagementException;

internal class InvalidDescriptionLenghtException : Sahred.Absraction.Exceptions.CourseManagementException
{
    public InvalidDescriptionLenghtException(int validLenght) : base($"Description Can Not be More Than {validLenght} Characters")
    {
    }
}
