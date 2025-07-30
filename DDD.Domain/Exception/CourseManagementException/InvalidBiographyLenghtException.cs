using DDD.Sahred.Absraction.Exceptions;

namespace DDD.Domain.Exception.CourseManagementException;

internal class InvalidBiographyLenghtException : Sahred.Absraction.Exceptions.CourseManagementException
{
    public InvalidBiographyLenghtException() : base("Biography Can Not be More Than 300 Characters")
    {
    }
}
